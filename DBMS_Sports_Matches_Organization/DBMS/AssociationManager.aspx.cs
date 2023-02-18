using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalyarab
{
    public partial class AssociationManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Association_Manager_REG_Click1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Boolean fine = true;

            String name_Association_Manager = Association_Manager_NAME.Text;
            String Username_Association_Manager = Association_Manager_USERNAME.Text;
            String Password_Association_Manager = Association_Manager_PASSWORD.Text;
            SqlCommand AssociationManager = new SqlCommand("addAssociationManager", conn);

            if (name_Association_Manager.Length == 0)
            {
                Response.Write("Write Name");

                fine = false;
            }

            if (Username_Association_Manager.Length == 0)
            {
                Response.Write("Write UserName");
                fine = false;
            }

            if (Password_Association_Manager.Length == 0)
            {
                Response.Write("Write password");
                fine = false;
            }

            else if (fine)
            {
                AssociationManager.CommandType = CommandType.StoredProcedure;
                AssociationManager.Parameters.Add(new SqlParameter("@name", name_Association_Manager));
                AssociationManager.Parameters.Add(new SqlParameter("@username", Username_Association_Manager));
                AssociationManager.Parameters.Add(new SqlParameter("@password", Password_Association_Manager));
                conn.Open();

                AssociationManager.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/login.aspx");
            }






        }
    }
}