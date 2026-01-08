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
    public partial class AdminNo : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            SqlDataAdapter dt = new SqlDataAdapter("select * from OrderTable where Receive='No'", conn);
            DataSet ds = new DataSet();
            dt.Fill(ds, "p");
            conn.Close();
            DataTable da = new DataTable();
            dt.Fill(da);
            dt.Update(ds, "p");
            GridView1.DataSource = da;
            GridView1.DataBind();

            conn.Close();
        }
    }
}