using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using YoutubeSearch;

public partial class techres : System.Web.UI.Page
{    string userkey { set; get; }
    string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            disp_class();


            if (userkey == null)
            {
                if (Session["userkey"] == null)
                {

                }
                else
                {
                    userkey = Session["userkey"].ToString();
                }

            }

            if (userkey == null)
            {
                if (Session["userid"] == null)
                {

                }
                else
                {
                    userkey = Session["userid"].ToString();
                }

            }
            // userkey = Request.QueryString["teacher"];
            // GoogleProfileimage.Visible = false;
            //id_label.Visible = false;
        }
       }


    private void displayresult(string i)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "SELECT Exam_name,Subject,class,marks,outof,STUDENT_FIRST_NAME FROM Tbl_exam_res_parents t1 LEFT JOIN TBL_STUDENT_REGISTRATION t2 ON t2.STUDENT_ID = t1.student_id where t2.STUDENT_ID = t1.student_id and class=@Id";


                cmd.Parameters.AddWithValue("@Id", i);
                cmd.Connection = con;
                con.Open();
                StudentResult_Tbl.DataSource = cmd.ExecuteReader();
                StudentResult_Tbl.DataBind();
                con.Close();
            }
        }
    }




    public void disp_class()
    {
        SqlConnection con = new SqlConnection(strConnString);
        SqlDataAdapter da = new SqlDataAdapter("Select Class from Tbl_Class ", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        classdrp.Items.Clear();
        classdrp.Items.Add("Select");
        DataRow dr;
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            dr = ds.Tables[0].Rows[i];
            classdrp.Items.Add(dr["Class"].ToString());
        }
    }


    protected void studentactivity_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_Result.aspx/?teacher=" + userkey);
    }



    protected void Upload_link_button_Click(object sender, EventArgs e)
    {


        Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);


    }
    protected void Profile_link_button_Click(object sender, EventArgs e)
    {


        Response.Redirect("teacher-profile.aspx/?teacher=" + userkey);


    }

    protected void Pdfnoteslink_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesView.aspx/?teacher=" + userkey);


    }

    protected void Youtube_linkbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeSearch.aspx?teacher=" + userkey);
    }

    protected void AddVideo_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeacherVideoUpload.aspx/?teacher=" + userkey);


    }

    protected void youtube_videos_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("Youtubevideosupload-listing.aspx/?teacher=" + userkey);

    }

   


    protected void mycontent_Click(object sender, EventArgs e)
    {
                Response.Redirect("teacher.aspx?teacher=" + userkey);
    }

    protected void signout_Click(object sender, EventArgs e)
    {
        Response.Redirect("login-teacher.aspx");
    }
    protected void Groupchat_Click(object sender, EventArgs e)
    {
        Response.Redirect("Teachergroupchat.aspx/?teacher=" + userkey);

    }

    protected void whiteboard_Click(object sender, EventArgs e)
    {

        Response.Redirect("teacher-whiteboard.aspx/?teacher=" + userkey);
    }

    protected void submit_Click(object sender, EventArgs e)
    {
        displayresult(classdrp.Text);
    }
}