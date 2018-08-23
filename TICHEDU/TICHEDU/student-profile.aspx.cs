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
        userkey = Request.QueryString["student"];
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
        SqlCommand cmd = new SqlCommand("select * from TBL_STUDENT_REGISTRATION where STUDENT_ID = " + userkey, conn);

        try
        {
            //Open the connection
            conn.Open();

            // 1. get an instance of the SqlDataReader
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                // get the results of each column
                Teacher_name_Firstname = (string)rdr["STUDENT_FIRST_NAME"];
                 Teacher_last_name = (string)rdr["STUDENT_LASTNAME"];
                 Teacher_course = (string)rdr["STUDENT_STUDYING_IN"];
                Teacher_dob = (DateTime)rdr["STUDENT_DOB"];
                Teacher_subject = (string)rdr["STUDENT_SPECIALIZATION"];
                Teacher_Address = (string)rdr["STUDENT_ADDRESS"];

                
                imgByte = (byte[])(rdr["STUDENT_PHOTO"]);
                string str = Convert.ToBase64String(imgByte);
                image_v.Src= "data:Image/png;base64," + str;
                Country.Text = (string)rdr["STUDENT_COUNTRY"];
                City.Text = (string)rdr["STUDENT_CITY"];
                Street.Text = (string)rdr["STUDENT_STREET"];
                Zip.Text = (string)rdr["STUDENT_ZIP"];

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

    protected void video_limk_Click(object sender, EventArgs e)
    {
        Response.Redirect("student.aspx?student=" + userkey);
    }
}