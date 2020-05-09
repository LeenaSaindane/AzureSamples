using System;

using System.Collections.Generic;

using System.Configuration;

using System.Data;

using System.Data.SqlClient;

using System.Linq;

using System.Web;

using System.Web.UI;

using System.Web.UI.WebControls;


namespace AzWeb2
{
    public partial class DB : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)

            {

                DisplayRecord();

            }
        }

        public void DisplayRecord()

        {

            string connStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

            con = new SqlConnection(connStr);

            SqlDataAdapter Adp = new SqlDataAdapter("select ename from dbo.emp where empno=1001", con);

            DataTable Dt = new DataTable();

            Adp.Fill(Dt);

            gvEmp.DataSource = Dt;

            gvEmp.DataBind();

            con.Close();



        }
    }
}