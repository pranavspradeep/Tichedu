using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addevent : System.Web.UI.Page
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
        if (event_date.Text == "" || event_title.Text == ""|| event_data.Text=="")
        {
            msg.Text = "All fields required";
        }
        else
        {
          




            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert_event", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@eventdate", event_date.Text);
            cmd.Parameters.AddWithValue("@eventtitle", event_title.Text);
            cmd.Parameters.AddWithValue("@eventdata", event_data.Text);

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
        SqlCommand cmd = new SqlCommand("Fetch_event", connection);
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
        SqlCommand cmd = new SqlCommand("deleteEvent", connection);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
        DataBinder();
        connection.Close();
    }


}
