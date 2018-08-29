using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : System.Web.UI.Page
{
    string cs = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {  if(!IsPostBack)
        {
            filldropdownclass();
            filldrpdownsubject();
        }
        
    }

    protected void Class_btn_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_class (Class) VALUES('" + class_txtbox.Text + "')", con);

            con.Open();

          int i=  cmd.ExecuteNonQuery();

            con.Close();

            if(i>0)
            {
                suc_msg_label.Text = "Record inserted";
              

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
            else
            {
                suc_msg_label.Text = "failed";
            }
        }
        catch (Exception q)
        {
            throw q;
        }
    }

    protected void sub_btn_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_subject (Subject) VALUES('" + Sub_txtbox.Text + "')", con);

            con.Open();

         int i=   cmd.ExecuteNonQuery();

            con.Close();
            if (i > 0)
            {
                MSG1.Text = "Record inserted";
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
            else
            {
                MSG1.Text = "failed";
            }
        }
        catch (Exception q)
        {
            throw q;
        }

    }

    public void filldropdownclass()
    {


        SqlConnection con = new SqlConnection(cs);
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

    public void filldrpdownsubject()
    {
        SqlConnection con = new SqlConnection(cs);
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


    protected void addclasssubj_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_class_subject (class,subject) VALUES(@class,@subject)", con);
            cmd.Parameters.AddWithValue("@class", classdrop.Text);
            cmd.Parameters.AddWithValue("@subject", subjectdrop.Text);
            con.Open();

       int i=     cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MSG2.Text = "Record inserted";
            }
            else
            {
                MSG2.Text = "failed";
            }

            con.Close();
        }
        catch (Exception q)
        {
            throw q;
        }
    }

    protected void exam_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Examname (Exam_name) VALUES(@examname)", con);
            cmd.Parameters.AddWithValue("@examname", exam_txybox.Text);
            
            con.Open();

        int i=    cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MSG3.Text = "Record inserted";
            }
            else
            {
                MSG3.Text = "failed";
            }
            con.Close();
        }
        catch (Exception q)
        {
            throw q;
        }
    }

    protected void classdrop_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(cs);
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

    protected void listing_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminlisting.aspx");
    }
}
