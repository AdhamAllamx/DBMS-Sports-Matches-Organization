using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalyarab
{
    public partial class asso_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Label5.Text = " ";
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand stdinfo = new SqlCommand("select * from allMatches", conn);
            stdinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = stdinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {
               
                string host = cread.GetString(cread.GetOrdinal(("HostClub")));
                string guest = cread.GetString(cread.GetOrdinal(("GuestClub")));
                DateTime timee = cread.GetDateTime(cread.GetOrdinal(("st")));



                Label5.Text += "<br>" + "Host:" + host + "  " + "Guest:  " + "   " + guest + "   " + "Start time :  " + "  " + timee + "<br>";
            }
            conn.Close();
        }
        protected void ADDMatch_Associationmanger_Button_Click(object sender, EventArgs e)
        {
            string host = Host_Club_name_ADDMatch_Associationmanger.Text;
            string guest = Guest_Club_name_ADDMatch_Associationmanger.Text;
            DateTime start = DateTime.Parse(Start_Time_ADDMatch_Associationmanger.Text);
            DateTime end = DateTime.Parse(TextBox1.Text);



            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addm = new SqlCommand("addNewMatch", conn);
            addm.CommandType = CommandType.StoredProcedure;
            addm.Parameters.Add(new SqlParameter("@hostclub", host));
            addm.Parameters.Add(new SqlParameter("@guestclub", guest));
            addm.Parameters.Add(new SqlParameter("@start_time", start));
            addm.Parameters.Add(new SqlParameter("@end_time", end));

            conn.Open();

            addm.ExecuteNonQuery();

            conn.Close();

            Response.Write("New Match Added");


        }

        protected void DeleteMatch_Associationmanger_Button_Click(object sender, EventArgs e)
        {
            string host = Host_Club_name_DeleteMatch_Associationmanger.Text;
            string guest = Guest_Club_name_DeleteMatch_Associationmanger.Text;
            DateTime start = DateTime.Parse(Start_Time_DeleteMatch_Associationmanger.Text);
            DateTime end = DateTime.Parse(End_Time_DeleteMatch_Associationmanger.Text);



            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addm = new SqlCommand("deleteMatch2", conn);
            addm.CommandType = CommandType.StoredProcedure;
            addm.Parameters.Add(new SqlParameter("@hostclub", host));
            addm.Parameters.Add(new SqlParameter("@guestclub", guest));
            addm.Parameters.Add(new SqlParameter("@start", start));
            addm.Parameters.Add(new SqlParameter("@end", end));

            conn.Open();

            addm.ExecuteNonQuery();

            conn.Close();

            Response.Write("Match Deleted");

        }

        protected void View_UpcomingMatches_Associationmanger_button_Click(object sender, EventArgs e)
        {
            Label1.Text = " ";
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand stdinfo = new SqlCommand("select * from upcomeing", conn);
            stdinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = stdinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {

                string host = cread.GetString(cread.GetOrdinal(("host")));
                string guest = cread.GetString(cread.GetOrdinal(("guest")));
                DateTime st = cread.GetDateTime(cread.GetOrdinal(("start_time")));

                DateTime en = cread.GetDateTime(cread.GetOrdinal(("end_time")));


                Label1.Text += "<br>" + "Host:" + host + "  " + "Guest:  " + "   " + guest + "   " + "Start time :  " + "  " + st + "   " + " END TIME :" + en + "<br>";

            }
            conn.Close();

        }

        protected void AlreadyPlayedMatches_Associationmanger_Button_Click(object sender, EventArgs e)
        {
            Label2.Text = "";
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand stdinfo = new SqlCommand("select * from Donematch", conn);
            stdinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = stdinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {

                string host = cread.GetString(cread.GetOrdinal(("host")));
                string guest = cread.GetString(cread.GetOrdinal(("guest")));
                DateTime st = cread.GetDateTime(cread.GetOrdinal(("start_time")));

                DateTime en = cread.GetDateTime(cread.GetOrdinal(("end_time")));


                Label2.Text += "<br>" + "Host:" + host + "  " + "Guest:  " + "   " + guest + "   " + "Start time :  " + "  " + st + "   " + " END TIME :" + en + "<br>";
               
            }
            conn.Close();

        }

        protected void NeverPlayedTogether_Associationmanger_button_Click(object sender, EventArgs e)
        {
            Label3.Text = "";
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand stdinfo = new SqlCommand("select * from clubsNeverMatched", conn);
            stdinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = stdinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {

                string host = cread.GetString(cread.GetOrdinal(("firstclub_name")));
                string guest = cread.GetString(cread.GetOrdinal(("secondclub_name")));



                Label3.Text += "<br>" + "Club 1:" + host + "  " + "Club 2:  " + "   " + guest + "<br>";

            }
            conn.Close();


        }
    }
}