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

public partial class student : System.Web.UI.Page
{
    public string userkey { set; get; }
    string clientid = "249797267239-eagt226h77mtc3csfcgej0hn6fqcus42.apps.googleusercontent.com";
    string clientsecret = "7igXmjOqdERcmTj6m40Z4LGW";
    string redirection_url = "http://www.TichEdu.in/Edu/student";
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


    string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["student"];
        profilepic.Visible = false;
        username.Visible = false;
        if (!Page.IsPostBack)
        {
            filldropdownclass();
            fillsubjeect();
            if (!IsPostBack)
            {
                if (Request.QueryString["code"] != null)
                {
                    GetToken(Request.QueryString["code"].ToString());
                    profilepic.Visible = true;
                    username.Visible = true;

                    profilepic.ImageUrl = Session["profilepicture"].ToString();
                    username.Text = Session["username"].ToString();
                }
            }
        }
        if (userkey == null)
        {
            userkey = Session["userid"].ToString();
        }

        //  BindDataList();
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
        Session["profilepicture"] = userinfo.picture;
        Session["image-url"] = userinfo.picture;
        Session["userid"] = userinfo.id;
        /// lblgender.Text = userinfo.gender;
        // lbllocale.Text = userinfo.locale;
        Session["username"] = userinfo.name;

        Session["userid"] = userinfo.id;
        // hylprofile.NavigateUrl = userinfo.link;

    }
    private void videosearch()
    {
        // string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT VIDEO_ID, VIDE0_TITLE,VIDEO_SUBJECT FROM TBL_VIDEO_UPLOAD WHERE VIDEO_UPLOAD_TYPE ='TEACHER' and VIDEO_FOR_CLASS=@class and VIDEO_SUBJECT=@subject ";
               // double I = Convert.ToDouble(userkey);
                // cmd.Parameters.AddWithValue("@Id", I);
                cmd.Parameters.AddWithValue("@class", classdrop.Text);
                cmd.Parameters.AddWithValue("@subject", subjectdrop.Text);
                cmd.Connection = con;
                con.Open();
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                con.Close();
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
        subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
                                                                                //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
        subjectdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
        subjectdrop.DataBind();  //binding dropdownlist

        con.Close();
        subjectdrop.Items.Insert(0, new ListItem("Select", "NA"));


    }



    protected void Profile_link_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("student-profile.aspx?student=" + userkey);
    }

    protected void Btnserachfilter_Click(object sender, EventArgs e)
    {
        if (classdrop.SelectedItem.Text == "Select" || subjectdrop.SelectedItem.Text == "Select")
        {
            error.Text = "Error:Please check search terms";
        }
        else
        {
            error.Visible = false;
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT VIDEO_ID, VIDE0_TITLE,VIDEO_FOR_CLASS,VIDEO_SUBJECT FROM TBL_VIDEO_UPLOAD WHERE VIDEO_UPLOAD_TYPE ='TEACHER' and VIDEO_FOR_CLASS=@class and VIDEO_SUBJECT=@subject ";
                    // double I = Convert.ToDouble(userkey);
                    // cmd.Parameters.AddWithValue("@Id", I);
                    cmd.Parameters.AddWithValue("@class", classdrop.Text);
                    cmd.Parameters.AddWithValue("@subject", subjectdrop.Text);
                    cmd.Connection = con;
                    con.Open();
                    DataList1.DataSource = cmd.ExecuteReader();
                    DataList1.DataBind();
                    con.Close();
                    DateTime time = DateTime.Now;

                    StudentTrack studentTrack = new StudentTrack();
                      studentTrack.StudentTracker(userkey,subjectdrop.Text,classdrop.Text, time,"Video Watching","Active");
                }
            }
        }
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


    //public void StudentTracker(string stdid,string visitedsubject,string cls,DateTime datetime)//cls=class
    //    {
    //    SqlConnection sqlConnection = new SqlConnection(strConnString);
    //    sqlConnection.Open();
    //    string query = "insert into StudentActTrack (Std_Id,Std_visited_class,Std_visited_subject,Date_time)values(@stdid,@visitedclass,@visitedsubject,@datetime)";
    //    SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);

    //  //  sqlCommand.Parameters.AddWithValue("@stdusername", stdusername);
    //    sqlCommand.Parameters.AddWithValue("@stdid", stdid);
    //    sqlCommand.Parameters.AddWithValue("@visitedsubject", visitedsubject);
    //    sqlCommand.Parameters.AddWithValue("@visitedclass", cls);
    //    sqlCommand.Parameters.AddWithValue("@datetime", datetime);
    //    sqlCommand.ExecuteNonQuery();

    //    sqlConnection.Close();
    //}

    

    protected void Groupchat_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("StudentGroupChat.aspx?student=" + userkey);
    }

    protected void examlink_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("SelectExam.aspx?student=" + userkey);
    }
}
