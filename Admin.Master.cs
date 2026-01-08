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
    public partial class Admin : System.Web.UI.MasterPage
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand amd = new SqlCommand("select count(Id) from requestTable", conn);
            int count = (int)amd.ExecuteScalar();
            Label4.Text = count.ToString();

            SqlCommand cmd = new SqlCommand("select count(Id) from ShopkeeperrequestTable where Receive='Yes'", conn);
            int ccount = (int)cmd.ExecuteScalar();
           orderList.Text = ccount.ToString();

            conn.Close();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("update.aspx");
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("homemaster.aspx");
            
        }
    }
}