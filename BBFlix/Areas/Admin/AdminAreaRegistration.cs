using System.Web.Mvc;

namespace BBFlix.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_Review",
                "admin/danh-gia",
                new { controller = "Review", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_Users",
                "admin/thanh-vien",
                new { controller = "Users", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_Movie",
                "admin/danh-sach-phim",
                new { controller = "Catalog", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_Dashboard",
                "admin/trang-chu",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_Dashboard_Default",
                "admin",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}