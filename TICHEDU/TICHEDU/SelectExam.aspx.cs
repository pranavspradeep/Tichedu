using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class SelectExam : System.Web.UI.Page
{
    string userkey;
    string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["student"];
        if (!Page.IsPostBack)
        {
            
            disp_class();
        }
        if (userkey == null)
        {
            userkey = Session["userid"].ToString();
        }
    }
    public void disp_class()
    {
        SqlConnection con = new SqlConnection(strConnString);
        SqlDataAdapter da = new SqlDataAdapter("Select Class from Tbl_Class ", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DrpClass.Items.Clear();
        DrpClass.Items.Add("Select");
        DataRow dr;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = ds.Tables[0].Rows[i];
            DrpClass.Items.Add(dr["Class"].ToString());
        }
    }
    protected void Profile_link_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("student-profile.aspx?student=" + userkey);
    }
    protected void Pdfnoteslink_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesViewStudent.aspx/?student=" + userkey);
    }

    protected void video_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("student.aspx?student=" + userkey);
    }

    protected void Youtubevideos_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeViewStudent.aspx?student=" + userkey);
    }

    protected void Youtubelive_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("YoutubeLiveStudent.aspx?student=" + userkey);
    }

    protected void Groupchat_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("StudentGroupChat.aspx?student=" + userkey);
    }
    public void disp_sub()
    {
        SqlConnection con = new SqlConnection(strConnString);
        SqlDataAdapter da = new SqlDataAdapter("Select Subject from Tbl_class_subject where class='" + DrpClass.Text + "'", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DrpSubject.Items.Clear();
        DrpSubject.Items.Add("Select");
        DataRow dr;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = ds.Tables[0].Rows[i];
            DrpSubject.Items.Add(dr["Subject"].ToString());
        }
    }
    public void disp_exam()
    {
        SqlConnection con = new SqlConnection(strConnString);
        SqlDataAdapter da = new SqlDataAdapter("Select Exam_name from Tbl_Examname ", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        DrpExam.Items.Clear();
        DrpExam.Items.Add("Select");
        DataRow dr;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = ds.Tables[0].Rows[i];
            DrpExam.Items.Add(dr["Exam_name"].ToString());
        }
    }
    protected void DrpClass_SelectedIndexChanged(object sender, EventArgs e)
    {
        disp_sub();
    }
   
    protected void DrpSubject_SelectedIndexChanged(object sender, EventArgs e)
    {
        disp_exam();
    }

    protected void submitbtn_Click(object sender, EventArgs e)
    {
        Session["exam"] = DrpExam.Text;
        Session["class"] = DrpClass.Text;
        Session["subject"] = DrpSubject.Text;
        Response.Redirect("Exam.aspx?student=" + userkey);
    }

    protected void examlink_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("SelectExam.aspx?student=" + userkey);
    }
}