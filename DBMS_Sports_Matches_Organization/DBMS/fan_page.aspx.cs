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
    public partial class fan_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ViewAllmatches_Fan_Button_Click(object sender, EventArgs e)
        {
            string matchdate = Date_ViewAllmatches_Fan.Text;

            string connStr = WebConfigurationManager.ConnectionStrings["hello"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand matches = new SqlCommand("select * from availableMatchesToAttend (@time)", conn);
            matches.Parameters.Add(new SqlParameter("@time", matchdate));
            matches.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader mread = matches.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while (mread.Read())
            {
                if (matchdate.Length == 0)
                {
                    Console.WriteLine("ENTER A DATE");
                }
                else
                {
                    string host = mread.GetString(mread.GetOrdinal(("club1_name")));
                    string guest = mread.GetString(mread.GetOrdinal(("club2_name")));
                    string stdname = mread.GetString(mread.GetOrdinal(("stadium_name")));
                    string loc = mread.GetString(mread.GetOrdinal(("stadium_location")));

                    Label tttt = new Label();
                    tttt.Text = host + "     " + "vs" + "    " + guest + "        " + stdname + "     " + loc + "<br>";

                    form1.Controls.Add(tttt);
                }

            }


            conn.Close();








        }
    }
}