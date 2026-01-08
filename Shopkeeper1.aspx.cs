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
    public partial class Shopkeeper1 : System.Web.UI.Page
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string c;
        string d;
        string f;
        protected void btninsert_Click(object sender, EventArgs e)
        {
            
            conn.Open();
             SqlCommand smd = new SqlCommand("select * from ShopkeeperTable where Email='"+Session["email"]+"' ", conn);
             SqlDataReader dd = smd.ExecuteReader();
             if (dd.Read())
             {
                 c=dd["Shopname"].ToString();
                 d =dd["Location"].ToString();
                 f =dd["PhNumber"].ToString();
                 dd.Close();
             }

             

            SqlCommand cmd = new SqlCommand("insert into OpenandcloseTable(Email,Shopname,S,E,Location,PhNumber) values(@a1,@a2,@a3,@a4,@a5,@a6)", conn);
            cmd.Parameters.AddWithValue("@a1", Session["email"]);
           
            cmd.Parameters.AddWithValue("@a2", c);
                
            cmd.Parameters.AddWithValue("@a3", txt1.Text);
            cmd.Parameters.AddWithValue("@a4", txt2.Text);
            cmd.Parameters.AddWithValue("@a5", d);
            cmd.Parameters.AddWithValue("@a6", f);

                
            
            cmd.ExecuteNonQuery();
            Label8.Visible = true;
            conn.Close();
        }
        protected void btncancel_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
        }
    }
}