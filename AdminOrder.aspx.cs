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
    public partial class AdminOrder : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
        
            if (!IsPostBack)
            {
                int i = 0;
                SqlCommand amd = new SqlCommand("select count(Id) from DeliveryloginTable", conn);
                int count = (int)amd.ExecuteScalar();

                string[] mama = new string[count];
               
                SqlCommand cx = new SqlCommand("select * from DeliveryloginTable ", conn);
                SqlDataReader rx = cx.ExecuteReader();
                while (rx.Read())
                {
                    mama[i] = rx["Dname"].ToString();
                    DropDownList1.Items.Add(mama[i]);
                    i++;
                }
                rx.Close();
            }


            SqlCommand sendamd = new SqlCommand("select count(Id) from ShopkeeperrequestTable where Receive='Yes'", conn);
            int sendcount = (int)sendamd.ExecuteScalar();
            if (sendcount == 0)
            {
                sendLabel.Visible = false;
                Response.Write("<script>alert('No Order')</script>");

            }
            else
            {
                GridView1.Visible = true;
                SqlDataAdapter dt = new SqlDataAdapter("select * from ShopkeeperrequestTable where Receive='Yes'", conn);
                DataSet ds = new DataSet();
                dt.Fill(ds, "p");
                conn.Close();
                DataTable da = new DataTable();
                dt.Fill(da);
                dt.Update(ds, "p");
                GridView1.DataSource = da;
                GridView1.DataBind();
            }
            conn.Close();
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            

           


            SqlCommand d = new SqlCommand("select * from DelivaryTable where userEmail=@a1 and FoodName=@a2 and Qty=@a3 and TotalPrice=@a4 and Shopname=@a5 and ULocation=@a6 and UPhNumber=@a7 and Date=@a8 and Time=@a9 and Receive=@a10",conn);
            d.Parameters.AddWithValue("@a1", TextBox2.Text);
            d.Parameters.AddWithValue("@a2", TextBox3.Text);
            d.Parameters.AddWithValue("@a3", TextBox4.Text);
            d.Parameters.AddWithValue("@a4", TextBox5.Text);
            d.Parameters.AddWithValue("@a5", TextBox6.Text);
            d.Parameters.AddWithValue("@a6", TextBox7.Text);
            d.Parameters.AddWithValue("@a7", TextBox8.Text);
            d.Parameters.AddWithValue("@a8", TextBox9.Text);
            d.Parameters.AddWithValue("@a9", TextBox10.Text);
            d.Parameters.AddWithValue("@a10", "No");
            SqlDataReader dr = d.ExecuteReader();
            if (dr.Read())
            {
                Response.Write("<script>alert('You had send.')</script>");
                dr.Close();
            }
            else
            {
                dr.Close();
                SqlCommand cmd = new SqlCommand("insert into DelivaryTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive,Delivaryname) values(@e1,@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9,@e10,@e11)", conn);
                cmd.Parameters.AddWithValue("@e1", TextBox2.Text);
                cmd.Parameters.AddWithValue("@e2", TextBox3.Text);
                cmd.Parameters.AddWithValue("@e3", TextBox4.Text);
                cmd.Parameters.AddWithValue("@e4", TextBox5.Text);
                cmd.Parameters.AddWithValue("@e5", TextBox6.Text);
                cmd.Parameters.AddWithValue("@e6", TextBox7.Text);
                cmd.Parameters.AddWithValue("@e7", TextBox8.Text);
                cmd.Parameters.AddWithValue("@e8", TextBox9.Text);
                cmd.Parameters.AddWithValue("@e9", TextBox10.Text);
                cmd.Parameters.AddWithValue("@e10", "No");
                cmd.Parameters.AddWithValue("@e11", DropDownList1.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
            }
           
            
            //Deleted form
            SqlCommand deleteaa = new SqlCommand("delete from ShopkeeperrequestTable ", conn);
            deleteaa.ExecuteNonQuery();
            //Deleted form


            //Insert accept table
            SqlCommand aad = new SqlCommand("insert into AdminacceptTable(userEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,Date,Time,Receive,Deliveryname) values(@ea1,@ea2,@ea3,@ea4,@ea5,@ea6,@ea7,@ea8,@ea9,@ea10,@ea11)", conn);
            aad.Parameters.AddWithValue("@ea1", TextBox2.Text);
            aad.Parameters.AddWithValue("@ea2", TextBox3.Text);
            aad.Parameters.AddWithValue("@ea3", TextBox4.Text);
            aad.Parameters.AddWithValue("@ea4", TextBox5.Text);
            aad.Parameters.AddWithValue("@ea5", TextBox6.Text);
            aad.Parameters.AddWithValue("@ea6", TextBox7.Text);
            aad.Parameters.AddWithValue("@ea7", TextBox8.Text);
            aad.Parameters.AddWithValue("@ea8", TextBox9.Text);
            aad.Parameters.AddWithValue("@ea9", TextBox10.Text);
            aad.Parameters.AddWithValue("@ea10", "Yes");
            aad.Parameters.AddWithValue("@ea11", DropDownList1.SelectedItem.ToString());
            aad.ExecuteNonQuery();
            //Insert accept table
            conn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ShopkeeperrequestTable where Id='" + TextBox1.Text + "'", conn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                TextBox2.Text=r["userEmail"].ToString();
                TextBox3.Text = r["FoodName"].ToString();
                TextBox4.Text = r["Qty"].ToString();
                TextBox5.Text = r["TotalPrice"].ToString();
                TextBox6.Text = r["Shopname"].ToString();
                TextBox7.Text = r["ULocation"].ToString();
                TextBox8.Text = r["UPhNumber"].ToString();
                TextBox9.Text = r["Date"].ToString();
                TextBox10.Text = r["Time"].ToString();

            }
            r.Close();
            conn.Close();
        }

    }
}