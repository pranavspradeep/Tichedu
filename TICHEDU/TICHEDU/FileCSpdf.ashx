<%@ WebHandler Language="C#" Class="FileCSpdf" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
public class FileCSpdf : IHttpHandler
{
        public void ProcessRequest(HttpContext context)
    {
        int id = int.Parse(context.Request.QueryString["Id"]);
        byte[] bytes;
        string fileName, contentType;
        string constr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT PDF_TITLE, PDF_FILE FROM TBL_PDF_UPLOADS WHERE PDF_ID=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    bytes = (byte[])sdr["PDF_FILE"];
                   // contentType = sdr["ContentType"].ToString();
                    fileName = sdr["PDF_TITLE"].ToString();
                }
                con.Close();
            }
        }
 
        context.Response.Buffer = true;
        context.Response.Charset = "";
        if (context.Request.QueryString["download"] == "1")
        {
            context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + fileName);
        }
        context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        context.Response.ContentType = "application/pdf";
        context.Response.BinaryWrite(bytes);
        context.Response.Flush();
        context.Response.End();
    }
 
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }





}
