using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MailMessage mm = new MailMessage("pranav.s.pradeep@gmail.com","sreekalacdlm@gmail.com");
        mm.Subject = "Password Recovery";
        mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You."," username", "password");
        mm.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = true;
        NetworkCredential NetworkCred = new NetworkCredential();
        NetworkCred.UserName = "pranav.s.pradeep@gmail.com";
        NetworkCred.Password = "tec@12417015";
        smtp.UseDefaultCredentials = true;
        smtp.Credentials = NetworkCred;
        smtp.Port = 587;
        smtp.Send(mm);
    }
}