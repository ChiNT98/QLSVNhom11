using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using QUANLYSINHVIEN.Models;
using QUANLYSINHVIEN.Models.viewmodel;

namespace QUANLYSINHVIEN.Controllers
{
    public class HomeController : Controller
   
    {
        DBConnect db = new DBConnect();
        private static object md5;
        public ActionResult DemoLinq()
        {
            List<UserViewModel> query = (from user in db.Accouts
                                         join role in db.Roles
                                         on user.RoleID equals role.RoleID
                                         select new UserViewModel
                                         {
                                             Username = user.Username,
                                             Password = user.Password,
                                             RoleID = user.RoleID,
                                             RoleName = role.RoleName,
                                         }).ToList<UserViewModel>();
            return View(query);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DangNhap()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(string email, string password)
        {
            if(ModelState.IsValid)
            {
                var ma_hoa_du_lieu = GETMD5(password);
                var kiem_tra_tai_khoan = db.Accouts.Where(s => s.Email.Equals(email) && s.Password.Equals(ma_hoa_du_lieu)).ToList();
                if (kiem_tra_tai_khoan != null)
                {
                    Session["Username"] = kiem_tra_tai_khoan.FirstOrDefault().Username;
                    Session["Email"] = kiem_tra_tai_khoan.FirstOrDefault().Email;
                    Session["Email"] = kiem_tra_tai_khoan.FirstOrDefault().Email;                       
                    var checkAdmin = kiem_tra_tai_khoan.FirstOrDefault().RoleID.ToString();
                    var checkMod = kiem_tra_tai_khoan.FirstOrDefault().RoleID.ToString();

                         if (checkAdmin == "Admin")
                         {
                           return RedirectToAction("Index", "Home", new { Area = "Admin" });
                         }
                         else if (checkMod == "Mod")
                         { 
                          return RedirectToAction("Index", "Home", new { Area = "Mod" });
                         }

                         else
                          {
                         return RedirectToAction("Index");
                          }
                 
                }   
                else
                    {
                    ViewBag.LoginError = "Đăng Nhập Không Thành Công";
                    return RedirectToAction("DangNhap");
                    }    

            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("DangNhap");
        }



        public ActionResult DangKy ()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(accout n)
        {
           if(ModelState.IsValid)
            {
                var checkEmail = db.Accouts.FirstOrDefault(m => m.Email == n.Email);
                if(checkEmail == null)
                {
                    n.Password = GETMD5(n.Password);
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Accouts.Add(n);
                    db.SaveChanges();
                    return RedirectToAction("DangNhap");
                } 
                else
                {
                    ViewBag.EmailError = "Email Đã Tồn Tại";
                    return RedirectToAction("DangKy");
                }    
            }
            return View();
        }
        public static string GETMD5(string pass)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(pass);
            byte[] targetData = md5.ComputeHash(fromData);
            string MK_da_ma_hoa = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                MK_da_ma_hoa += targetData[i].ToString("x2");

            }
            return MK_da_ma_hoa;

        }

    }
    }
