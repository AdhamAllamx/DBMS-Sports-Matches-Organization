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
    public partial class login : System.Web.UI.Page
    {
        private object connstr;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void LoginSQL(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            //fanlog--------------------------------------------------------------------------------------------
            String Fan_un = username.Text;
            String fan_pass = Password.Text;
            SqlCommand fanlg = new SqlCommand("fanlogin", conn);
            fanlg.CommandType = CommandType.StoredProcedure;
            fanlg.Parameters.Add(new SqlParameter("@username", Fan_un));
            fanlg.Parameters.Add(new SqlParameter("@password", fan_pass));
            SqlParameter fanboolean = fanlg.Parameters.Add("@boolean", SqlDbType.Int);

            fanboolean.Direction = ParameterDirection.Output;
            conn.Open();

            fanlg.ExecuteNonQuery();

            conn.Close();

            SqlCommand fan_Block = new SqlCommand("fan_Block", conn);
            fan_Block.CommandType = CommandType.StoredProcedure;
            fan_Block.Parameters.Add(new SqlParameter("@username", Fan_un));
            SqlParameter fan_block_b = fan_Block.Parameters.Add("@boolean", SqlDbType.Int);

           

                if (fanboolean.Value.ToString() == "1")
                {
                Session["fan_UserName"] = Fan_un;
                Response.Redirect("~/fanselectfunction.aspx");
                }
                else
                {
                    Response.Write("there no user");
                }
           

            //clubreplog-------------------------------------------------------------------------------------------

            String clubrep_un = username.Text;
            String clubrep_pass = Password.Text;
            SqlCommand clubreplg = new SqlCommand("clubreplogin", conn);
            clubreplg.CommandType = CommandType.StoredProcedure;
            clubreplg.Parameters.Add(new SqlParameter("@username", clubrep_un));
            clubreplg.Parameters.Add(new SqlParameter("@password", clubrep_pass));
            SqlParameter clubrepboolean = clubreplg.Parameters.Add("@boolean", SqlDbType.Int);

            clubrepboolean.Direction = ParameterDirection.Output;
            conn.Open();

            clubreplg.ExecuteNonQuery();

            conn.Close();



            if (clubrepboolean.Value.ToString() == "1")
            {
                Session["cr_UserName"] = clubrep_un;
                Response.Redirect("~/ClubREP_page.aspx");
            }
            else
            {
                Response.Write("there no user");
            }

            //stadiummangerlogin-------------------------------------------------------------------------------------------------------
            String Smang_un = username.Text;
            String Smang_pass = Password.Text;
            SqlCommand Smanglg = new SqlCommand("StadiumManagerlogin", conn);
            Smanglg.CommandType = CommandType.StoredProcedure;
            Smanglg.Parameters.Add(new SqlParameter("@username", Smang_un));
            Smanglg.Parameters.Add(new SqlParameter("@password", Smang_pass));
            SqlParameter Smangboolean = Smanglg.Parameters.Add("@boolean", SqlDbType.Int);

            Smangboolean.Direction = ParameterDirection.Output;
            conn.Open();

            Smanglg.ExecuteNonQuery();

            conn.Close();



            if (Smangboolean.Value.ToString() == "1")
            {
                Session["StadiumManager_UserName"] = Smang_un;
                Response.Redirect("~/Club_Manger_Page.aspx");
            }
            else
            {
                Response.Write("there no user");
            }


            //sytemadmin------------------------------------------------------------------------------------------------------------------------------------

            String admin_un = username.Text;
            String admin_pass = Password.Text;
            SqlCommand adminlg = new SqlCommand("SAlog", conn);
            adminlg.CommandType = CommandType.StoredProcedure;
            adminlg.Parameters.Add(new SqlParameter("@username", Smang_un));
            adminlg.Parameters.Add(new SqlParameter("@password", Smang_pass));
            SqlParameter adminboolean = adminlg.Parameters.Add("@boolean", SqlDbType.Int);

            adminboolean.Direction = ParameterDirection.Output;
            conn.Open();

            adminlg.ExecuteNonQuery();

            conn.Close();



            if (adminboolean.Value.ToString() == "1")
            {
                Session["StadiumManager_UserName"] = Smang_un;
                Response.Redirect("~/SystemAdmin_page.aspx");
            }
            else
            {
                Response.Write("there no user");
            }
            //assoiatManger-----------------------------------------------

            String as_user = username.Text;
            String as_pass = Password.Text;
            SqlCommand as_com = new SqlCommand("Assolog", conn);
            as_com.CommandType = CommandType.StoredProcedure;
            as_com.Parameters.Add(new SqlParameter("@username", as_user));
            as_com.Parameters.Add(new SqlParameter("@password", as_pass));
            SqlParameter boolas = as_com.Parameters.Add("@boolean", SqlDbType.Int);

            boolas.Direction = ParameterDirection.Output;
            conn.Open();

            as_com.ExecuteNonQuery();

            conn.Close();



            if (boolas.Value.ToString() == "1")
            {
                Session["as_UserName"] = as_user;
                Response.Redirect("~/asso_page.aspx");
            }
            else
            {
                Response.Write("there no user");
            }



        }
        protected void samSQL(object sender, EventArgs e)
        {

            Response.Redirect("/AssociationManager/AssociationManager.aspx");
        }

        protected void crSQL(object sender, EventArgs e)
        {
            Response.Redirect("~/ClubRepresentative/ClubRepresentative.aspx");
        }

        protected void smSQL(object sender, EventArgs e)
        {
            Response.Redirect("~/StadiumManager/StadiumManager.aspx");

        }

        protected void fanSQL(object sender, EventArgs e)
        {
            Response.Redirect("~/fanpage/fan.aspx");
        }


        protected void registerSQL(object sender, EventArgs e)
        {
            Response.Redirect("~/Youare.aspx");


        }

        protected void Unnamed3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}