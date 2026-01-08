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
    public partial class delete : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string b=TextBox1.Text.ToString();
            SqlCommand cmd = new SqlCommand("delete from ShopkeeperTable where Email='"+ b +"'",conn);
            cmd.ExecuteNonQuery();

            SqlCommand fmd = new SqlCommand("delete from LoginTable where Email='" + b + "'", conn);
            fmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}