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
    public partial class ClubREP_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Upcoming_matches_Club_rep_Button_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);





            SqlCommand upom = new SqlCommand("select * from upcomingMatchesOfClub2(@username)", conn);

            upom.Parameters.Add(new SqlParameter("@username", Session["cr_UserName"]));    //important need to add the session not hoda 
            upom.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader uread = upom.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (uread.Read())
            {

                string host = uread.GetString(uread.GetOrdinal(("givenClub")));
                string guest = uread.GetString(uread.GetOrdinal(("CompetingClub")));
                DateTime StartTime = uread.GetDateTime(uread.GetOrdinal(("StartTime")));
                string StadiumName = uread.GetString(uread.GetOrdinal(("StadiumName")));

                upcomingM.Text = "<br>" + "Host:" + host + "   " + "Guest:" + guest + "   " + "StadiumName:" + StadiumName + "   " + "StartTime:" + StartTime;
                
            }
            conn.Close();


        }

        protected void Club_info_Club_rep_Button_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand clubinfo = new SqlCommand("select * from showclubb(@username)", conn);

            clubinfo.Parameters.Add(new SqlParameter("@username", Session["cr_UserName"]));    //important need to add the session not hoda 
            clubinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = clubinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {
                int id = cread.GetInt32(cread.GetOrdinal(("id")));
                string club = cread.GetString(cread.GetOrdinal(("club")));
                string loc = cread.GetString(cread.GetOrdinal(("locationc")));


                myclub.Text = "<br>" + "clubid:" + id + "     " + "club:" + "    " + club + "        " + "location:" + loc + "<br>";

                
            }
            conn.Close();

        }

        protected void available_Stadium_Button_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(Date_available_Stadiums_Club_rep.Text);

            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand avstd = new SqlCommand("select * from viewAvailableStadiumsOn2(@time)", conn);

            avstd.Parameters.Add(new SqlParameter("@time", time));    //important need to add the session not hoda 
            avstd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = avstd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {
                string stadiumname = cread.GetString(cread.GetOrdinal(("name")));
                int capacity = cread.GetInt32(cread.GetOrdinal(("capacity")));
                string loc = cread.GetString(cread.GetOrdinal(("locations")));


                availbe_stadium.Text = "<br>" + "stadiumname:" + stadiumname + "     " + "capacity:" + "    " + capacity + "        " + "locations:" + loc + "<br>";


            }
            conn.Close();
        }

        protected void Send_Club_rep_Button_Click(object sender, EventArgs e)
        {
            string stdn = Send_stadium_name_Club_rep.Text;
            DateTime time = DateTime.Parse(Send_Date_Club_rep.Text);
            string time2 = time.ToString();

            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand req = new SqlCommand("addHostRequest2", conn);
            req.CommandType = CommandType.StoredProcedure;
            req.Parameters.Add(new SqlParameter("@username", Session["cr_UserName"]));
            req.Parameters.Add(new SqlParameter("@stadiumName", stdn));
            req.Parameters.Add(new SqlParameter("@date", time));
            req.CommandType = CommandType.StoredProcedure;
           
            conn.Open();
            Label1.Text = "Club Repsentive has sended a request";

            req.ExecuteNonQuery();

            conn.Close();


        }
    }
}