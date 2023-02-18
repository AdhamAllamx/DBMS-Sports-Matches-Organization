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
    public partial class ClubRepresentative : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void club_representative_regester_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            Boolean fine = true;
            String Name_representative = club_representative_Name.Text;
            String username_representative = club_representative_UserName.Text;
            String password_representative = club_representative_password.Text;
            String Club_Name_representative = club_representative_Club_Name.Text;
            SqlCommand regrepresentative = new SqlCommand("addRepresentative", conn);

            if (username_representative.Length == 0)
            {
                Response.Write("Write UserName");
                fine = false;
            }
            if (Name_representative.Length == 0)
            {
                Response.Write("Write Name");
                fine = false;
            }
            if (password_representative.Length == 0)
            {
                Response.Write("Write Password");
                fine = false;
            }
            if (password_representative.Length == 0)
            {
                Response.Write("Write Password");
                fine = false;
            }
            if (Club_Name_representative.Length == 0)
            {
                Response.Write("Write Club Name");
                fine = false;
            }
            else if (fine)
            {
                regrepresentative.CommandType = CommandType.StoredProcedure;
                regrepresentative.Parameters.Add(new SqlParameter("@name", Name_representative));
                regrepresentative.Parameters.Add(new SqlParameter("@club_name", Club_Name_representative));
                regrepresentative.Parameters.Add(new SqlParameter("@user_name", username_representative));
                regrepresentative.Parameters.Add(new SqlParameter("@password", password_representative));

                conn.Open();

                regrepresentative.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/login.aspx");

            }





        }
    }
}