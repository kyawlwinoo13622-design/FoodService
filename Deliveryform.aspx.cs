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
    public partial class Deliveryform : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            Label8.Visible = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into DeliveryloginTable(Dname,Demail,Dlocation,Dphonenumber,Dpassword) values(@a1,@a2,@a3,@a4,@a5)", conn);
            cmd.Parameters.AddWithValue("@a1", txtname.Text);

            cmd.Parameters.AddWithValue("@a2",txtemail.Text);
            cmd.Parameters.AddWithValue("@a3", DropDownList1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@a4", txtphone.Text);
            cmd.Parameters.AddWithValue("@a5", txtpassword.Text);
             cmd.ExecuteNonQuery();
             conn.Close();
        }
        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtname.Text = " ";
            txtemail.Text = " ";
            txtphone.Text = " ";
            txtpassword.Text = " ";
        }
    }
}