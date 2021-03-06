﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PDFVIEWER_student : System.Web.UI.Page
{
    public string userkey { set; get; }

    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["student"];
        //BindDataList();
        string pdfid = Request.QueryString["PDFVIEW"];
        string embed = "<object data=\"{0}{1}\" type=\"application/pdf\" width=\"900px\" height=\"600px\">";
        embed += "If you are unable to view file, you can download from <a href = \"{0}{1}&download=1\">here</a>";
        embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
        embed += "</object>";
        ltEmbed.Text = string.Format(embed, ResolveUrl("~/FileCSpdf.ashx?Id="), pdfid);


    }

    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
      //  Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
    }
    private void BindDataList()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT PDF_ID, PDF_TITLE,PDF_CLASS,PDF_SUBJECT FROM TBL_PDF_UPLOADS WHERE PDF_TEACHER_ID=@Id";
                double I = Convert.ToDouble(userkey);
                    cmd.Parameters.AddWithValue("@Id", I);
                cmd.Connection = con;
                con.Open();
              //  DataList1.DataSource = cmd.ExecuteReader();
              //  DataList1.DataBind();
                con.Close();
            }
        }
    }

    protected void Profile_link_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("student-profile.aspx/?student=" + userkey);
    }

    protected void lnkDownload_Click(object sender, EventArgs e)
    {




        int id = int.Parse((sender as LinkButton).CommandArgument);
        string embed = "<object data=\"{0}{1}\" type=\"application/pdf\" width=\"100%\" height=\"100%\">";
        embed += "If you are unable to view file, you can download from <a href = \"{0}{1}&download=1\">here</a>";
        embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
        embed += "</object>";
       ltEmbed.Text = string.Format(embed, ResolveUrl("~/FileCSpdf.ashx?Id="), id);
      

       
    }

    protected void mycontent_Click(object sender, EventArgs e)
    {
       // Response.Redirect("teacher.aspx/?teacher=" + userkey);
    }

    protected void Videoslink_Click(object sender, EventArgs e)
    {
        Response.Redirect("student.aspx/?student=" + userkey);
    }

    protected void pdfnoteslink_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesViewStudent.aspx/?student=" + userkey);
    }

    protected void Youtubevideo_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeViewStudent.aspx/?student=" + userkey);
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
}
