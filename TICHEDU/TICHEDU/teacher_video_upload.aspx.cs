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

public partial class teacher_video_upload : System.Web.UI.Page
{
   public string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    public string userkey { set; get; }
    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["teacher"];
        if (!IsPostBack)
        { 
       
        filldropdownclass();
        fillsubjeect();
        }
    }

    protected void Upload(object sender, EventArgs e)
    { if (Video_title.Text == "" || classdrop.SelectedItem.Text == ""||subdrop.Text==""||Video_upload.FileName=="")
        { message.Text = "Error:Please recheck all fields before submit "; }
        else {
            using (BinaryReader br = new BinaryReader(Video_upload.PostedFile.InputStream))
            {
                byte[] bytes = br.ReadBytes((int)Video_upload.PostedFile.InputStream.Length);

                using (SqlConnection con = new SqlConnection(strConnString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "INSERT INTO TBL_VIDEO_UPLOAD(USER_ID,VIDEO_UPLOAD_TYPE,VIDE0_TITLE,VIDEO_FOR_CLASS,VIDEO_FILE,VIDEO_SUBJECT) VALUES (@USER_ID, @VIDEO_UPLOAD_TYPE, @VIDEO_TITLE,@VIDEO_FOR_CLASS,@VIDEO_FILE,@VIDEO_SUBJECT)";
                        cmd.Parameters.AddWithValue("@VIDEO_FILE", bytes);
                        cmd.Parameters.AddWithValue("@VIDEO_UPLOAD_TYPE", "TEACHER");
                        cmd.Parameters.AddWithValue("@VIDEO_TITLE", Video_title.Text);
                        cmd.Parameters.AddWithValue("@VIDEO_FOR_CLASS", classdrop.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@USER_ID", userkey);
                        cmd.Parameters.AddWithValue("@VIDEO_SUBJECT", subdrop.SelectedItem.Text);
                        cmd.Connection = con;
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            message.Text = "Video uploaded sucessfully";
                        }
                        else
                        {
                            message.Text = " Video Upload failed";
                        }

                        con.Close();


                    }
                }
            }
        }
        //Response.Redirect(Request.Url.AbsoluteUri);
       
    }

    protected void Content_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher.aspx?teacher="+ userkey);
    }

    protected void Pdf_upload_btn_Click(object sender, EventArgs e)
    {  if (pdf_title_txtbox.Text == "" || classdroppdf.SelectedItem.Text == "" || pdf_file_upload.FileName == "")
        {
            messagepdf.Text = "Error:Please recheck all fields before submit ";
        }
        else
        {


            byte[] pdf_file_data = pdf_file_upload.FileBytes;
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO TBL_PDF_UPLOADS (PDF_TITLE,PDF_CLASS,PDF_TEACHER_ID,PDF_FILE,PDF_SUBJECT) VALUES (@PDFTITLE,@PDFCLASS,@PDFTEACHERID,@PDFFILE,@PDF_SUBJECT)";
                    cmd.Parameters.Add("@PDFTITLE", SqlDbType.NVarChar).Value = pdf_title_txtbox.Text;
                    cmd.Parameters.Add("@PDFCLASS", SqlDbType.NVarChar).Value = classdroppdf.SelectedItem.Text;
                    cmd.Parameters.Add("@PDFTEACHERID", SqlDbType.NVarChar).Value = userkey.ToString();
                    cmd.Parameters.Add("@PDFFILE", SqlDbType.VarBinary).Value = pdf_file_data;
                    cmd.Parameters.Add("@PDF_SUBJECT", SqlDbType.NVarChar).Value = Subjdroppdf.SelectedItem.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        messagepdf.Text = "Pdf uploaded sucessfully";
                    }
                    else
                    {
                        messagepdf.Text = "Pdf upload failed";
                    }
                }
            }
        }

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
         classdroppdf.DataTextField= ds.Tables[0].Columns["Class"].ToString();                                                                  //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        classdrop.DataSource = ds.Tables[0];
        classdroppdf.DataSource = ds.Tables[0];
        //assigning datasource to the dropdownlist
        classdrop.DataBind();  //binding dropdownlist
        classdroppdf.DataBind();
        con.Close();
        classdrop.Items.Insert(0, new ListItem("Select", "NA"));
        classdroppdf.Items.Insert(0, new ListItem("Select", "NA"));

    }
    public void fillsubjeect()
    {


        SqlConnection con = new SqlConnection(strConnString);
        con.Open();

        SqlCommand com = new SqlCommand("SELECT Subject FROM Tbl_subject", con); // table name 
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataSet ds = new DataSet();
        da.Fill(ds);  // fill dataset
        subdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
        Subjdroppdf.DataTextField = ds.Tables[0].Columns["Subject"].ToString();                                                                  //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        subdrop.DataSource = ds.Tables[0];
        Subjdroppdf.DataSource = ds.Tables[0];  //assigning datasource to the dropdownlist
        subdrop.DataBind();  //binding dropdownlist
        Subjdroppdf.DataBind();
        con.Close();
        subdrop.Items.Insert(0, new ListItem("Select", "NA"));
        Subjdroppdf.Items.Insert(0, new ListItem("Select", "NA"));

    }

    protected void Pdfnoteslink_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesView.aspx/?teacher=" + userkey);
    }

    protected void Youtube_linkbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeSearch.aspx");
    }

    protected void Profile_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher-profile.aspx/?teacher=" + userkey);
    }

    protected void Youtube_videos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Youtubevideosupload-listing.aspx/?teacher=" + userkey);
    }

    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
    }
    protected void Groupchat_Click(object sender, EventArgs e)
    {
        Response.Redirect("Teachergroupchat.aspx/?teacher=" + userkey);

    }

    protected void whiteboard_Click(object sender, EventArgs e)
    {

        Response.Redirect("teacher-whiteboard.aspx/?teacher=" + userkey);
    }
}
