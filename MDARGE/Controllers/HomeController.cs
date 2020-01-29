using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using UniHealthWebSite.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Net.Mail;

namespace MDARGE.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index()
        {
 
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult deneme()
        {
            return View();
        }
        public ActionResult ufc()
        {
            return View();
        }
        public ActionResult ckeckout()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult contact(string txtname, string txtemail,string txtphone, string txtsubject, string txtmessage)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "mail.mdarge.com";
            SmtpClient tny = new SmtpClient("mail.mdarge.com", 587);
            //sc.EnableSsl = true;
            MailMessage msg = new MailMessage("websitecontactus@mdarge.com", "websitecontactus@mdarge.com");
            tny.Credentials = new NetworkCredential("websitecontactus@mdarge.com", "OmUr4379");
            sc.Credentials = new NetworkCredential("websitecontactus@mdarge.com", "OmUr4379");
            
            msg.Body ="Konu: "+ txtsubject + "\n\r" + "Ad-Soyad: " + txtname + "\n\r" + "E-Posta: " + txtemail + "\n\r" + "Telefon: " + txtphone + "\n\r" + "Mesaj: " + txtmessage;
            msg.From = new MailAddress("websitecontactus@mdarge.com", txtemail);
            msg.Subject = "Contact Us: " + txtsubject;

            tny.Send(msg);
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Faq( string txtname, string txtemail, string txtsubject, string txtmessage)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "mail.mdarge.com";
            SmtpClient tny = new SmtpClient("mail.mdarge.com", 587);
            //sc.EnableSsl = true;
            MailMessage msg = new MailMessage("websitecontactus@mdarge.com", "websitecontactus@mdarge.com");
            tny.Credentials = new NetworkCredential("websitecontactus@mdarge.com", "OmUr4379");
            sc.Credentials = new NetworkCredential("websitecontactus@mdarge.com", "OmUr4379");

            msg.Body = "Konu: " + txtsubject + "\n\r" + "Ad-Soyad: " + txtname + "\n\r" + "E-Posta: " + txtemail + "\n\r" + "Mesaj: " + txtmessage;
            msg.From = new MailAddress("websitecontactus@mdarge.com", txtemail);
            msg.Subject = "FAQ: " + txtsubject;

            tny.Send(msg);
            return View();
        }
        public ActionResult project1()
        {
            return View();
        }
        public ActionResult dealership()
        {
            return View();
        }
        public ActionResult project3()
        {
            return View();
        }
        public ActionResult project4()
        {
            return View();
        }
        public ActionResult projectSingle()
        {
            return View();
        }
        public ActionResult dcubebasic()
        {
            return View();
        }
        public ActionResult service2()
        {
            return View();
        }
        public ActionResult dcubeauto()
        {
            return View();
        }
        public ActionResult service4()
        {
            return View();
        }
        public ActionResult service5()
        {
            return View();
        }
        public ActionResult service6()
        {
            return View();
        }
        public ActionResult dcuberadyology()
        {
            return View();
        }
        public ActionResult team()
        {
            return View();
        }
        public ActionResult freeContact()
        {
            return View();
        }
        public ActionResult dcubeallInOne()
        {
            return View();
        }
        public ActionResult FreeContact()
        {
            return View();
        }

    }

}

