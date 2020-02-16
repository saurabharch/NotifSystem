namespace NotifSystem.Default.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/SimpleChat"), Route("{action=index}")]
    [Authorize]
    public class SimpleChatController : Controller
    {
        // GET: SimpleChat
        public ActionResult Index()
        {
            return View("~/Modules/Default/SimpleChat/SimpleChatIndex.cshtml");
        }
    }
}