using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mail;

/// <summary>
/// Summary description for Registration
/// </summary>
public class Registration
{
    public string regmail(string name,string email)
    {
        string s = "<html><body> <table border=3 color=blue width=700> <tr><td><font color=blue><table border=0 color=green><tr><td><img src=http://www.tichedu.com/images/logo.png width=700></img></td></tr><tr><td>" +
           "<h2><font color=Green> " + name + "  A BIG THANK YOU!!! </h2> <h1> & WELCOME TEACHER </h1></font><br><hr forecolor=Red> " +
           "<p><font color=blue> <h3>www.tichedu.com would like to welcome you as a new customer to our firm. We know " +
           "that you will be extremely satisfied with our  service we provide" +
           "to our customers. <br><br>" +
           
           "We do hope you will afford us the opportunity to serve you in the near future. <br><br>" +

           "</h3></p></font><br><br> <font size=4 color=Red><b><i>Very truly.<br>" +
           "<br>" +

           "www.tichedu.com <br>" +
           "info@tichedu.com <br>" +
           "</td></tr></table></td></tr></table></body></html>";

        //< br><h2> Now Get Medicines at your door step with real price from India's No1 Pharamacy Distributor </h2><br>" +
        //"We also wish you a healthy life </font></h2><br><br> <font color=blue> Please contact our customer care if you need more assist PH : +91 474 2744 014 <br>" +
        //"Or mail us at info@medmaa.com.";



        //SmtpClient client = new SmtpClient("dedrelay.secureserver.net", 25);
        //client.EnableSsl = true;
        // client.UseDefaultCredentials = false;
        //client.EnableSsl = false;
        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //client.Credentials = new NetworkCredential("care@medmaa.in", "Medmaa7997");

        //MailMessage message = new MailMessage("care@medmaa.in", email.Text);
        //message.IsBodyHtml = true;
        //message.Subject = name.Text + " Welcome to Medmaa..India's No1 Pharamacy Distributor";
        //message.Body = msg;

        //client.Send(message);


        string smtpServer = "localhost";
        string userName = "info@tichedu.com";
        string password = "tich@2018";
        int cdoBasic = 1;
        int cdoSendUsingPort = 2;
        MailMessage msg = new MailMessage();
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", smtpServer);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 25);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", cdoSendUsingPort);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", cdoBasic);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "info@tichedu.com");
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "tich@2018");
        msg.To = email;
        msg.Bcc = "anishpr2k3@gmail.com";
        msg.From = "info@tichedu.com";
        msg.Priority = MailPriority.High;
        msg.BodyFormat = MailFormat.Html;
        msg.Subject = name + " Welcome to Tichedu.com";
        msg.Body = s;
        SmtpMail.SmtpServer = smtpServer;
        SmtpMail.Send(msg);
        string a = "ok";
        return a;
       
    }
}