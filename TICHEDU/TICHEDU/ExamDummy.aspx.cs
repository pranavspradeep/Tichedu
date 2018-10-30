using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ExamDummy : System.Web.UI.Page
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
        userkey = Request.QueryString["student"];
        if (!Page.IsPostBack)
        {
            Timer1.Enabled = false;
            Timer2.Enabled = false;
            Disp_Ques();
            Session["tmct"] = "10";
            Session["ExmTime"] = "10";
            Session["mrk"] = "0";
           // Session["tmct"] = Session["ExmTime"].ToString(); Session["mrk"] = 0; Label1.Text = DateTime.Now.ToLongTimeString(); Label4.Text = Session["ExmTime"].ToString();
        }
        if (userkey == null)
        {
            userkey = Session["userid"].ToString();
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        tmct = Convert.ToInt32(Session["tmct"].ToString()) - 1;
        Label1.Text = DateTime.Now.ToLongTimeString();

        Label4.Text = tmct.ToString();

        Session["tmct"] = tmct;
        if (tmct <= 0)
        {
            Response.Redirect("ExmEnd.aspx");
        }
    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {

        Label1.Text = DateTime.Now.ToLongTimeString();


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
        SqlDataAdapter da = new SqlDataAdapter("Select Question,Option1,Option2,Option3,Option4,Ans,QusImg from Tbl_Question ", con);

        da.Fill(ds);


        if (ds.Tables[0].Rows.Count >= 1)
        {

            dr = ds.Tables[0].Rows[0];
            lblQues.Text = dr[0].ToString();
            lbl1.Text = dr["Option1"].ToString();
            lbl2.Text = dr["Option2"].ToString();
            lbl3.Text = dr["Option3"].ToString();
            lbl4.Text = dr["Option4"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            Ans = dr["Ans"].ToString();
            if (dr["QusImg"].ToString().Trim() != "")
            {
                Image1.Visible = true;
                Image1.ImageUrl = "Files\\" + dr["QusImg"].ToString();
                //Response.Write(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files\\" + dr["QusImg"].ToString());
            }
            else
            {
                Image1.Visible = false;
            }
            Session["Ans"] = Ans;
            Session["data"] = ds;
            Session["ct"] = 0;
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Cal_Rslt();
        Disp_NxtQus();
    }
    public void Cal_Rslt()
    {
        Mrks = Convert.ToInt32(Session["mrk"].ToString());
        if (RadioButton1.Checked == true)
            UsrAns = "1";
        if (RadioButton2.Checked == true)
            UsrAns = "2";
        if (RadioButton3.Checked == true)
            UsrAns = "3";
        if (RadioButton4.Checked == true)
            UsrAns = "4";

        if (UsrAns == Session["Ans"].ToString())
            Session["mrk"] = Mrks + 1;
    }
    public void Disp_NxtQus()
    {
        ds = (DataSet)Session["data"];
        ct = Convert.ToInt32(Session["ct"].ToString());
        ct = ct + 1;
        if (ct < ds.Tables[0].Rows.Count)
        {

            dr = ds.Tables[0].Rows[ct];
            Ans = dr["Ans"].ToString();
            Session["Ans"] = Ans;
            lblQues.Text = dr[0].ToString();
            lbl1.Text = dr["Option1"].ToString();
            lbl2.Text = dr["Option2"].ToString();
            lbl3.Text = dr["Option3"].ToString();
            lbl4.Text = dr["Option4"].ToString();
            if (dr["QusImg"].ToString().Trim() != "")
            {
                Image1.Visible = true;
                Image1.ImageUrl = "Files\\" + dr["QusImg"].ToString();
                //Response.Write(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Files\\" + dr["QusImg"].ToString());
            }
            else
            {
                Image1.Visible = false;
            }
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            Session["ct"] = ct;

        }
        else
        {
            //lblQues.Text = "Congrats you are at end of the Exam. Click Next for Result";
            Response.Redirect("ExmEnd.aspx");

        }
    }

}