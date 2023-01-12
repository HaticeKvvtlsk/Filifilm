using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{ 

    public class MailGonder
    {
    
        public void mesajgonder(string from, string pass, string to, string topass, string konu,
       string icerik)
        {
      
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            //sc.Credentials = new NetworkCredential("nilufer_bad_34@hotmail.com", "1472Suiren156");
            sc.Credentials = new NetworkCredential(from, pass);

            MailMessage mesajim = new MailMessage();
            mesajim.From = new MailAddress(from, "Filifilm");
            mesajim.To.Add(to);
            mesajim.Subject = konu;
            mesajim.IsBodyHtml = true;
            mesajim.Body = icerik;
            sc.Send(mesajim);

        }
    }
}
