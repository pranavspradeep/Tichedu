<%@ WebHandler Language="C#" Class="FileCS" %>

using System;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
public class FileCS : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        int id = int.Parse(context.Request.QueryString["id"]);
        byte[] bytes;
        string contentType;
        string constr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        string name;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT VIDE0_TITLE,VIDEO_FILE FROM TBL_VIDEO_UPLOAD WHERE VIDEO_UPLOAD_TYPE='TEACHER' AND VIDEO_ID=@Id ";
               cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    sdr.Read();
                    bytes = (byte[])sdr["VIDEO_FILE"];
                   // contentType = sdr["VIDEO_UPLOAD_TYPE"].ToString();
                    name = sdr["VIDE0_TITLE"].ToString();
                }
                con.Close();
            }
        }
        context.Response.Clear();
        context.Response.Buffer = true;
        context.Response.AppendHeader("Content-Disposition", "attachment; filename=" + name);
        //context.Response.ContentType = contentType;
        context.Response.BinaryWrite(bytes);
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