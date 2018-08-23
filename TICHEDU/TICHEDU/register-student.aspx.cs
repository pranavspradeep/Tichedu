﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register_student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        sucess.Visible = false;
        errormsg.Visible = false;
    }

    protected void contact_form_submit_ServerClick(object sender, EventArgs e)
    {
        
        String strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        SqlConnection con = new SqlConnection(strConnString);

        SqlCommand cmd = new SqlCommand();

        cmd.CommandType = CommandType.StoredProcedure;

        cmd.CommandText = "STUDENT_REGISTRATION_INSERT";

        cmd.Parameters.Add("@TEACHER_FIRST_NAME", SqlDbType.VarChar, 50).Value = Request.Form["Firstname_txtbox"];
        cmd.Parameters.Add("@TEACHER_LAST_NAME", SqlDbType.VarChar, 50).Value = Request.Form["Lastname_txtbox"];
        string date = Request.Form["Dob_txtbox"];
        cmd.Parameters.Add("@TEACHER_DOB", SqlDbType.DateTime).Value = date;
        cmd.Parameters.Add("@TEACHER_SEX", SqlDbType.VarChar, 50).Value = Request.Form["Sex_txtbox"];
       // cmd.Parameters.Add("@TEACHER_QUALIFICATION", SqlDbType.VarChar, 50).Value = Request.Form["Qual_txtbox"];
        cmd.Parameters.Add("@STUDENT_STUDYINGIN", SqlDbType.VarChar, 50).Value = Request.Form["Studyingin_txtbox"];
        cmd.Parameters.Add("@TEACHER_SPECIALIZATION", SqlDbType.VarChar, 50).Value = Request.Form["Special_txtbox"];
        cmd.Parameters.Add("@TEACHER_EMAIL", SqlDbType.VarChar, 50).Value = Request.Form["Email_txtbox"];
        string a = Request.Form["Contact_txtbox"];
        long contact = Convert.ToInt64(a);
        cmd.Parameters.Add("@TEACHER_CONTACT", SqlDbType.BigInt).Value = contact;
        cmd.Parameters.Add("@TEACHER_ADDRESS", SqlDbType.VarChar, 50).Value = Request.Form["Address_txtbox"];
        cmd.Parameters.Add("@TEACHER_COUNTRY", SqlDbType.VarChar, 50).Value = Request.Form["Country_txtbox"];
        cmd.Parameters.Add("@TEACHER_CITY", SqlDbType.VarChar, 50).Value = Request.Form["City_txtbox"];
        cmd.Parameters.Add("@TEACHER_ZIP", SqlDbType.VarChar, 50).Value = Request.Form["Zip_txtbox"];
        cmd.Parameters.Add("@TEACHER_STREET", SqlDbType.VarChar, 50).Value = Request.Form["Street_txtbox"];

      //  cmd.Parameters.Add("@TEACHER_USERNAME", SqlDbType.VarChar, 50).Value = Request.Form["Username_txtbox"];
        cmd.Parameters.Add("@TEACHER_PASSWORD", SqlDbType.VarChar, 50).Value = Request.Form["Password_txtbox"];
        cmd.Parameters.Add("@TEACHER_WHERE_HERE_ABOUT", SqlDbType.VarChar, 50).Value = Request.Form["Whereyhere"];
        cmd.Parameters.Add("@TEACHER_PHOTO", SqlDbType.VarBinary).Value = file.FileBytes;
        cmd.Connection = con;
        try
        {
            con.Open();
           int i= cmd.ExecuteNonQuery();
            if (i != 0)
            {

                sucess.Visible = true;

                clear();

            }
            else
            {
                sucess.Visible = false;
                errormsg.Text = "Registrtaion Unsucessfull";

            }
            con.Close();
        }
        catch (Exception an)
        {
            throw an;
        }
      



    }
    public void clear()
    {
        Firstname_txtbox.Value = "";
        Lastname_txtbox.Value = "";
        Sex_txtbox.Value = "";
        Studyingin_txtbox.Value = "";
      //  Subject_txtbox.Value = "";
        Special_txtbox.Value = "";
        Email_txtbox.Value = "";
        Contact_txtbox.Value = "";
        Address_txtbox.Value = "";
        Country_txtbox.Value = "";
        City_txtbox.Value = "";
        Zip_txtbox.Value = "";
        Street_txtbox.Value = "";
        Password_txtbox.Value = "";
        Dob_txtbox.Value = "";
     //   Sex_input.Value = "";
        Whereyhere.Value = "";
    }
}