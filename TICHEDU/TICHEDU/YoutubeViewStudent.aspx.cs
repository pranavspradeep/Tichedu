using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class YoutubeViewStudent : System.Web.UI.Page
{
    string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    public string userkey { set; get; }

    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["student"];
        //BindDataList();
        if (!IsPostBack)
        {
            
            filldropdownclass();
            fillsubjeect();
        }
    }

    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
        //   Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
    }
    private void BindDataList()
    {

        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT PDF_ID, PDF_TITLE,PDF_CLASS,PDF_SUBJECT FROM TBL_PDF_UPLOADS WHERE PDF_TEACHER_ID=@Id";
                double I = Convert.ToDouble(userkey);
                cmd.Parameters.AddWithValue("@Id", I);
                cmd.Connection = con;
                con.Open();
               // DataList1.DataSource = cmd.ExecuteReader();
               // DataList1.DataBind();
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
        Response.Redirect("PDFVIEWER_student.aspx/?PDFVIEW=" + id + "&student=" + userkey + "");
        // string embed = "<object data=\"{0}{1}\" type=\"application/pdf\" width=\"900px\" height=\"600px\">";
        // embed += "If you are unable to view file, you can download from <a href = \"{0}{1}&download=1\">here</a>";
        //embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
        //  embed += "</object>";
        //  ltEmbed.Text = string.Format(embed, ResolveUrl("~/FileCSpdf.ashx?Id="), id);



    }

    protected void mycontent_Click(object sender, EventArgs e)
    {
        // Response.Redirect("teacher.aspx/?teacher=" + userkey);
    }

    protected void Videoslink_Click(object sender, EventArgs e)
    {
        Response.Redirect("student.aspx/?student=" + userkey);
    }
    public void filldropdownclass()
    {


        SqlConnection con = new SqlConnection(strConnString);
        con.Open();

        SqlCommand com = new SqlCommand("SELECT Class FROM Tbl_class", con); // table name 
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);  // fill dataset
        classdrop.DataTextField = ds.Tables[0].Columns["Class"].ToString(); // text field name of table dispalyed in dropdown
                                                                            //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        classdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
        classdrop.DataBind();  //binding dropdownlist

        con.Close();
        classdrop.Items.Insert(0, new ListItem("Select", "NA"));


    }

    public void fillsubjeect()
    {


        SqlConnection con = new SqlConnection(strConnString);
        con.Open();

        SqlCommand com = new SqlCommand("SELECT Subject FROM Tbl_subject", con); // table name 
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);  // fill dataset
        subjdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
                                                                             //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        subjdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
        subjdrop.DataBind();  //binding dropdownlist

        con.Close();
        subjdrop.Items.Insert(0, new ListItem("Select", "NA"));


    }

    protected void search_btn_Click(object sender, EventArgs e)
    {
        if (classdrop.SelectedItem.Text == "Select" || subjdrop.SelectedItem.Text == "Select")
        { errorlabel.Text = "Error:Please check search terms"; }
        else
        {
            errorlabel.Visible = false;
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT YOU_ID,YOUTUBE_TITLE,YOUTUBE_SUBJECT,YOUTUBE_CLASS,YOUTUBE_TEACHER_ID,YOUTUBE_LINK,YSTART,YEND FROM TBL_YOUTUBE_VIDEOS WHERE YOUTUBE_SUBJECT=@Yousubject and YOUTUBE_CLASS=@Youclass ";
                    //double I = Convert.ToDouble(userkey);
                    // cmd.Parameters.AddWithValue("@Id", I);
                    cmd.Parameters.AddWithValue("@Youclass", classdrop.SelectedItem.Text);
                    cmd.Parameters.AddWithValue("@Yousubject", subjdrop.SelectedItem.Text);
                    cmd.Connection = con;
                    con.Open();
                    YoutubeDataList.DataSource = cmd.ExecuteReader();
                    YoutubeDataList.DataBind();
                    con.Close();
                    DateTime time = DateTime.Now;

                    StudentTrack studentTrack = new StudentTrack();
                    studentTrack.StudentTracker(userkey, subjdrop.Text, classdrop.Text, time,"Youtube video watching","Active");
                }
            }
        }
    }

    protected void Youtubevideos_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeViewStudent.aspx/?student=" + userkey);
    }

    protected void PdfNotes_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesViewStudent.aspx/?student=" + userkey);
    }

    protected void Youtubelive_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeLiveStudent.aspx/?student=" + userkey);
    }

    protected void Groupchat_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudentGroupChat.aspx/?student=" + userkey);
    }
}
