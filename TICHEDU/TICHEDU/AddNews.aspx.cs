using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addnews : System.Web.UI.Page
{
    string con = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
    string filename { set; get; }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        { DataBinder(); }

    }

    protected void submit_Click(object sender, EventArgs e)
    {
        if (news_date.Text == "" || news_title.Text == ""|| news_data.Text=="")
        {
            msg.Text = "All fields required";
        }
        else
        {
          




            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert_news", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@newdate", news_date.Text);
            cmd.Parameters.AddWithValue("@newstitle", news_title.Text);
            cmd.Parameters.AddWithValue("@newsdata", news_data.Text);

            int i = cmd.ExecuteNonQuery();
            if (i == 0)
            {
                msg.Text = "failed";
            }
            else
            {
                msg.Text = "Data inserted";
            }
            connection.Close();
            DataBinder();
        }


    }
    public void DataBinder()
    {
        SqlConnection connection = new SqlConnection(con);
        connection.Open();
        SqlCommand cmd = new SqlCommand("Fetch_news", connection);
        SqlDataAdapter adpData = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        adpData.Fill(dt);
        DataList1.DataSource = dt;
        DataList1.DataBind();
        connection.Close();
    }


    protected void delete_Click(object sender, EventArgs e)
    {
        int id = 0;
        Button myButton = sender as Button;
        if (myButton != null)
        {
            id = Convert.ToInt32(myButton.CommandArgument);
        }
        SqlConnection connection = new SqlConnection(con);
        connection.Open();
        SqlCommand cmd = new SqlCommand("deleteNews", connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        DataBinder();
        connection.Close();
    }


}
