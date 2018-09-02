using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for ForgotPassword
/// </summary>
public class ForgotPassword
{
   public string Getuserpass(string email,string selectquery,string key)
    {
        string sussess = "";
        string username = string.Empty;
        string password = string.Empty;
        string constr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            //using (SqlCommand cmd = new SqlCommand("SELECT Username, [Password] FROM Users WHERE Email = @Email"))
            using (SqlCommand cmd = new SqlCommand(selectquery))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    if (sdr.Read())
                    {
                      //  username = sdr["Username"].ToString();
                        password = sdr[key].ToString();
                    }
                }
                con.Close();
            }
        }
        if (!string.IsNullOrEmpty(password))
        {
            MailMessage mm = new MailMessage("info@tichedu.com", email);
            mm.Subject = "Password Recovery";
            mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.",email, password);
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "localhost";
            smtp.EnableSsl = false;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "info@tichedu.com";
            NetworkCred.Password = "tich@2018";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mm);

            
          
        }

        return sussess = "ok";

    }
}