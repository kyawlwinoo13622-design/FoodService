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
    public partial class Shopkeeper : System.Web.UI.MasterPage
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(Id) from orderTempTable where Shopname='" + Session["shopKeeperShopname"] + "'", conn);
            int ccount = (int)cmd.ExecuteScalar();
            Label4.Text = ccount.ToString();

            conn.Close();
            Response.Write(Session["email"]);
        }
        protected void btnlogoutd_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("homemaster.aspx");
        }
    }
}