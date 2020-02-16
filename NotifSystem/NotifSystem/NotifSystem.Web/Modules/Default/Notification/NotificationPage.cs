
namespace NotifSystem.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Notification"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.NotificationRow))]
    public class NotificationController : Controller
    {
        public ActionResult Index()
        {
            throw new HttpException(404, "Not Found");
            //return View("~/Modules/Default/Notification/NotificationIndex.cshtml");
        }
    }
}