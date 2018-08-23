using ASPSnippets.GoogleAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class parentdash : System.Web.UI.Page
{
    string clientid = "556887803694-s1iakv1ep16bgvupkp3suh2jc549922j.apps.googleusercontent.com";
    string clientsecret = "hE1s29hJqp2u-p4yLefbZWHb";
    string redirection_url = "http://www.tichedu.com/teacher.aspx";
    string url = "https://accounts.google.com/o/oauth2/token";
    public class Tokenclass
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
    }
    public class Userclass
    {
        public string id { get; set; }
        public string name { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string link { get; set; }
        public string picture { get; set; }
        public string gender { get; set; }
        public string locale { get; set; }
    }





    public string userkey { set; get; }

    public string code { set; get; }
    protected void Page_Load(object sender, EventArgs e)
    {
        id_label.Visible = false;
        GoogleProfileimage.Visible = false;
        lblName.Visible = false;

        userkey = Request.QueryString["teacher"];



        if (!IsPostBack)
        {
            if (Request.QueryString["code"] != null)
            {
                GetToken(Request.QueryString["code"].ToString());
                GoogleProfileimage.Visible = true;
                lblName.Visible = true;
            }
        }
        if(userkey==null)
        {
            userkey = Session["userid"].ToString();
            if (GoogleProfileimage.ImageUrl == "" || lblName.Text == "")
            {

                GoogleProfileimage.ImageUrl = Session["image-url"].ToString();
                lblName.Text = Session["username"].ToString();
                GoogleProfileimage.Visible = true;
                lblName.Visible = true;
            }
        }

        
      

          
            
        

        BindDataList(userkey);
    }
    public void GetToken(string code)
    {

        string poststring = "grant_type=authorization_code&code=" + code + "&client_id=" + clientid + "&client_secret=" + clientsecret + "&redirect_uri=" + redirection_url + "";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.ContentType = "application/x-www-form-urlencoded";
        request.Method = "POST";
        UTF8Encoding utfenc = new UTF8Encoding();
        byte[] bytes = utfenc.GetBytes(poststring);
        Stream outputstream = null;
        try
        {
            request.ContentLength = bytes.Length;
            outputstream = request.GetRequestStream();
            outputstream.Write(bytes, 0, bytes.Length);
        }
        catch
        { }
        var response = (HttpWebResponse)request.GetResponse();
        var streamReader = new StreamReader(response.GetResponseStream());
        string responseFromServer = streamReader.ReadToEnd();
        JavaScriptSerializer js = new JavaScriptSerializer();
        Tokenclass obj = js.Deserialize<Tokenclass>(responseFromServer);
        GetuserProfile(obj.access_token);
    }
    public void GetuserProfile(string accesstoken)
    {
        string url = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token=" + accesstoken + "";
        WebRequest request = WebRequest.Create(url);
        request.Credentials = CredentialCache.DefaultCredentials;
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        response.Close();
        JavaScriptSerializer js = new JavaScriptSerializer();
        Userclass userinfo = js.Deserialize<Userclass>(responseFromServer);
        GoogleProfileimage.ImageUrl = userinfo.picture;
        Session["image-url"] = userinfo.picture;
        id_label.Text = userinfo.id;
        /// lblgender.Text = userinfo.gender;
        // lbllocale.Text = userinfo.locale;
         lblName.Text = userinfo.name;
        Session["username"]= userinfo.name;
        Session["userid"] = userinfo.id;
        // hylprofile.NavigateUrl = userinfo.link;

    }




    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
        
            
            Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
        
        
    }
    private void BindDataList( string i)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                
                cmd.CommandText = "SELECT VIDEO_ID, VIDE0_TITLE,VIDEO_FOR_CLASS,VIDEO_SUBJECT FROM TBL_VIDEO_UPLOAD WHERE VIDEO_UPLOAD_TYPE ='TEACHER' AND USER_ID=@Id";
               
               
                    cmd.Parameters.AddWithValue("@Id", i);
                cmd.Connection = con;
                con.Open();
              //  DataListvideo.DataSource = cmd.ExecuteReader();
               // DataListvideo.DataBind();
                con.Close();
            }
        }
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
        Session["userkey"] = userkey.ToString();
        Response.Redirect("YoutubeSearch.aspx?teacher="+userkey);
    }

    protected void AddVideo_Click(object sender, EventArgs e)
    {  
            Response.Redirect("TeacherVideoUpload.aspx/?teacher=" + userkey);
        
        
    }

    protected void youtube_videos_link_Click(object sender, EventArgs e)
    {   
            Response.Redirect("Youtubevideosupload-listing.aspx/?teacher=" + userkey);
        
    }
}