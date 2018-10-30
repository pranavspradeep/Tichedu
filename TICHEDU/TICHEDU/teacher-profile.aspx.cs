using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class student_profile : System.Web.UI.Page
{ public string userkey { get; set; }
    string Teacher_name_Firstname { get; set; }
    string Teacher_last_name { get; set; }
    string Teacher_course { get; set; }
    DateTime Teacher_dob { get; set; }
    string Teacher_subject { get; set; }
    string Teacher_Address { get; set; }
    byte[] imgByte  { get; set;}
    string country { get; set; }
    string city { get; set; }
    string street { get; set; }
    string zip { get; set; }




    protected void Page_Load(object sender, EventArgs e)
    {
        userkey = Request.QueryString["teacher"];
        
        
         if(userkey=="")
        {
            userkey = Session["userkey"].ToString(); 
        }
        if (userkey == "")
        {
            userkey = Session["userid"].ToString();
        }
        Fetch_profile_teacher();
        if (Teacher_name_firstname.Text == "")
        {
            image_v.Src = Session["image-url"].ToString();
            Teacher_name_firstname.Text = Session["username"].ToString();
        }
    }

    public void Fetch_profile_teacher()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        SqlDataReader rdr = null;

        //Create connection
        SqlConnection conn = new SqlConnection(strConnString);

        //Create command
        SqlCommand cmd = new SqlCommand("select * from TBL_TEACHER_REGISTRATION where TEACHER_ID=" + userkey, conn);

        try
        {
            //Open the connection
            conn.Open();

            // 1. get an instance of the SqlDataReader
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                // get the results of each column
                Teacher_name_Firstname = (string)rdr["TEACHER_FIRST_NAME"];
                 Teacher_last_name = (string)rdr["TEACHER_LASTNAME"];
                 Teacher_course = (string)rdr["TEACHER_SUBJECT"];
                Teacher_dob = (DateTime)rdr["TEACHER_DOB"];
                Teacher_subject = (string)rdr["TEACHER_SUBJECT"];
                Teacher_Address = (string)rdr["TEACHER_ADDRESS"];

                
                imgByte = (byte[])(rdr["TEACHER_PHOTO"]);
                string str = Convert.ToBase64String(imgByte);
                image_v.Src= "data:Image/png;base64," + str;

                Country.Text = (string)rdr["TEACHER_COUNTRY"];
                City.Text = (string)rdr["TEACHER_CITY"];
                Street.Text = (string)rdr["TEACHER_STREET"];
                Zip.Text = (string)rdr["TEACHER_ZIP"];

            }
        }
        catch(Exception ex)
        {
            throw ex;
        }

        Teacher_name_firstname.Text = Teacher_name_Firstname;
        Teacher_name_lastname.Text = Teacher_last_name;
        Teacher_Subject.Text = Teacher_course;
        Name_2.Text= Teacher_name_Firstname;
        subjects_label.Text = Teacher_subject;
        Address.Text = Teacher_Address;
        Dateofbirth_label.Text = Convert.ToString(Teacher_dob);
        last_name2.Text = Teacher_last_name;
       


    }

    protected void Profile_link_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher-profile.aspx/?teacher=" + userkey);
    }

    protected void Upload_link_button_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher_video_upload.aspx/?teacher=" + userkey);
    }

    protected void Mycontent_Click(object sender, EventArgs e)
    {
        Response.Redirect("teacher.aspx?teacher=" + userkey);
    }
}