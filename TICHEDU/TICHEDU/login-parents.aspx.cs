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
        Error_label.Visible = false;



    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string clientid = "556887803694-s1iakv1ep16bgvupkp3suh2jc549922j.apps.googleusercontent.com";
        string clientsecret = "hE1s29hJqp2u-p4yLefbZWHb";
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
            string qry = "select * from TBL_PARENT_REGISTRATION where PARENT_USERNAME='" + uid + "' and PARENT_PASSWORD='" + pass + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                String studentemail;
                userid = sdr["PARENT_ID"].ToString(); 
                studentemail = sdr["STUDENT_EMAIL"].ToString();
                Session["studentemail"] = studentemail;
                Response.Redirect("parentdash.aspx?teacher=" + userid);
                Session["userid"] = userid;
                


            }
            else
            {
                // Response.Redirect("login-teacher.aspx");
                Error_label.Visible = false;
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

    protected void lostpassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgotpasswordparents.aspx");
    }
}