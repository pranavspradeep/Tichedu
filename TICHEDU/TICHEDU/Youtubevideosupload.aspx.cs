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
    public string videoid { set; get; }
    public string duration { set; get; }
    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["teacher"];
        videoid= Request.QueryString["youtubeid"];
        duration = Request.QueryString["duration"];
        decimal dec;
        if (!IsPostBack)
        {
           
            iframe.Src = "http://www.youtube.com/embed/"+videoid;
            if (duration == null)
            {
                iframe.Visible = false;
                start.Visible = false;
                end.Visible = false;
                Trimbutton.Visible = false;
                TextBox3.Visible = false;
                startlabel.Visible = false;
                endlabel.Visible = false;
            }

            else
            {

                dec = Convert.ToDecimal(TimeSpan.Parse(duration).TotalHours);
                Decimal dec1 = dec * 60;
                end.Text = dec1.ToString();

                MultiHandleSliderExtender1.Maximum = Convert.ToInt32(dec1);
            }

            
           
            YoutubeLink.Text = videoid;
        filldropdownclass();
        fillsubjeect();
        }
        if(userkey==null)
        {
            userkey = Session["userid"].ToString();
        }
    }

    protected void Upload(object sender, EventArgs e)
    { if (Video_title.Text == "" || classdrop.SelectedItem.Text == ""||subdrop.Text==""|| YoutubeLink.Text=="")
        { message.Text = "Error:Please recheck all fields before submit "; }
        else {
           
                using (SqlConnection con = new SqlConnection(strConnString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "insert into TBL_YOUTUBE_VIDEOS(YOUTUBE_TITLE,YOUTUBE_CLASS,YOUTUBE_SUBJECT,YOUTUBE_TEACHER_ID,YOUTUBE_LINK,YSTART,YEND)values(@YOUTUBE_TITLE,@YOUTUBE_CLASS,@YOUTUBE_SUBJECT,@YOUTUBE_TEACHER_ID,@YOUTUBE_LINK,@YSTART,@YEND)";
                        cmd.Parameters.AddWithValue("@YOUTUBE_TITLE",Video_title.Text );
                        cmd.Parameters.AddWithValue("@YOUTUBE_CLASS", classdrop.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@YOUTUBE_SUBJECT", subdrop.SelectedItem.Text);
                        cmd.Parameters.AddWithValue("@YOUTUBE_TEACHER_ID", userkey);
                        cmd.Parameters.AddWithValue("@YOUTUBE_LINK",YoutubeLink.Text );
                        cmd.Parameters.AddWithValue("@YSTART", start.Text);
                        cmd.Parameters.AddWithValue("@YEND ", end.Text);
                       
                        cmd.Connection = con;
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            message.Text = "Youtube Video uploaded sucessfully";
                        }
                        else
                        {
                            message.Text = "Youtube  Video Upload failed";
                        }

                        con.Close();


                    }
                }
            }
        }
        //Response.Redirect(Request.Url.AbsoluteUri);
       
    

    protected void Content_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher.aspx?teacher="+ userkey);
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
        classdrop.DataSource = ds.Tables[0];
       
        //assigning datasource to the dropdownlist
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
        subdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
                                                                  //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        subdrop.DataSource = ds.Tables[0];
       
        subdrop.DataBind();  //binding dropdownlist
        
        con.Close();
        subdrop.Items.Insert(0, new ListItem("Select", "NA"));
       

    }

    protected void Pdfnoteslink_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesView.aspx/?teacher=" + userkey);
    }

    protected void Youtube_linkbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeSearch.aspx/?teacher="+userkey);
    }

    protected void Profile_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher-profile.aspx/?teacher=" + userkey);
    }

    protected void Yotubevideos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Youtubevideosupload-listing.aspx/?teacher=" + userkey);
    }

    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
    }

    protected void Trimbutton_Click(object sender, EventArgs e)
    {
        iframe.Src = "http://www.youtube.com/embed/"+videoid+"?start=" + start.Text + "&end=" + end.Text + "";


        
    }
}