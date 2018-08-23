using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StudentTrack
/// </summary>
public class StudentTrack
{
    string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    public void StudentTracker(string stdid, string visitedsubject, string cls, DateTime datetime)//cls=class
    {
        SqlConnection sqlConnection = new SqlConnection(strConnString);
        sqlConnection.Open();
        string query = "insert into StudentActTrack (Std_Id,Std_visited_class,Std_visited_subject,Date_time)values(@stdid,@visitedclass,@visitedsubject,@datetime)";
        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

        //  sqlCommand.Parameters.AddWithValue("@stdusername", stdusername);
        sqlCommand.Parameters.AddWithValue("@stdid", stdid);
        sqlCommand.Parameters.AddWithValue("@visitedsubject", visitedsubject);
        sqlCommand.Parameters.AddWithValue("@visitedclass", cls);
        sqlCommand.Parameters.AddWithValue("@datetime", datetime);
        sqlCommand.ExecuteNonQuery();

        sqlConnection.Close();
    }
}