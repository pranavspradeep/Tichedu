using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Youtubevideosupload : System.Web.UI.Page
{
   public string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    public string userkey { set; get; }
    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["teacher"];
        BindDataList();
        
        
    }

    private void BindDataList()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT YOU_ID,YOUTUBE_TITLE,YOUTUBE_SUBJECT,YOUTUBE_CLASS,YOUTUBE_TEACHER_ID,YOUTUBE_LINK,YSTART,YEND FROM TBL_YOUTUBE_VIDEOS WHERE YOUTUBE_TEACHER_ID=@Id ";
    
                double I = Convert.ToDouble(userkey);
                cmd.Parameters.AddWithValue("@Id", I);
                cmd.Connection = con;
                con.Open();
                DataListvideo.DataSource = cmd.ExecuteReader();
                DataListvideo.DataBind();
                con.Close();
            }
        }
    }




    protected void Content_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher.aspx?teacher="+ userkey);
    }

  
    

   
   

    protected void Pdfnoteslink_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesView.aspx/?teacher=" + userkey);
    }

    protected void Youtube_linkbtn_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey.ToString();
        Response.Redirect("YoutubeSearch.aspx");
    }

    protected void Profile_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher-profile.aspx/?teacher=" + userkey);
    }

    protected void Addvideobtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Youtubevideosupload.aspx/?teacher=" + userkey);
    }

    protected void youtubevideos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Youtubevideosupload-listing.aspx/?teacher=" + userkey);
    }

    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
    }
}