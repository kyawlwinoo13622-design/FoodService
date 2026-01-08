
using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.FileUpload;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{ 
    public partial class Shop : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
          //Response.Write( Session["email"]);
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            //conn.Open();
            //string imagename = fileupload1.FileName;
            //string contenttype = fileupload1.PostedFile.ContentType;
            //byte[] imageData;

            //using (var binaryReader = new BinaryReader(fileupload1.PostedFile.InputStream))
            //{
            //    imageData = binaryReader.ReadBytes(fileupload1.PostedFile.ContentLength);

            //}

            //SqlCommand cmd = new SqlCommand("insert into SsTable(Foodname,Email,Price,Typeoffood,Description) values(@a1,@a2,@a3,@a4,@a6)", conn);
            //cmd.Parameters.AddWithValue("@a1", TextBox1.Text);
            //cmd.Parameters.AddWithValue("@a2", TextBox1.Text);
            //cmd.Parameters.AddWithValue("@a3", TextBox3.Text);
            //cmd.Parameters.AddWithValue("@a4", TextBox4.Text);
            ////cmd.Parameters.AddWithValue("@a5", imageData);
            //cmd.Parameters.AddWithValue("@a6", TextBox5.Text);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            ////Response.Write("<script>alert('ok')</script>");

            

            //HttpPostedFile postedFile = fileupload1.PostedFile;
            //string fileName = Path.GetFileName(postedFile.FileName);
            //string fileExtension = Path.GetExtension(fileName);
            //int fileSize = postedFile.ContentLength;
            //if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp" || fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
            //{
            //    Stream stream = postedFile.InputStream;
            //    BinaryReader binaryReader = new BinaryReader(stream);
            //    byte[] bytes=binaryReader.ReadBytes((int)stream.Length);
            //    SqlCommand cmd = new SqlCommand("insert into ShopTable(image,FoodName,Price,Description) values(@a1,@a2,@a3,@a4)", conn);
            //    cmd.Parameters.AddWithValue("@a1", bytes);
            //    cmd.Parameters.AddWithValue("@a2", TextBox1.Text);
            //    cmd.Parameters.AddWithValue("@a3", TextBox2.Text);
            //    cmd.Parameters.AddWithValue("@a4", TextBox3.Text);
            //    cmd.ExecuteNonQuery();
            //    Response.Write("ssssss");
            //}
            //else
            //{
            //    Response.Write("error");
            //}
            //conn.Close();

            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into ShopTable(FoodName,Price,Description) values(@a1,@a2,@a3)",conn);
            //cmd.Parameters.AddWithValue("@a1",TextBox1.Text);
            //cmd.Parameters.AddWithValue("@a2", TextBox2.Text);
            //cmd.Parameters.AddWithValue("@a3", TextBox3.Text);
            
            //cmd.ExecuteNonQuery();
            //Response.Write("Successfully");
            //conn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //Label5.Visible = true;
            //Label1.Visible = true;
            Response.Write("<script>alert('ok')</script>");
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("homemaster.aspx");
        }
    }
}