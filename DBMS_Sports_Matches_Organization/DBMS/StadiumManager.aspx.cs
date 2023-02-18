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
    public partial class StadiumManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void StadiumManager_REG_Click1(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Boolean fine = true;

            String name_StadiumManager = StadiumManager_NAME.Text;
            String USERNAME_StadiumManager = StadiumManager_USERNAME.Text;
            String PASSWORD_StadiumManager = StadiumManager_PASSWORD.Text;
            String Stadum_Name_StadiumManager = StadiumManager_Stadum_Name.Text;
            SqlCommand StadiumManager = new SqlCommand("addStadiumManager", conn);

            if (name_StadiumManager.Length == 0)
            {
                Response.Write("Write Name");
                fine = false;
            }
            if (USERNAME_StadiumManager.Length == 0)
            {
                Response.Write("Write UserName");
                fine = false;
            }
            if (PASSWORD_StadiumManager.Length == 0)
            {
                Response.Write("Write Password");
                fine = false;
            }

            if (Stadum_Name_StadiumManager.Length == 0)
            {
                Response.Write("Write Stadium Name");
                fine = false;
            }

            else if (fine)
            {
                StadiumManager.CommandType = CommandType.StoredProcedure;
                StadiumManager.Parameters.Add(new SqlParameter("@manger_name", name_StadiumManager));
                StadiumManager.Parameters.Add(new SqlParameter("@stadium_name", Stadum_Name_StadiumManager));
                StadiumManager.Parameters.Add(new SqlParameter("@user_name", USERNAME_StadiumManager));
                StadiumManager.Parameters.Add(new SqlParameter("@password", PASSWORD_StadiumManager));

                conn.Open();

                StadiumManager.ExecuteNonQuery();
                conn.Close();
                Response.Redirect("~/login.aspx");

            }








        }
    }
}