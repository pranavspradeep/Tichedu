using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using YoutubeSearch;

public partial class YoutubeSearchqa : System.Web.UI.Page
{    string userkey { set; get; }
   
    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Session["userkey"].ToString();

        if (!IsPostBack)
        {
            userkey = Session["userkey"].ToString();
           // userkey = Request.QueryString["teacher"];
            // GoogleProfileimage.Visible = false;
            //id_label.Visible = false;
        }
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

   

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string search = searchtextbox.Text.ToString();

        // Number of result pages
        int querypages = 1;

        ////////////////////////////////
        // Starting searchquery
        ////////////////////////////////

        var items = new VideoSearch();

        int i = 1;
        var videoId = string.Empty;
        foreach (var item in items.SearchQuery(search, querypages))
        {

            //Console.WriteLine(i + "###########################");
            //Console.WriteLine("Title: " + item.Title);
            //Console.WriteLine("Author: " + item.Author);
            //Console.WriteLine("Description: " + item.Description);
            //Console.WriteLine("Duration: " + item.Duration);
            //Console.WriteLine("Url: " + item.Url);
            //Console.WriteLine("Thumbnail: " + item.Thumbnail);
            //Console.WriteLine("");

            var url = item.Url;
            var uri = new Uri(url);

            // you can check host here => uri.Host <= "www.youtube.com"

            var query = HttpUtility.ParseQueryString(uri.Query);

            // var videoId = string.Empty;

            if (query.AllKeys.Contains("v"))
            {
                videoId = query["v"];

            }
            else
            {
                videoId = uri.Segments.Last();

            }
            HtmlGenericControl div = new HtmlGenericControl("div");
            div.Attributes.Add("id", i.ToString());
            testinner.Controls.Add(div);
            div.InnerHtml = "<div class='col - sm - 4'><iframe width='560' height='315' src='https://www.youtube.com/embed/" + videoId + "' frameborder='0' allow='autoplay; encrypted-media' allowfullscreen></iframe><a href = Youtubevideosupload.aspx?youtubeid=" + videoId + "&teacher=" + userkey + "&duration="+item.Duration +"> Share with your students</a> </div>";


            i++;

        }
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
}