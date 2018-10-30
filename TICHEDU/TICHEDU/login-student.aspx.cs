using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Error_label.Visible = false;

    }

    protected void Submit_btn_Click(object sender, EventArgs e)
    {
        try
        {
            String userId = "";
            String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

            SqlConnection con = new SqlConnection(strConnString);

            string uid = Request.Form["login_email"];
            string pass = Request.Form["login_password"];
            con.Open();
            string qry = "select * from TBL_STUDENT_REGISTRATION where STUDENT_EMAIL='" + uid + "' and STUDENT_PASSWORD='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                userId = sdr["STUDENT_ID"].ToString();


           
                Response.Redirect("student.aspx?student=" + userId);

               
            }
            else
            {
                // Response.Redirect("login-student.aspx");
                Error_label.Visible = true;

            }
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void Googlelogin_Click(object sender, EventArgs e)
    {
        string clientid = "249797267239-eagt226h77mtc3csfcgej0hn6fqcus42.apps.googleusercontent.com";
        string clientsecret = "7igXmjOqdERcmTj6m40Z4LGW";
        string redirection_url = "http://www.TichEdu.in/Edu/student";
        string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + clientid + "";
        Response.Redirect(url);
    }

    protected void lostpasslink_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgotpasswordstudent.aspx");
    }
}
