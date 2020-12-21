using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QUANLYSINHVIEN.Models.viewmodel
{
    public class UserViewModel
    {
        public string Username { get; set;}
        public string Password { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}