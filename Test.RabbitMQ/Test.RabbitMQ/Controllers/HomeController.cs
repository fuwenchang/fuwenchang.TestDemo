using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.MQ;

namespace Test.RabbitMQ.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Message msg = new Message()
            {
                MessageID = 1.ToString(),
                MessageBody = DateTime.Now.ToString(),
                MessageRouter = "testKey", //在127.0.0.1：15672上定义好的Exchanges
                MessageTitle = "测试"
            };
            MQHelper.Publish(msg);

            return View();
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