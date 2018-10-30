using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    string con = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
       //ataBinder();
       //ataBinderEvent();
    }
    public void DataBinder()
    {
        SqlConnection connection = new SqlConnection(con);
        connection.Open();
        SqlCommand cmd = new SqlCommand("Fetch_news", connection);
        SqlDataAdapter adpData = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adpData.Fill(dt);
      //Repeater1.DataSource = dt;
    //  Repeater1.DataBind();
        connection.Close();
    }
    public void DataBinderEvent()
    {
        SqlConnection connection = new SqlConnection(con);
        connection.Open();
        SqlCommand cmd = new SqlCommand("Fetch_event", connection);
        SqlDataAdapter adpData = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adpData.Fill(dt);
      //Repeater2.DataSource = dt;
      //Repeater2.DataBind();
        connection.Close();
    }
}