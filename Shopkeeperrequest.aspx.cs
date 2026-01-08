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
    public partial class Shopkeeperrequest : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
           
            GridView1.Visible = true;
            SqlDataAdapter dt = new SqlDataAdapter("select * from orderTempTable where Shopname='" + Session["shopKeeperShopname"] + "'", conn);
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
            SqlCommand cmd = new SqlCommand("select * from orderTempTable where Id=@e1", conn);
            cmd.Parameters.AddWithValue("@e1", TextBox1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TextBox2.Text = dr["email"].ToString();
                TextBox3.Text = dr["FoodName"].ToString();
                TextBox4.Text = dr["Qty"].ToString();
                TextBox5.Text = dr["Total"].ToString();
                TextBox6.Text = dr["Location"].ToString();
                TextBox7.Text = dr["PhNumber"].ToString();
                TextBox8.Text = dr["Date"].ToString();
                TextBox9.Text = dr["Time"].ToString();

            }
            else
            {
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
            }
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string o =TextBox3.Text+" မှာယူမှု မရပါ";
            SqlCommand un = new SqlCommand("insert into userNotiTable(Receive,Foodname,Email,message) values(@a1,@a2,@a3,@a4)", conn);
            un.Parameters.AddWithValue("@a1", "No");
            un.Parameters.AddWithValue("@a2", TextBox3.Text);
            un.Parameters.AddWithValue("@a3", TextBox2.Text);
            un.Parameters.AddWithValue("@a4", o);

            un.ExecuteNonQuery();

            SqlCommand amd = new SqlCommand("delete from orderTempTable where Id=@a1", conn);
            amd.Parameters.AddWithValue("@a1", TextBox1.Text);
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string o = TextBox3.Text + " မှာယူမှု ရပါသည်။";
            SqlCommand un = new SqlCommand("insert into userNotiTable(Receive,Foodname,Email,message) values(@a1,@a2,@a3,@a4)",conn);
            un.Parameters.AddWithValue("@a1", "Yes");
            un.Parameters.AddWithValue("@a2", TextBox3.Text);
            un.Parameters.AddWithValue("@a3", TextBox2.Text);
            un.Parameters.AddWithValue("@a4", o);
            un.ExecuteNonQuery();


            SqlCommand ucmd = new SqlCommand("update ShopkeeperrequestTable set Receive=@x1 where userEmail=@a1 and FoodName=@a2 and Date=@a3 and Time=@a4",conn);
            ucmd.Parameters.AddWithValue("@a1", TextBox2.Text);
            ucmd.Parameters.AddWithValue("@a2", TextBox3.Text);
            ucmd.Parameters.AddWithValue("@a3", TextBox8.Text);
            ucmd.Parameters.AddWithValue("@a4", TextBox9.Text);
            ucmd.Parameters.AddWithValue("@x1", "Yes");

            ucmd.ExecuteNonQuery();

            SqlCommand amd = new SqlCommand("delete from orderTempTable where Id=@a1", conn);
            amd.Parameters.AddWithValue("@a1", TextBox1.Text);
           
            amd.ExecuteNonQuery();


            



            conn.Close();
        }

    }
}