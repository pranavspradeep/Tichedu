using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forgotpassparents : System.Web.UI.Page
{
    string cs = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {  if (!IsPostBack)
        {
            // filldropdownclass();
            //filldrpdownsubject();
            classlisting();
            subjectlisting();
            classsubjectlist();
            Examnameslisting();
        }

        
    }


    public void classlisting()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "select Classid ,Class from Tbl_class ";


              
                cmd.Connection = con;
                con.Open();
                //StudentActivity_Tbl.DataSource = cmd.ExecuteReader();
               // StudentActivity_Tbl.DataBind();
                con.Close();
            }
        }


    }

    public void subjectlisting()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "select Subject_id ,Subject from Tbl_subject ";



                cmd.Connection = con;
                con.Open();
             //   subjectlist.DataSource = cmd.ExecuteReader();
              //  subjectlist.DataBind();
                con.Close();
            }
        }


    }
    public void classsubjectlist()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "select Class_subject_id,subject,class from Tbl_class_subject ";



                cmd.Connection = con;
                con.Open();
              //  classsublist.DataSource = cmd.ExecuteReader();
              //  classsublist.DataBind();
                con.Close();
            }
        }


    }


    public void Examnameslisting()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "select Exam_name_id ,Exam_name from Tbl_Examname ";



                cmd.Connection = con;
                con.Open();
             //   examnanelist.DataSource = cmd.ExecuteReader();
              //  examnanelist.DataBind();
                con.Close();
            }
        }


    }


    //NO use code from here

    //protected void Class_btn_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(cs);

    //        SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_class (Class) VALUES('" + class_txtbox.Text + "')", con);

    //        con.Open();

    //      int i=  cmd.ExecuteNonQuery();

    //        con.Close();

    //        if(i>0)
    //        {
    //            suc_msg_label.Text = "Record inserted";


    //            SqlCommand com = new SqlCommand("SELECT Class FROM Tbl_class", con); // table name 
    //            SqlDataAdapter da = new SqlDataAdapter(com);
    //            DataSet ds = new DataSet();
    //            da.Fill(ds);  // fill dataset
    //            classdrop.DataTextField = ds.Tables[0].Columns["Class"].ToString(); // text field name of table dispalyed in dropdown
    //                                                                                //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
    //            classdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
    //            classdrop.DataBind();  //binding dropdownlist

    //            con.Close();
    //            classdrop.Items.Insert(0, new ListItem("Select", "NA"));
    //        }
    //        else
    //        {
    //            suc_msg_label.Text = "failed";
    //        }
    //    }
    //    catch (Exception q)
    //    {
    //        throw q;
    //    }
    //}

    //protected void sub_btn_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(cs);

    //        SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_subject (Subject) VALUES('" + Sub_txtbox.Text + "')", con);

    //        con.Open();

    //     int i=   cmd.ExecuteNonQuery();

    //        con.Close();
    //        if (i > 0)
    //        {
    //            MSG1.Text = "Record inserted";
    //            con.Open();

    //            SqlCommand com = new SqlCommand("SELECT Subject FROM Tbl_subject", con); // table name 
    //            SqlDataAdapter da = new SqlDataAdapter(com);
    //            DataSet ds = new DataSet();
    //            da.Fill(ds);  // fill dataset
    //            subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
    //                                                                                    //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
    //            subjectdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
    //            subjectdrop.DataBind();  //binding dropdownlist

    //            con.Close();
    //            subjectdrop.Items.Insert(0, new ListItem("Select", "NA"));
    //        }
    //        else
    //        {
    //            MSG1.Text = "failed";
    //        }
    //    }
    //    catch (Exception q)
    //    {
    //        throw q;
    //    }

    //}

    //public void filldropdownclass()
    //{


    //    SqlConnection con = new SqlConnection(cs);
    //    con.Open();

    //    SqlCommand com = new SqlCommand("SELECT Class FROM Tbl_class", con); // table name 
    //    SqlDataAdapter da = new SqlDataAdapter(com);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);  // fill dataset
    //    classdrop.DataTextField = ds.Tables[0].Columns["Class"].ToString(); // text field name of table dispalyed in dropdown
    //    //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
    //   classdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
    //    classdrop.DataBind();  //binding dropdownlist

    //    con.Close();
    //    classdrop.Items.Insert(0, new ListItem("Select", "NA"));


    //}

    //public void filldrpdownsubject()
    //{
    //    SqlConnection con = new SqlConnection(cs);
    //    con.Open();

    //    SqlCommand com = new SqlCommand("SELECT Subject FROM Tbl_subject", con); // table name 
    //    SqlDataAdapter da = new SqlDataAdapter(com);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);  // fill dataset
    //    subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
    //                                                                        //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
    //    subjectdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
    //    subjectdrop.DataBind();  //binding dropdownlist

    //    con.Close();
    //    subjectdrop.Items.Insert(0, new ListItem("Select", "NA"));
    //}


    //protected void addclasssubj_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(cs);

    //        SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_class_subject (class,subject) VALUES(@class,@subject)", con);
    //        cmd.Parameters.AddWithValue("@class", classdrop.Text);
    //        cmd.Parameters.AddWithValue("@subject", subjectdrop.Text);
    //        con.Open();

    //   int i=     cmd.ExecuteNonQuery();
    //        if (i > 0)
    //        {
    //            MSG2.Text = "Record inserted";
    //        }
    //        else
    //        {
    //            MSG2.Text = "failed";
    //        }

    //        con.Close();
    //    }
    //    catch (Exception q)
    //    {
    //        throw q;
    //    }
    //}

    //protected void exam_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(cs);

    //        SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_Examname (Exam_name) VALUES(@examname)", con);
    //        cmd.Parameters.AddWithValue("@examname", exam_txybox.Text);

    //        con.Open();

    //    int i=    cmd.ExecuteNonQuery();
    //        if (i > 0)
    //        {
    //            MSG3.Text = "Record inserted";
    //        }
    //        else
    //        {
    //            MSG3.Text = "failed";
    //        }
    //        con.Close();
    //    }
    //    catch (Exception q)
    //    {
    //        throw q;
    //    }
    //}

    //protected void classdrop_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    SqlConnection con = new SqlConnection(cs);
    //    con.Open();

    //    SqlCommand com = new SqlCommand("SELECT Subject FROM Tbl_subject", con); // table name 
    //    SqlDataAdapter da = new SqlDataAdapter(com);
    //    DataSet ds = new DataSet();
    //    da.Fill(ds);  // fill dataset
    //    subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString(); // text field name of table dispalyed in dropdown
    //                                                                            //subjectdrop.DataTextField = ds.Tables[0].Columns["Subject"].ToString();             // to retrive specific  textfield name 
    //    subjectdrop.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
    //    subjectdrop.DataBind();  //binding dropdownlist

    //    con.Close();
    //    subjectdrop.Items.Insert(0, new ListItem("Select", "NA"));
    //}

    protected void StudentActivity_Tbl_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    //    int ID = Convert.ToInt32(StudentActivity_Tbl.DataKeys[e.Item.ItemIndex]);
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand mySqlCommand = new SqlCommand("delete from Tbl_class  where Classid=@ID", con);
        mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
        if (con.State == ConnectionState.Closed)
            con.Open();
        mySqlCommand.ExecuteNonQuery();
        if (con.State == ConnectionState.Open)
            con.Close();
        classlisting();

    }

    protected void examnanelist_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        //int ID = Convert.ToInt32(examnanelist.DataKeys[e.Item.ItemIndex]);
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand mySqlCommand = new SqlCommand("delete from Tbl_Examname  where Exam_name_id=@ID", con);
        mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
        if (con.State == ConnectionState.Closed)
            con.Open();
        mySqlCommand.ExecuteNonQuery();
        if (con.State == ConnectionState.Open)
            con.Close();
        Examnameslisting();
    }

    protected void subjectlist_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
     //   int ID = Convert.ToInt32(subjectlist.DataKeys[e.Item.ItemIndex]);
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand mySqlCommand = new SqlCommand("delete from Tbl_subject  where Subject_id=@ID", con);
        mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
        if (con.State == ConnectionState.Closed)
            con.Open();
        mySqlCommand.ExecuteNonQuery();
        if (con.State == ConnectionState.Open)
            con.Close();
        subjectlisting();

    }

    protected void classsublist_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
     //   int ID = Convert.ToInt32(classsublist.DataKeys[e.Item.ItemIndex]);
        SqlConnection con = new SqlConnection(strConnString);
        SqlCommand mySqlCommand = new SqlCommand("delete from Tbl_class_subject  where Class_subject_id=@ID", con);
        mySqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
        if (con.State == ConnectionState.Closed)
            con.Open();
        mySqlCommand.ExecuteNonQuery();
        if (con.State == ConnectionState.Open)
            con.Close();
        classsubjectlist();
    }

    

    protected void ADD_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin.aspx");
    }





    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login-Admin.aspx");
    }

    
    protected void Requestpassword_btn_Click1(object sender, EventArgs e)
    {
        if (email_txtbox.Text == "")
        {
            Error_label.Text = "Email field empty";
        }
        else
        {
            string sucess = "";
            ForgotPassword forgotPassword = new ForgotPassword();
            sucess = forgotPassword.Getuserpass(email_txtbox.Text, "select PARENT_PASSWORD from TBL_PARENT_REGISTRATION where PARENT_USERNAME=@Email", "PARENT_PASSWORD");
            if (sucess == "ok")
            {
                Error_label.Text = "User id and password sent to your registered email";
            }
        }
    }
}
