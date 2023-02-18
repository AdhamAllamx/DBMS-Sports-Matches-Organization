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
    public partial class fan : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Fan_regester_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Boolean fine = true;
            String Fan_name = Fan_Name.Text;
            String user_name = Fan_UserName.Text;
            String password = Fan_password.Text;
            String national_ID = Fan_National_ID.Text;
            int phone_no = (int)Int64.Parse(Fan_Phone_number.Text);
            String birth_date = Fan_Birth_date.Text;
            String address = Fan_Address.Text;


            SqlCommand regfan = new SqlCommand("addFan", conn);
            if (Fan_name.Length == 0)
            {
                Response.Write("Write Name" + "/n");
                fine = false;
            }
            if (user_name.Length == 0)
            {
                Response.Write("Write UserName");
                fine = false;
            }
            if (password.Length == 0)
            {
                Response.Write("Write password");
                fine = false;
            }
            if (national_ID.Length == 0)
            {
                Response.Write("Write National ID");
                fine = false;
            }
            if (Fan_Phone_number.Text.Length == 0)
            {
                Response.Write("Write phone number");
                fine = false;
            }
            if (birth_date.Length == 0)
            {
                Response.Write("Write BirthDay");
                fine = false;
            }

            if (address.Length == 0)
            {
                Response.Write("Write address");
                fine = false;
            }
            else if (fine)
            {
                regfan.CommandType = CommandType.StoredProcedure;
                regfan.Parameters.Add(new SqlParameter("@fan_name", Fan_name));
                regfan.Parameters.Add(new SqlParameter("@user_name", user_name));
                regfan.Parameters.Add(new SqlParameter("@password", password));
                regfan.Parameters.Add(new SqlParameter("@national_ID", national_ID));
                regfan.Parameters.Add(new SqlParameter("@birth_date", birth_date));
                regfan.Parameters.Add(new SqlParameter("@address", address));
                regfan.Parameters.Add(new SqlParameter("@phone_no", phone_no));

                conn.Open();

                regfan.ExecuteNonQuery();
                conn.Close();

                Response.Redirect("~/login.aspx");
            }





















        }
    }
}