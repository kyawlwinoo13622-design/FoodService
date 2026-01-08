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
    public partial class Delivary : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand amd = new SqlCommand("select count(Id) from DelivaryTable where Delivaryname='"+Session["dname"]+"'", conn);
            int count = (int)amd.ExecuteScalar();
            label2.Text = count.ToString();
           

            
            GridView2.Visible = true;
            SqlDataAdapter dt = new SqlDataAdapter("select * from DelivaryTable where Delivaryname='" + Session["dname"] + "'", conn);
            DataSet ds = new DataSet();
            dt.Fill(ds, "p");
            conn.Close();
            DataTable da = new DataTable();
            dt.Fill(da);
            dt.Update(ds, "p");
            GridView2.DataSource = da;
            GridView2.DataBind();
            conn.Close();
        }

       

        protected void btnlogoutd_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("homemaster.aspx");
            //lblhome.Visible = true;
            //lblallsearch.Visible = false;
        }
        string shop;
        string l;
        string p;
        string da;
        string t;
        string r;
        string dn;
        string tp;
        int tp1;
        int q;
        string qq;
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBox1.Checked)
            {
                conn.Open();
                
                SqlCommand cc = new SqlCommand("select * from DelivaryTable where userEmail=@a1 and FoodName=@a2 and Qty=@a3", conn);
                cc.Parameters.AddWithValue("@a1", TextBox1.Text);
                cc.Parameters.AddWithValue("@a2", TextBox3.Text);
                cc.Parameters.AddWithValue("@a3", TextBox4.Text);
                
                SqlDataReader ccd = cc.ExecuteReader();
                if (ccd.Read())
                {
                    shop = ccd["Shopname"].ToString();
                    l = ccd["ULocation"].ToString();
                    p = ccd["UPhNumber"].ToString();
                    da = ccd["Date"].ToString();
                    t = ccd["Time"].ToString();
                    r = ccd["Receive"].ToString();
                    dn= ccd["Delivaryname"].ToString();
                    tp =ccd["TotalPrice"].ToString();
                    qq = ccd["Qty"].ToString();
                    q = Convert.ToInt32(qq);
                    tp1 = Convert.ToInt32(tp);


                }

                ccd.Close();
                

                SqlCommand c = new SqlCommand("insert into OrderTable(UserEmail,FoodName,Qty,TotalPrice,Shopname,ULocation,UPhNumber,UDate,UTime,Receive,DelivaryName) values(@a1,@a2,@a3,@a4,@b5,@a6,@a7,@a8,@a9,@a10,@a11)", conn);
               
                c.Parameters.AddWithValue("@a1",TextBox1.Text);
                c.Parameters.AddWithValue("@a2", TextBox3.Text);
                c.Parameters.AddWithValue("@a3", q);
                c.Parameters.AddWithValue("@a4", tp1);
                c.Parameters.AddWithValue("@b5", shop);
                c.Parameters.AddWithValue("@a6", l);
                c.Parameters.AddWithValue("@a7", p);
                c.Parameters.AddWithValue("@a8", da);
                c.Parameters.AddWithValue("@a9", t);
                c.Parameters.AddWithValue("@a10", "Yes");
                c.Parameters.AddWithValue("@a11", dn);
                c.ExecuteNonQuery();

                SqlCommand Cartmd = new SqlCommand("delete from CartTable where Email=@a1 and Foodname=@a2", conn);
                Cartmd.Parameters.AddWithValue("@a1", TextBox1.Text);
                Cartmd.Parameters.AddWithValue("@a2", TextBox3.Text);

                Cartmd.ExecuteNonQuery();

                SqlCommand notimd = new SqlCommand("delete from userNotiTable where Email=@a1 and Foodname=@a2", conn);
                notimd.Parameters.AddWithValue("@a1", TextBox1.Text);
                notimd.Parameters.AddWithValue("@a2", TextBox3.Text);

                notimd.ExecuteNonQuery();

                SqlCommand m = new SqlCommand("delete from DelivaryTable where userEmail=@a1 and FoodName=@a2 and Qty=@a3", conn);
                m.Parameters.AddWithValue("@a1", TextBox1.Text);
                m.Parameters.AddWithValue("@a2", TextBox3.Text);
                m.Parameters.AddWithValue("@a3", TextBox4.Text);
               
                m.ExecuteNonQuery();

                SqlCommand d = new SqlCommand("delete from ShopkeeperrequestTable where userEmail=@a1 and FoodName=@a2 and Qty=@a3", conn);
                d.Parameters.AddWithValue("@a1", TextBox1.Text);
                d.Parameters.AddWithValue("@a2", TextBox3.Text);
                d.Parameters.AddWithValue("@a3", TextBox4.Text);
               
                d.ExecuteNonQuery();
                conn.Close();
            }
        }

       
    }
}