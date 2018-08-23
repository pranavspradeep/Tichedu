using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace App_Code.TeacherRegistration
{ 
/// <summary>
/// Summary description for TeacherRegistrationController
/// </summary>
public class TeacherRegistrationController
{
    public void Save(TeacherRegistrationData TeacherRegistrationinput)
    {
        try {

                





                SqlConnection con = DBConnect.myCon;
                //SqlCommand cmd = con.CreateCommand();
                //  cmd.CommandText = "Execute  @TEACHER_FIRST_NAME,@TEACHER_LAST_NAME,@TEACHER_DOB,@TEACHER_SEX ,@TEACHER_QUALIFICATION ,@TEACHER_SUBJECT ,@TEACHER_SPECIALIZATION ,@TEACHER_EMAIL , @TEACHER_CONTACT,@TEACHER_ADDRESS ,@TEACHER_COUNTRY ,@TEACHER_CITY ,@TEACHER_STREET ,@TEACHER_ZIP ,@TEACHER_USERNAME,@TEACHER_PASSWORD ,@TEACHER_WHERE_HERE_ABOUT,@TEACHER_PHOTO";
                SqlCommand cmd = new SqlCommand("TEACHER_REGISTRATION_INSERT", con);
                    cmd.CommandType = CommandType.StoredProcedure;




                    cmd.Parameters.Add("@TEACHER_FIRST_NAME", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Firstname;
        cmd.Parameters.Add("@TEACHER_LAST_NAME", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Lastname;
        cmd.Parameters.Add("@TEACHER_QUALIFICATION", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Qualification;
        cmd.Parameters.Add("@TEACHER_SUBJECT", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Subject;
        cmd.Parameters.Add("@TEACHER_SPECIALIZATION", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Specialization;
        cmd.Parameters.Add("@TEACHER_EMAIL", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Email;
        cmd.Parameters.Add("@TEACHER_CONTACT", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Contact;
        cmd.Parameters.Add("@TEACHER_ADDRESS", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Address;
        cmd.Parameters.Add("@TEACHER_COUNTRY", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Country;
        cmd.Parameters.Add("@TEACHER_CITY", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_City;
        cmd.Parameters.Add("@TEACHER_ZIP", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Zip;
        cmd.Parameters.Add("@TEACHER_USERNAME", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Username;
        cmd.Parameters.Add("@TEACHER_PASSWORD", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_Password;
        cmd.Parameters.Add("@TEACHER_WHERE_HERE_ABOUT", SqlDbType.VarChar).Value = TeacherRegistrationinput.Teacher_where_here_about;
        cmd.Parameters.Add("@TEACHER_PHOTO", SqlDbType.VarBinary).Value = TeacherRegistrationinput.Teacher_Photo;
        con.Open();
     int i=   cmd.ExecuteNonQuery();
        con.Close();
        if (i!=0)
        {
           ///do sucess code 
        }
        }
        catch(Exception e)
        {
            throw e;
        }
    }
}


}
















