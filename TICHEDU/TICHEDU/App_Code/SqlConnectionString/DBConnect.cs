using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DBConnect
/// </summary>
public class DBConnect
{
    
       public static SqlConnection myCon = null;

    public void CreateConnection()
    {
        myCon = new SqlConnection("Data Source=AG102;Initial Catalog=TichEdu;Integrated Security=True");
        myCon.Open();

    }
}
