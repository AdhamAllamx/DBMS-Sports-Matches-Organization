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
    public partial class SystemAdmin_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Club_name = Name_Club_addclub_System_admin.Text;
            String Club_location = Location_Club_addclub_System_admin.Text;

            SqlCommand add_club = new SqlCommand("addclub", conn);

            add_club.CommandType = CommandType.StoredProcedure;

            add_club.Parameters.Add(new SqlParameter("@clubname", Club_name));
            add_club.Parameters.Add(new SqlParameter("@location", Club_location));

            conn.Open();

            add_club.ExecuteNonQuery();
            conn.Close();


            Response.Write("Done Adding Club");






        }

        protected void Deleteclub_System_admin_Bitton_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String Club_name = Name_club_Deleteclub_System_admin.Text;
            SqlCommand delete_club = new SqlCommand("deleteclub", conn);

            delete_club.CommandType = CommandType.StoredProcedure;
            delete_club.Parameters.Add(new SqlParameter("@clubname", Club_name));

            conn.Open();

            delete_club.ExecuteNonQuery();
            conn.Close();


            Response.Write("Done Deleting Club");


        }

        protected void AddStadium_System_admin_Button_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Stadium_name = Name_Stadium_AddStadium_System_admin.Text;
            String Stadium_location = Location_Stadium_AddStadium_System_admin.Text;
            String Stadium_capacity = Capacuty_Stadium_AddStadium_System_admin.Text;


            SqlCommand add = new SqlCommand("addStadium", conn);

            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.Add(new SqlParameter("@name", Stadium_name));
            add.Parameters.Add(new SqlParameter("@location", Stadium_location));
            add.Parameters.Add(new SqlParameter("@capacity", Stadium_capacity));

            conn.Open();

            add.ExecuteNonQuery();
            conn.Close();


            Response.Write("Done adding staduim");


        }

        protected void DeleteStadium_System_admin_Button_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String satduim_name = Name_Stadium_DeleteStadium_System_admin.Text;
            SqlCommand add = new SqlCommand("deletestad", conn);

            add.CommandType = CommandType.StoredProcedure;

            add.Parameters.Add(new SqlParameter("@stad_name", satduim_name));

            conn.Open();

            add.ExecuteNonQuery();
            conn.Close();


            Response.Write("Done Deleteing staduim");
        }

        protected void BlockFan_System_admin_button_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String National_ID = Fan_Name_BlockFan_System_admin.Text;

            SqlCommand add = new SqlCommand("blockFan", conn);

            add.CommandType = CommandType.StoredProcedure;

            add.Parameters.Add(new SqlParameter("@national_ID", National_ID));

            conn.Open();

            add.ExecuteNonQuery();
            conn.Close();


            Response.Write("Done Blocking Fan");

        }
    }
}