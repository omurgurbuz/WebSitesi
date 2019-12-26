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
        public ActionResult medicawellPremium()
        {
            return View();
        }
        public ActionResult blogGrid()
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
        public ActionResult contact(FormCollection form)
        {
            //FaqQuestions model = new FaqQuestions();
            //model.UserName = form["txtname"].Trim();
            //model.UserMail = form["txtemail"].Trim();
            //model.Subject = form["txtsubject"].Trim();
            //model.Questions = form["txtmessage"].Trim();
            //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            //SmtpClient sc = new SmtpClient();
            //sc.Port = 587;
            //sc.Host = "mail.mdarge.com";
            //SmtpClient tny = new SmtpClient("mail.mdarge.com", 587);
            ////sc.EnableSsl = true;
            //MailMessage msg = new MailMessage("tunay.yilmaz@mdarge.com", "mert.karagoz@mdarge.com");
            //tny.Credentials = new NetworkCredential("tunay.yilmaz@mdarge.com", "12345678");
            //sc.Credentials = new NetworkCredential("tunay.yilmaz@mdarge.com", "12345678");
            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("tunaysabriyilmaz@gmail.com", model.UserMail);
            //mail.To.Add("tunaysabriyilmaz@gmail.com");
            //mail.Subject = model.Subject;
            //mail.IsBodyHtml = true;
            //mail.Body = model.Questions;
            ////sc.Send(mail);
            //msg.Subject = model.Subject;
            //msg.Body = model.Questions + "," + "////////" + "," + model.UserMail;

            //tny.Send(msg);
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Faq( string txtname, string txtemail, string subject, string txtmessage)
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
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("websitecontactus@mdarge.com", txtemail);
            mail.To.Add("websitecontactus@mdarge.com");
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = txtmessage;
            sc.Send(mail);
            msg.Subject = subject;
            msg.Body = txtmessage + "," + "////////" + "," + txtemail;

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
        public ActionResult testimonials()
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
        

        //[HttpGet]
        //public ActionResult FreeContact()
        //{
        //    CMSEntitiesDBContext db = new CMSEntitiesDBContext();
        //    List<SelectListItem> ListSelectListItem = new List<SelectListItem>();
        //    foreach (CityName cityNameText in db.Cities)
        //    {
        //        SelectListItem selectListItem = new SelectListItem()
        //        {
        //            Text = cityNameText.CityNameText,
        //            Value = cityNameText.CityId.ToString()

        //        };
        //        ListSelectListItem.Add(selectListItem);
        //    }
        //    CitiesViewModel citiesViewModel = new CitiesViewModel();
        //    citiesViewModel.Cities = ListSelectListItem;
        //    return View(citiesViewModel);
        //}


        //    return View();
        //}

        //[HttpPost]
        //public ActionResult About(FormCollection form)
        //{
        //    CMSEntities db = new CMSEntities();
        //    FreeTrial mdl = new FreeTrial();
        //    mdl.NameSurname = form["txtbxYetkiliKisi"].Trim();
        //    mdl.EMail = form["txtbxMail"].Trim();
        //    mdl.Phone = Convert.ToString(form["txtbxTelefon"].Trim()); ;
        //    mdl.CompanyName = form["txtbxFirmaAdi"].Trim();
        //    db.FreeTrial.Add(mdl);
        //    db.SaveChanges();


        //    return View();
        //}
        [HttpPost]
        public ActionResult FreeContact(FormCollection form)
        {
            return View();
        }
        public void sendMail(String tomail, String subject = "", String message = "")
        {

            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("websitecontactus@mdarge.com");
            eposta.To.Add(tomail);
            eposta.Subject = subject;
            eposta.Body = message;
            eposta.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.mdarge.com", 587);
            smtp.Credentials = new NetworkCredential("websitecontactus@mdarge.com", "OmUr4379");
            //smtp.Port = 587;
            smtp.EnableSsl = true;
            //smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            //smtp.UseDefaultCredentials = false;
           // smtp.Host = "smtp.gmail.com";
            smtp.Send(eposta);

        }

    }

}

