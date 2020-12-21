using System.Web.Mvc;

namespace QUANLYSINHVIEN.Areas.Mod
{
    public class ModAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Mod";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Mod_default",
                "Mod/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "QUANLYSINHVIEN.Areas.Mod.Controllers" }
            );
        }
    }
}