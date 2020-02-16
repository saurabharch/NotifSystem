namespace NotifSystem.Default.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/DemoNotification"), Route("{action=index}")]
    [Authorize]
    public class DemoNotificationController : Controller
    {
        // GET: SimpleChat
        public ActionResult Index()
        {
            return View("~/Modules/Default/DemoNotification/DemoNotificationIndex.cshtml");
        }
    }
}