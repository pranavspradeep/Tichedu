using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ExamEnd : System.Web.UI.Page
{
    string userkey;
    int ct = 0;
    DataRow dr;
    int tmct = 0;
    int Mrks = 0;
    string Ans = "", UsrAns = "";
    DataSet ds = new DataSet();
    string strConnString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

        outof_lab.Text = Session["questionumber"].ToString();
        Questionanswer.Visible = false;
        userkey = Request.QueryString["student"];
        if (userkey == null)
        {
            userkey = Session["userid"].ToString();
        }

        if (!Page.IsPostBack)
        {
            //yourmarks_label.Text = mark().ToString();
             yourmarks_label.Text = Session["mrk"].ToString();
            // Timer1.Enabled = false;
            //Timer2.Enabled = false;
            Disp_Ques();
            Session["tmct"] = "10";
            Session["ExmTime"] = "10";
            Session["mrk"] = "0";
            // Session["tmct"] = Session["ExmTime"].ToString(); Session["mrk"] = 0; Label1.Text = DateTime.Now.ToLongTimeString(); Label4.Text = Session["ExmTime"].ToString();
            insertresult(Session["exam"].ToString(), Session["subject"].ToString(), Session["class"].ToString(), userkey, yourmarks_label.Text, outof_lab.Text);


        }
       


    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        tmct = Convert.ToInt32(Session["tmct"].ToString()) - 1;
       // Label1.Text = DateTime.Now.ToLongTimeString();

       // Label4.Text = tmct.ToString();

        Session["tmct"] = tmct;
        if (tmct <= 0)
        {
            Response.Redirect("ExmEnd.aspx");
        }
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {

       // Label1.Text = DateTime.Now.ToLongTimeString();


    }
    protected void Profile_link_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("student-profile.aspx?student=" + userkey);
    }


    protected void Pdfnoteslink_btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("PdfnotesViewStudent.aspx/?student=" + userkey);
    }

    protected void video_link_Click(object sender, EventArgs e)
    {
        Response.Redirect("student.aspx?student=" + userkey);
    }

    protected void Youtubevideos_Click(object sender, EventArgs e)
    {
        Response.Redirect("YoutubeViewStudent.aspx?student=" + userkey);
    }

    protected void Youtubelive_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("YoutubeLiveStudent.aspx?student=" + userkey);
    }
    protected void Groupchat_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("StudentGroupChat.aspx?student=" + userkey);
    }

    protected void examlink_Click(object sender, EventArgs e)
    {
        Session["userkey"] = userkey;
        Response.Redirect("SelectExam.aspx?student=" + userkey);
    }
    public void Disp_Ques()
    {
        SqlConnection con = new SqlConnection(strConnString);
        SqlDataAdapter da = new SqlDataAdapter("Select Question,Option1,Option2,Option3,Option4,Question_Answer,QusImg,Question_id from Tbl_Question", con);

        da.Fill(ds);


        if (ds.Tables[0].Rows.Count >= 1)
        {

            dr = ds.Tables[0].Rows[0];
            //lblQues.Text = dr[0].ToString();
            Session["questionid"] = dr["Question_id"].ToString();
          //  lbl1.Text = dr["Option1"].ToString();
           // lbl2.Text = dr["Option2"].ToString();
          //  lbl3.Text = dr["Option3"].ToString();
          //  lbl4.Text = dr["Option4"].ToString();
           // RadioButton1.Checked = false;
           // RadioButton2.Checked = false;
          //  RadioButton3.Checked = false;
          //  RadioButton4.Checked = false;
           // Ans = dr["Question_Answer"].ToString();
            if (dr["QusImg"].ToString().Trim() != "")
            {
               // Image1.Visible = true;
              //  Image1.ImageUrl = "Files\\" + dr["QusImg"].ToString();
                //Response.Write(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files\\" + dr["QusImg"].ToString());
            }
            else
            {
             //   Image1.Visible = false;
            }
            Session["Ans"] = Ans;
            Session["data"] = ds;
            Session["ct"] = 0;
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Cal_Rslt();
        insert_ans();
        Disp_NxtQus();
    }
    public void Cal_Rslt()
    {
        Mrks = Convert.ToInt32(Session["mrk"].ToString());
       // if (RadioButton1.Checked == true)
            UsrAns = "1";
       // if (RadioButton2.Checked == true)
       //     UsrAns = "2";
      //  if (RadioButton3.Checked == true)
            UsrAns = "3";
     //   if (RadioButton4.Checked == true)
            UsrAns = "4";
//
      //  if (UsrAns == Session["Ans"].ToString())
            Session["mrk"] = Mrks + 1;
    }
    public void Disp_NxtQus()
    {   //add insert function
        ds = (DataSet)Session["data"];
        ct = Convert.ToInt32(Session["ct"].ToString());
        ct = ct + 1;
        if (ct < ds.Tables[0].Rows.Count)
        {

            dr = ds.Tables[0].Rows[ct];
            Ans = dr["Question_Answer"].ToString();
            Session["Ans"] = Ans;
         //   lblQues.Text = dr[0].ToString();
         //   lbl1.Text = dr["Option1"].ToString();
         //   lbl2.Text = dr["Option2"].ToString();
         //   lbl3.Text = dr["Option3"].ToString();
         //   lbl4.Text = dr["Option4"].ToString();
            if (dr["QusImg"].ToString().Trim() != "")
            {
           //     Image1.Visible = true;
            //    Image1.ImageUrl = "Files\\" + dr["QusImg"].ToString();
                //Response.Write(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files\\" + dr["QusImg"].ToString());
            }
            else
            {
              //  Image1.Visible = false;
            }
          //  RadioButton1.Checked = false;
         //   RadioButton2.Checked = false;
           // RadioButton3.Checked = false;
          //  RadioButton4.Checked = false;
            Session["ct"] = ct;

        }
        else
        {
            //lblQues.Text = "Congrats you are at end of the Exam. Click Next for Result";
            Response.Redirect("ExmEnd.aspx");

        }
    }


    public void insert_ans()
    {

        //    if (RadioButton1.Checked)
        {
            try
            {
                SqlConnection con = new SqlConnection(strConnString);
                string ans = Session["Ans"].ToString();
                SqlCommand cmd = new SqlCommand("proc_insert_result", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //               cmd.Parameters.AddWithValue("@student_answer", lbl1.Text);
                cmd.Parameters.AddWithValue("@student_id", userkey);
                cmd.Parameters.AddWithValue("@orginal_answer", ans);
                cmd.Parameters.AddWithValue("@questionid", Session["questionid"].ToString());
                con.Open();

                int i = cmd.ExecuteNonQuery();

                con.Close();
            }



            catch (Exception e)
            {
                throw e;
            }
        }
        // if (RadioButton2.Checked)
        {
            try
            {
                SqlConnection con = new SqlConnection(strConnString);
                string ans = Session["Ans"].ToString();
                SqlCommand cmd = new SqlCommand("proc_insert_result", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //   cmd.Parameters.AddWithValue("@student_answer", lbl2.Text);
                cmd.Parameters.AddWithValue("@student_id", userkey);
                cmd.Parameters.AddWithValue("@orginal_answer", ans);
                cmd.Parameters.AddWithValue("@questionid", Session["questionid"].ToString());
                con.Open();

                int i = cmd.ExecuteNonQuery();

                con.Close();
            }



            catch (Exception e)
            {
                throw e;
            }
        }

        // if (RadioButton3.Checked)
        {
            try
            {
                SqlConnection con = new SqlConnection(strConnString);
                string ans = Session["Ans"].ToString();
                SqlCommand cmd = new SqlCommand("proc_insert_result", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //  cmd.Parameters.AddWithValue("@student_answer", lbl3.Text);
                cmd.Parameters.AddWithValue("@student_id", userkey);
                cmd.Parameters.AddWithValue("@orginal_answer", ans);
                cmd.Parameters.AddWithValue("@questionid", Session["questionid"].ToString());
                con.Open();

                int i = cmd.ExecuteNonQuery();

                con.Close();
            }



            catch (Exception e)
            {
                throw e;
            }
        }
        //   if (RadioButton4.Checked)
        {
            try
            {
                SqlConnection con = new SqlConnection(strConnString);
                string ans = Session["Ans"].ToString();
                SqlCommand cmd = new SqlCommand("proc_insert_result", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //  cmd.Parameters.AddWithValue("@student_answer", lbl4.Text);
                cmd.Parameters.AddWithValue("@student_id", userkey);
                cmd.Parameters.AddWithValue("@orginal_answer", ans);
                cmd.Parameters.AddWithValue("@questionid", Session["questionid"].ToString());
                con.Open();

                int i = cmd.ExecuteNonQuery();

                con.Close();
            }



            catch (Exception e)
            {
                throw e;
            }
        }
    }

    public int mark()
    {
        string stmt = "SELECT COUNT(*) FROM Tbl_examresult where Student_id="+ userkey + "and Student_ans=orginal_ans ";
        int count = 0;

        using (SqlConnection thisConnection = new SqlConnection(strConnString))
        {
            using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
            {
                thisConnection.Open();
                count = (int)cmdCount.ExecuteScalar();
            }
        }
        return count;
    }





    protected void ShowYourWrong_Click(object sender, EventArgs e)
    {
        Questionanswer.Visible = true;

        try
        {
            
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand("displaywrongansquestions", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", userkey);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        qnsans.DataSource = dt;
                        qnsans.DataBind();
                    }
                }
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }


    public void insertresult(string exm_name,string sub,string cls,string std_id, string marks,string outof)
    {
        try
        {

            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand("insert_exam_result_parents", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@std_id", std_id);
                        cmd.Parameters.AddWithValue("@exam_name", exm_name);
                        cmd.Parameters.AddWithValue("@sub", sub);
                        cmd.Parameters.AddWithValue("@cls", cls);
                        cmd.Parameters.AddWithValue("@marks", marks);
                        cmd.Parameters.AddWithValue("@outof", outof);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        qnsans.DataSource = dt;
                        qnsans.DataBind();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

}

