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
    public partial class marketform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            if (txtname.Text != null || txtemail.Text != null || txtpassword.Text != null || txtshopname.Text != null || txtphonenumber.Text != null || txtlocation.Text != null)
            {
                SqlCommand cmd = new SqlCommand("insert into requestTable(Name,Email,Password,Shopname,PhNumber,Location) values(@e1,@e2,@e3,@e4,@e5,@e6)", conn);
                cmd.Parameters.AddWithValue("@e1", txtname.Text);
                cmd.Parameters.AddWithValue("@e2", txtemail.Text);
                cmd.Parameters.AddWithValue("@e3", txtpassword.Text);
                cmd.Parameters.AddWithValue("@e4", txtshopname.Text);
                cmd.Parameters.AddWithValue("@e5", txtphonenumber.Text);
                cmd.Parameters.AddWithValue("@e6", txtlocation.Text);
                cmd.ExecuteNonQuery();

                
                conn.Close();
                Label1.Visible = true;
            }
            else
            {
                Response.Redirect("homemaster.aspx");
            }
        }
        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtname.Text = " ";
            txtemail.Text = "";
            txtpassword.Text = "";
            txtshopname.Text = " ";
            txtphonenumber.Text = " ";
            txtlocation.Text = " ";
        }
    }
}