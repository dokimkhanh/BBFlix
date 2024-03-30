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
                "Admin_Genres",
                "admin/the-loai",
                new { controller = "Genre", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "Admin_Add_Genres",
               "admin/the-loai/them",
               new { controller = "Genre", action = "Add", id = UrlParameter.Optional }
           );

            context.MapRoute(
               "Admin_Update_Genres",
               "admin/the-loai/cap-nhat/{id}",
               new { controller = "Genre", action = "Edit", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "Admin_Users",
                "admin/thanh-vien",
                new { controller = "Users", action = "Index", id = UrlParameter.Optional }
            );

            context.MapRoute(
                "Admin_AddUsers",
                "admin/thanh-vien/them-thanh-vien",
                new { controller = "Users", action = "Add", id = UrlParameter.Optional }
            );

            context.MapRoute(
               "Admin_UpdateUsers",
               "admin/thanh-vien/cap-nhat/{id}",
               new { controller = "Users", action = "Edit", id = UrlParameter.Optional }
           );

            context.MapRoute(
                "Admin_Movie",
                "admin/danh-sach-phim",
                new { controller = "Movie", action = "Index", id = UrlParameter.Optional }
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