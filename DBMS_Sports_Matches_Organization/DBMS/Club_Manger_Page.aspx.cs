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
    public partial class Club_Manger_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand stdinfo = new SqlCommand("select * from showstd(@username)", conn);

            stdinfo.Parameters.Add(new SqlParameter("@username", Session["StadiumManager_UserName"]));    //important need to add the session not hoda 
            stdinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = stdinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {
                int id = cread.GetInt32(cread.GetOrdinal(("id")));
                string stdname = cread.GetString(cread.GetOrdinal(("namee")));
                int capacity = cread.GetInt32(cread.GetOrdinal("capacity"));
                bool status = cread.GetBoolean(cread.GetOrdinal("statuss"));
                string loc = cread.GetString(cread.GetOrdinal(("locations")));
                Label1.Text = "<br>" + "Stadium ID:";
                if (status)
                {
                    string satuss = "available";
                    Label1.Text = "<br>" + "Stadium ID:" + id + "     " + "stadium name:" + "    " + stdname + "capacity:" + "    " + capacity + "    " + "Satus:" + satuss + "   " + "location:" + loc + "<br>";
                }
                else
                {
                    string satuss = "Not available";
                    Label1.Text = "<br>" + "Stadium ID:" + id + "     " + "stadium name:" + "    " + stdname + "capacity:" + "    " + capacity + "    " + "Satus:" + satuss + "   " + "location:" + loc + "<br>";
                }





            }
            conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand stdinfo = new SqlCommand("select * from seehisreq (@username)", conn);

            stdinfo.Parameters.Add(new SqlParameter("@username", "fadel"));    //important need to add the session not hoda  Session["StadiumManager_UserName"]
            stdinfo.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader cread = stdinfo.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (cread.Read())
            {

                string ClubRepresentativeName = cread.GetString(cread.GetOrdinal(("ClubRepresentativeName")));

                string host = cread.GetString(cread.GetOrdinal(("hostClubName")));

                string guest = cread.GetString(cread.GetOrdinal(("guestClubName")));
                
                DateTime st = cread.GetDateTime(cread.GetOrdinal(("startTime")));

                DateTime en = cread.GetDateTime(cread.GetOrdinal(("end_time")));

                bool sat = cread.GetBoolean(cread.GetOrdinal(("HR_status")));

                
              
                Label3.Text += "<br>" + "ClubRepresentativeName:" + ClubRepresentativeName + "  " + "Host club:  " + "   " + host + "   " + "Guest club :  " + "  " + guest + "   " + " Start TIME :" + st +
                    "End Time:" + en + "Status:" + sat + "<br>";
            }
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }

        
    
}
