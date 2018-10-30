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
    public string regmailstudent(string name,string email,string userpassword)
    {
        string s = "<html>"+
  "<body>"+
"<p>"+
  "Hie "+name+" "+

"Welcome to TichEdu learning!<br>"+
"Your username is "+email+" and the password is "+ userpassword + " <br><br>"+
"Thank you for your interest in TichEdu learning and congratulations on taking a step towards achieving a pass mark in math. <br> We are proud to announce that we are committed to bringing out and giving the best learning experience as you would get in a normal learning classroom.<br>"+
"Our vision is to provide a world class learning platform with material that instigates a problem solving mentality.<br> We believe that learning is dynamic and imploring new methods and techniques will change the classroom experiences for our clients. <br>"+
   "<p>"+
 "      Our products consist of:"+
  "  </p> "+
   " <ul>"+
  "<li>Online exams</li>  "+

"<li>Worksheets</li>"+
"<li>Video Tutorials</li>"+
"<li>Notes & Examples</li>"+
"<li>Live tutoring</li>"+
"<li>Discussions</li>"+
  "  </ol>"+

"<p> You can contact us anytime by emailing at TichEdu18@gmail.com/ info@TichEdu.com</p>"+

"<p>"+
 " We look forward to being with you on this beautiful maths journey.  </p>"+

"<p>"+
 " Sincerely"+
   " </p>"+
"<p>TichEdu Team</p>"+

"<p>"+
 " info@TichEdu.com/TichEdu18@gmail.com"+
   " </p>"+
  "</body>"+
"</html>";

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
        string userName = "info@TichEdu.com";
        string password = "tich@2018";
        int cdoBasic = 1;
        int cdoSendUsingPort = 2;
        MailMessage msg = new MailMessage();
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", smtpServer);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 25);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", cdoSendUsingPort);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", cdoBasic);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "info@TichEdu.com");
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "tich@2018");
        msg.To = email;
        msg.Bcc = "anishpr2k3@gmail.com";
        msg.From = "info@TichEdu.com";
        msg.Priority = MailPriority.High;
        msg.BodyFormat = MailFormat.Html;
        msg.Subject = name + " Welcome to TichEdu.com";
        msg.Body = s;
        SmtpMail.SmtpServer = smtpServer;
        SmtpMail.Send(msg);
        string a = "ok";
        return a;
       
    }
    public string regmailteacher(string name, string email,string userpassword)
    {
        string s = "<html> <body><p>Hie "+name+"</p><br>"+
"Welcome to TichEdu learning!<br>"+
"Your username is"+ email + " and the password is"+ userpassword + " <br><br>"+
"Thank you for your interest in TichEdu learning and congratulations you have been registered as a tutor.<br> Once our background check is completed you will be able to access students, view, use and add materials."+
"Our vision is to provide a world class learning platform with material that instigates a problem solving mentality.We believe that learning is dynamic and imploring new methods and techniques will change the classroom experiences for our student.At TichEdu, we believe you are committed to offer the best to our student and hope you will always demonstrate the best practices.<br>"+
"You can contact us anytime by emailing at TichEdu18 @gmail.com/ info @TichEdu.com<br>"+
"We look forward to being with you <br><br>"+
"Sincerely<br>"+
"<p>TichEdu Team</p>"+
"<p>info@TichEdu.com/TichEdu18@gmail.com</p>"+
 "</body>" +
   " </html>";

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
        string userName = "info@TichEdu.com";
        string password = "tich@2018";
        int cdoBasic = 1;
        int cdoSendUsingPort = 2;
        MailMessage msg = new MailMessage();
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", smtpServer);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 25);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", cdoSendUsingPort);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", cdoBasic);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "info@TichEdu.com");
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "tich@2018");
        msg.To = email;
        msg.Bcc = "anishpr2k3@gmail.com";
        msg.From = "info@TichEdu.com";
        msg.Priority = MailPriority.High;
        msg.BodyFormat = MailFormat.Html;
        msg.Subject = name + " Welcome to TichEdu.com";
        msg.Body = s;
        SmtpMail.SmtpServer = smtpServer;
        SmtpMail.Send(msg);
        string a = "ok";
        return a;

    }
    public string regmailparents(string name, string email, string userpassword)
    {
        string s = "<html>"+
 "<body>"+
 "<p> Hie "+name+"</p><br>"+
"<p> Welcome to TichEdu learning! </p>" +
   "<p> Your username is "+email+" and the password is "+ userpassword +" </p>"+
      
         " <p> Thank you for your interest in TichEdu learning and congratulations you have been registered as a parent / guardian. </p>"+
         
            " <p> Our vision is to provide a world class learning platform with material that instigates a problem solving mentality. </p>"+
"<p>We believe that learning is dynamic and imploring new methods and techniques will change the classroom experiences for our student.</p><p> At TichEdu, we believe you are committed to the progress of your child.TichEdu team will constantly give you news, update and summary of your child’s activities.</p>"+
"<p>You can contact us anytime by emailing at TichEdu18 @gmail.com/ info @TichEdu.com</p>"+
"<p>We look forward to being with you</p>"+
"<p>Sincerely</p>"+
"<p>TichEdu Team </p>"+
"<p>info@TichEdu.com/TichEdu18@gmail.com</p>"+

 "</body>"+
"</html>";

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
        string userName = "info@TichEdu.com";
        string password = "tich@2018";
        int cdoBasic = 1;
        int cdoSendUsingPort = 2;
        MailMessage msg = new MailMessage();
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserver", smtpServer);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 25);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", cdoSendUsingPort);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", cdoBasic);
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", "info@TichEdu.com");
        msg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", "tich@2018");
        msg.To = email;
        msg.Bcc = "anishpr2k3@gmail.com";
        msg.From = "info@TichEdu.com";
        msg.Priority = MailPriority.High;
        msg.BodyFormat = MailFormat.Html;
        msg.Subject = name + " Welcome to TichEdu.com";
        msg.Body = s;
        SmtpMail.SmtpServer = smtpServer;
        SmtpMail.Send(msg);
        string a = "ok";
        return a;

    }
}