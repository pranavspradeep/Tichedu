using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  
    string cs = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    public string userkey { set; get; }
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            userkey = Request.QueryString["teacher"];
            filldropdownclass();
            FILLDROPDOWN_examnames();
            //subjectdropdown();

        }


    }

    protected void Sub_btn_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Question (Question,Option1,Option2,Option3,Option4,Question_Answer,Class,Exam_name ,Subject) VALUES(@Question,@Option1,@Option2,@Option3,@Option4,@Question_Answer,@Class,@Exam_name ,@Subject)", con);
            cmd.Parameters.AddWithValue("@Question", Question_txtbox.Text);
            cmd.Parameters.AddWithValue("@Option1", option1_txtbox.Text);
            cmd.Parameters.AddWithValue("@Option2", option2_txtbox.Text);
            cmd.Parameters.AddWithValue("@Option3", option3_txtbox.Text);
            cmd.Parameters.AddWithValue("@Option4", option4_txtbox.Text);
            cmd.Parameters.AddWithValue("@Question_Answer", Answer_txtbox.Text);
            cmd.Parameters.AddWithValue("@Class", Class_dropdown.Text);
            cmd.Parameters.AddWithValue("@Exam_name", Exam_drop.Text);
            cmd.Parameters.AddWithValue("@Subject", Subject_dropdown.Text);
            con.Open();



            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                //message.Text = "sucessfully added Questions";
            }
            con.Close();
        }
        catch (Exception q)
        {
            throw q;
        }
    }

    public void filldropdownclass()
    {


        SqlConnection con = new SqlConnection(cs);
        con.Open();

        SqlCommand com = new SqlCommand("SELECT Class FROM Tbl_class", con); // table name 
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);  // fill dataset
        Class_dropdown.DataTextField = ds.Tables[0].Columns["Class"].ToString(); // text field name of table dispalyed in dropdown
                                                                                 //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        Class_dropdown.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
        Class_dropdown.DataBind();  //binding dropdownlist

        con.Close();
        Class_dropdown.Items.Insert(0, new ListItem("Select", "NA"));


    }

    public void FILLDROPDOWN_examnames()
    {


        SqlConnection con = new SqlConnection(cs);
        con.Open();

        SqlCommand com = new SqlCommand("SELECT Exam_name FROM Tbl_Examname", con); // table name 
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);  // fill dataset
        Exam_drop.DataTextField = ds.Tables[0].Columns["Exam_name"].ToString(); // text field name of table dispalyed in dropdown
                                                                                //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        Exam_drop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
        Exam_drop.DataBind();  //binding dropdownlist

        con.Close();
        Exam_drop.Items.Insert(0, new ListItem("Select", "NA"));


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



    protected void youtube_videos_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("Youtubevideosupload-listing.aspx/?teacher=" + userkey);

    }

    public void  subjectdropdown()
    {
        SqlConnection con = new SqlConnection(cs);
        con.Open();

        SqlCommand com = new SqlCommand("SELECT subject FROM Tbl_class_subject ", con); // table name where class=@class
      //  com.Parameters.AddWithValue("@class", subclass);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);  // fill dataset
        Subject_dropdown.DataTextField = ds.Tables[0].Columns["subject"].ToString(); // text field name of table dispalyed in dropdown
                                                                                     //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        Subject_dropdown.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
        Subject_dropdown.DataBind();  //binding dropdownlist

        con.Close();
        Subject_dropdown.Items.Insert(0, new ListItem("Select", "NA"));
    }






    protected void Class_dropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}