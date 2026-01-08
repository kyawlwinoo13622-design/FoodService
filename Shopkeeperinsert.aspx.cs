using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace foodservice
{
    public partial class Shopkeeperinsert : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            //lbl.Text=Session["email"].ToString();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string imagename = FileUpload1.FileName;
            string contenttype = FileUpload1.PostedFile.ContentType;
            byte[] imageData;

            using (var binaryReader = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                imageData = binaryReader.ReadBytes(FileUpload1.PostedFile.ContentLength);

            }

            string[] ar=new string[100];
            int i = 0;
            SqlCommand aramd = new SqlCommand("select * from allTable where Email='" + Session["email"] + "'", conn);
            

            SqlDataReader ardd = aramd.ExecuteReader();
            while (ardd.Read())
            {
                ar[i]=ardd["Foodname"].ToString();
                i++;
            }
            ardd.Close();

            //Label9.Text = ar[0];
            //Label10.Text = ar[1];
            //Label11.Text = ar[2];
            SqlCommand amd = new SqlCommand("select * from ShopkeeperTable where Email='" + Session["email"] + "'", conn);
           

            SqlDataReader dd = amd.ExecuteReader();
            if (dd.Read() )
            {
                if (TextBox1.Text== dd["Email"].ToString()  &&  TextBox6.Text==dd["Shopname"].ToString() )
                {
                    //if (txtFoodName.Text != ar[i].ToString())
                    //{
                        Label8.Visible = true;

                        SqlCommand cmd = new SqlCommand("insert into allTable(Foodname,Email,Price,Typeoffood,image,Description,Shopname) values(@a1,@a2,@a3,@a4,@a5,@a6,@a7)", conn);
                        cmd.Parameters.AddWithValue("@a1", txtFoodName.Text);

                        cmd.Parameters.AddWithValue("@a2", Session["email"].ToString());
                        cmd.Parameters.AddWithValue("@a3", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@a4", ListBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@a5", imagename);

                        cmd.Parameters.AddWithValue("@a6", TextBox5.Text);
                        cmd.Parameters.AddWithValue("@a7", TextBox6.Text);
                        dd.Close();
                        cmd.ExecuteNonQuery();
                    //}
                    //else
                    //{
                    //    Response.Write("<script>alert('inn');</script>");
                    //}
                    conn.Close();
                }
                else
                {
                    Label8.Visible = false;
                    Response.Write("<script>alert('incorrect email or shop name');</script>");
                    dd.Close();
                }
               
            }
            else
            {
                Label8.Visible = false;
                Response.Write("<script>alert('incorrect email');</script>");
                dd.Close();
            }
        }
        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtFoodName.Text = "";
            TextBox1.Text="";
                TextBox2.Text="";
                TextBox5.Text="";
                TextBox6.Text = "";
        }
    }
}