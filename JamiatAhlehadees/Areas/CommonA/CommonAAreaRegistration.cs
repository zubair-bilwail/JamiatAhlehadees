using System.Web.Mvc;

namespace JamiatAhlehadees.Areas.CommonA
{
    public class CommonAAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CommonA";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CommonA_default",
                "CommonA/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}