using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asthanarht.fbindi.Helper;
using System.Collections;
using asthanarht.fbindi.ViewModels;

namespace asthanarht.fbindi.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArrayList al = new ArrayList();
            var fb = new FacebookClient();
            fb.AccessToken = Session["AccessToken"].ToString();
            dynamic me = fb.Get("me/Home?limit=18");
            string t = Convert.ToString(me);
            var ts = JsonHelper.Deserialize<FbWallViewModel>(t);
            return View(ts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
