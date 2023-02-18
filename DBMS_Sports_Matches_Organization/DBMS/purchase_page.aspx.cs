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
    public partial class purchase_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchase_button_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            string nid = national_ID_text.Text;
            string host = host_text.Text;
            string guest = guest_text.Text;
            string time = time_text.Text;
            SqlCommand pur = new SqlCommand("purchaseTicket", conn);
            pur.CommandType = CommandType.StoredProcedure;
            pur.Parameters.Add(new SqlParameter("@national_ID", nid));
            pur.Parameters.Add(new SqlParameter("@host_name", host));
            pur.Parameters.Add(new SqlParameter("@guest_name", guest));
            pur.Parameters.Add(new SqlParameter("@start", time));


            conn.Open();
            

            pur.ExecuteNonQuery();

            conn.Close();
            Response.Write("Fan Purchased a ticket");
        }

        protected void see_Click(object sender, EventArgs e)
        {
            string matchdate = Date_ViewAllmatches_Fan.Text;
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand tickets = new SqlCommand("select * from availableMatchesToAttend (@time)", conn);
            tickets.Parameters.Add(new SqlParameter("@time", matchdate));
            tickets.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader tread = tickets.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (tread.Read())
            {
                string host = tread.GetString(tread.GetOrdinal(("club1_name")));
                string guest = tread.GetString(tread.GetOrdinal(("club2_name")));
                DateTime strtime = tread.GetDateTime(tread.GetOrdinal(("start_time")));

                Label ttttt = new Label();
                ttttt.Text = "<br>" + "host:" + host + "     " + "Guest:" + "    " + guest + "        " + "Start time:" + strtime + "<br>";

                form1.Controls.Add(ttttt);
            }



            conn.Close();

        }
    }
}