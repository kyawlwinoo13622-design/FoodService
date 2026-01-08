using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace foodservice
{
    public partial class Request : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            GridView1.Visible = true;
            SqlDataAdapter dt = new SqlDataAdapter("select * from requestTable", conn);
            DataSet ds = new DataSet();
            dt.Fill(ds, "p");
            conn.Close();
            DataTable da = new DataTable();
            dt.Fill(da);
            dt.Update(ds, "p");
            GridView1.DataSource = da;
            GridView1.DataBind();
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from requestTable where Id=@e1", conn);
            cmd.Parameters.AddWithValue("@e1", TextBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox2.Text=dr["Name"].ToString();
                TextBox3.Text = dr["Email"].ToString();
                TextBox4.Text = dr["Password"].ToString();
                TextBox5.Text=dr["Shopname"].ToString();
                TextBox6.Text=dr["PhNumber"].ToString();
                TextBox7.Text=dr["Location"].ToString();
            }
            else{
                TextBox2.Text="";
                TextBox3.Text="";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into ShopkeeperTable(Name,Email,Password,Shopname,PhNumber,Location) values(@e1,@e2,@e3,@e4,@e5,@e6)", conn);
            cmd.Parameters.AddWithValue("@e1", TextBox2.Text);
            cmd.Parameters.AddWithValue("@e2", TextBox3.Text);
            cmd.Parameters.AddWithValue("@e3", TextBox4.Text);
            cmd.Parameters.AddWithValue("@e4", TextBox5.Text);
            cmd.Parameters.AddWithValue("@e5", TextBox6.Text);
            cmd.Parameters.AddWithValue("@e6", TextBox7.Text);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('successful')</script>");
            SqlCommand dmd = new SqlCommand(@"delete from requestTable where Id=@e1", conn);
            dmd.Parameters.AddWithValue("@e1", TextBox1.Text);
            dmd.ExecuteNonQuery();
            Response.Write("<script>alert('Ok');</script>");
            conn.Close();
        }
    }
}