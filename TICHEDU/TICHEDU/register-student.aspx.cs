using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sucess.Visible = false;
        errormsg.Visible = false;
    }

    protected void contact_form_submit_ServerClick(object sender, EventArgs e)
    {
        
        String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        SqlConnection con = new SqlConnection(strConnString);

        SqlCommand cmd = new SqlCommand();

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "STUDENT_REGISTRATION_INSERT";

        cmd.Parameters.Add("@TEACHER_FIRST_NAME", SqlDbType.VarChar, 50).Value = Request.Form["Firstname_txtbox"];
        cmd.Parameters.Add("@TEACHER_LAST_NAME", SqlDbType.VarChar, 50).Value = Request.Form["Lastname_txtbox"];
        string date = Request.Form["Dob_txtbox"];
        cmd.Parameters.Add("@TEACHER_DOB", SqlDbType.DateTime).Value = date;
        cmd.Parameters.Add("@TEACHER_SEX", SqlDbType.VarChar, 50).Value = Request.Form["Sex_txtbox"];
       // cmd.Parameters.Add("@TEACHER_QUALIFICATION", SqlDbType.VarChar, 50).Value = Request.Form["Qual_txtbox"];
        cmd.Parameters.Add("@STUDENT_STUDYINGIN", SqlDbType.VarChar, 50).Value = Request.Form["Studyingin_txtbox"];
        cmd.Parameters.Add("@TEACHER_SPECIALIZATION", SqlDbType.VarChar, 50).Value = Request.Form["Special_txtbox"];
        cmd.Parameters.Add("@TEACHER_EMAIL", SqlDbType.VarChar, 50).Value = Request.Form["Email_txtbox"];
        string a = Request.Form["Contact_txtbox"];
        long contact = Convert.ToInt64(a);
        cmd.Parameters.Add("@TEACHER_CONTACT", SqlDbType.BigInt).Value = contact;
        cmd.Parameters.Add("@TEACHER_ADDRESS", SqlDbType.VarChar, 50).Value = Request.Form["Address_txtbox"];
        cmd.Parameters.Add("@TEACHER_COUNTRY", SqlDbType.VarChar, 50).Value = Request.Form["Country_txtbox"];
        cmd.Parameters.Add("@TEACHER_CITY", SqlDbType.VarChar, 50).Value = Request.Form["City_txtbox"];
        cmd.Parameters.Add("@TEACHER_ZIP", SqlDbType.VarChar, 50).Value = Request.Form["Zip_txtbox"];
        cmd.Parameters.Add("@TEACHER_STREET", SqlDbType.VarChar, 50).Value = Request.Form["Street_txtbox"];

      //  cmd.Parameters.Add("@TEACHER_USERNAME", SqlDbType.VarChar, 50).Value = Request.Form["Username_txtbox"];
        cmd.Parameters.Add("@TEACHER_PASSWORD", SqlDbType.VarChar, 50).Value = Request.Form["Password_txtbox"];
        cmd.Parameters.Add("@TEACHER_WHERE_HERE_ABOUT", SqlDbType.VarChar, 50).Value = Request.Form["Whereyhere"];
        cmd.Parameters.Add("@TEACHER_PHOTO", SqlDbType.VarBinary).Value = file.FileBytes;
        cmd.Connection = con;
        try
        {
            con.Open();
           int i= cmd.ExecuteNonQuery();
            if (i != 0)
            {

                sucess.Visible = true;
                Registration registration = new Registration();
                registration.regmailstudent(Request.Form["Firstname_txtbox"], Request.Form["Email_txtbox"], Request.Form["Password_txtbox"]);
               // sentmail(Request.Form["Firstname_txtbox"], Request.Form["Email_txtbox"]);
                clear();

            }
            else
            {
                sucess.Visible = false;
                errormsg.Text = "Registrtaion Unsucessfull";

            }
            con.Close();
        }
        catch (Exception an)
        {
            throw an;
        }
      



    }

    public void sentmail(string firstname, string email)
    {
        string s = "<html><body> <table border=3 color=blue width=700> <tr><td><font color=blue><table border=0 color=green><tr><td><img src=http://www.tichedu.com/images/logo.png width=700></img></td></tr><tr><td>" +
       "<h2><font color=Green> " + firstname + "  A BIG THANK YOU!!! </h2> <h1> & WELCOME STUDENT </h1></font><br><hr forecolor=Red> " +
       "<p><font color=blue> <h3>www.tichedu.com would like to welcome you as a new customer to our firm. We know " +
       "that you will be extremely satisfied with our  service we provide" +
       "to our customers. <br><br>" +
       "We Offer discount and wide range of medicine and Healthcare Products under one roof." +
       "We believe that you will find our prices competitive and in keeping with industry trends. <br><br><br>" +
       "Throughout the year we offer our valued customers frequent discounts as an a showing " +
       "of our appreciation. <br>" +
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
        msg.Subject = Request.Form["Firstname_txtbox"] + " Welcome to Tichedu.com";
        msg.Body = s;
        SmtpMail.SmtpServer = smtpServer;
        SmtpMail.Send(msg);
    }

    public void clear()
    {
        Firstname_txtbox.Value = "";
        Lastname_txtbox.Value = "";
        Sex_txtbox.Value = "";
        Studyingin_txtbox.Value = "";
      //  Subject_txtbox.Value = "";
        Special_txtbox.Value = "";
        Email_txtbox.Value = "";
        Contact_txtbox.Value = "";
        Address_txtbox.Value = "";
        Country_txtbox.Value = "";
        City_txtbox.Value = "";
        Zip_txtbox.Value = "";
        Street_txtbox.Value = "";
        Password_txtbox.Value = "";
        Dob_txtbox.Value = "";
     //   Sex_input.Value = "";
        Whereyhere.Value = "";
    }
}