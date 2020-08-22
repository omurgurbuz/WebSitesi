using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using UniHealthWebSite.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Net.Mail;
using System.Data.SQLite;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;

namespace MDARGE.Controllers
{

    public class HomeController : Controller
    {
        SQLiteConnection baglan = new SQLiteConnection();


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
        public ActionResult contact(string txtname, string txtemail, string txtphone, string txtsubject, string txtmessage)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "mail.mdarge.com";
            SmtpClient tny = new SmtpClient("mail.mdarge.com", 587);
            MailMessage msg = new MailMessage("info@mdarge.com", "info@mdarge.com");
            tny.Credentials = new NetworkCredential("info@mdarge.com", "OmUr4379");
            sc.Credentials = new NetworkCredential("info@mdarge.com", "OmUr4379");

            msg.Body = "Konu: " + txtsubject + "\n\r" + "Ad-Soyad: " + txtname + "\n\r" + "E-Posta: " + txtemail + "\n\r" + "Telefon: " + txtphone + "\n\r" + "Mesaj: " + txtmessage;
            msg.From = new MailAddress("info@mdarge.com", txtemail);
            msg.Subject = "Contact Us: " + txtsubject;
            tny.Send(msg);
            ViewBag.Message = String.Format("Mesajınız başarıyla gönderilmiştir.", DateTime.Now.ToString());
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Faq(string txtname, string txtemail, string txtsubject, string txtmessage)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "mail.mdarge.com";
            SmtpClient tny = new SmtpClient("mail.mdarge.com", 587);
            //sc.EnableSsl = true;
            MailMessage msg = new MailMessage("mail.mdarge.com", "mail.mdarge.com");
            tny.Credentials = new NetworkCredential("mail.mdarge.com", "OmUr4379");
            sc.Credentials = new NetworkCredential("mail.mdarge.com", "OmUr4379");

            msg.Body = "Konu: " + txtsubject + "\n\r" + "Ad-Soyad: " + txtname + "\n\r" + "E-Posta: " + txtemail + "\n\r" + "Mesaj: " + txtmessage;
            msg.From = new MailAddress("mail.mdarge.com", txtemail);
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
        public ActionResult smartQaUnique1()
        {
            return View();
        }
        public ActionResult smartQaUnique2()
        {
            return View();
        }
        public ActionResult smartQaUnique3()
        {
            return View();
        }
        public ActionResult download()
        {
            return View();
        }

        [HttpPost]
        [Obsolete]
        public ActionResult download(string key)
        {
            TempData["mesaj"] = null;
            try
            {
                string ip = Request.UserHostAddress;
                string browser = Request.Browser.Browser;
                DateTime now = DateTime.Now;
                string a = now.ToString("yyyyMMddhhmmss");

                string conString = "Data Source = www.mdarge.com\\MSSQLSERVER2017; Initial Catalog = SoftwareLicenses; Persist Security Info=True;User ID = DCube; Password=tUnAy2020";
                SqlConnection baglanti = new SqlConnection(conString);
                baglanti.Open();
                string sqlStr = "select * from dcubeSetupKeys where SoftwareKey='" + key + "'";

                SqlCommand com = new SqlCommand(sqlStr, baglanti);
                SqlDataReader reader = com.ExecuteReader();
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Load(reader);

                if (dt.Rows.Count > 0)//key dogru
                {
                    if (dt.Rows[0]["Browser"] is System.DBNull && dt.Rows[0]["IPAddress"] is System.DBNull && dt.Rows[0]["DownloadDateTime"] is System.DBNull)
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"C:\\Users\\user\\Desktop\\Deneme\\tny.jpg");
                        string save = "update  dcubeSetupKeys set Browser='" + browser + "',IPAddress='" + ip + "', DownloadDateTime='" + a + "'where SoftwareKey='" + key + "'";
                        com = new SqlCommand(save, baglanti);
                        com.ExecuteNonQuery();
                    }
                    else
                    {
                        TempData["mesaj"] = "Wrong password! Please try again.";
                    }
                }
                else//key yanlış
                {
                    TempData["mesaj"] = "Wrong password! Please try again.";
                }
            }

            catch (Exception)
            {
                TempData["mesaj"] = "Wrong password! Please try again.";
            }
            return View();
        }
    }

}

