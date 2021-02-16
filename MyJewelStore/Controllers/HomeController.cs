using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.UI;    
using System.Net;

namespace MyJewelStore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public void GetSessionObject()
        {
            //VOCRepository voc = new VOCRepository();
            //var vocdata = voc.GetFeedbackAnalysis();

            //SessionConfig sesconfig = new SessionConfig();
            //  sesconfig.userName= System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //sesconfig.userName = System.Web.HttpContext.Current.User.Identity.GetUserName();
            //string ip = System.Web.HttpContext.Current.Request.UserHostAddress;
            //string ha = Request.UserHostAddress;
            //string IP = Request.UserHostName;
            //IPAddress myIP = IPAddress.Parse(IP);
            //IPHostEntry GetIPHost = Dns.GetHostEntry(myIP);
            //sesconfig.userName = User.Identity.Name;
            //return Newtonsoft.Json.JsonConvert.SerializeObject(sesconfig);
        }
     
        public ActionResult Index()
        {
            return View();
            //string un = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            // return View(User.Identity.Name);
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
    }
}