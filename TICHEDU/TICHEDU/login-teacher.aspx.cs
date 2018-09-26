using ASPSnippets.GoogleAPI;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login_teacher : System.Web.UI.Page
{
    public string userid { get; set; }


    protected void Page_Load(object sender, EventArgs e)
    {
        



    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string clientid = "122415916779-7bhspojqe33c5t6sjr1m894ju3e3joks.apps.googleusercontent.com";
        string clientsecret = "a_oOseuX0mNsaye_MLguzjLj";
        string redirection_url = "http://www.tichedu.com/teacher.aspx";
        string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + clientid + "";
        Response.Redirect(url);
    }



    protected void Submit_teacher_login_Click(object sender, EventArgs e)
    {
        try
        {
            String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

            SqlConnection con = new SqlConnection(strConnString);

            string uid = Request.Form["login_email"];
            string pass = Request.Form["login_password"];
            con.Open();
            string qry = "select * from TBL_TEACHER_REGISTRATION where TEACHER_EMAIL='" + uid + "' and TEACHER_PASSWORD='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                userid = sdr["TEACHER_ID"].ToString();

                Response.Redirect("teacher.aspx?teacher=" + userid);
                Session["userid"] = userid;
                
            }
            else
            {
                // Response.Redirect("login-teacher.aspx");
                
                Error_label.Text = "Invalid Login Check Email and Password Entered";
            }
            con.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
       

    }

    protected void lostpassword_linkbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgotpasswordteacher.aspx");
    }
}