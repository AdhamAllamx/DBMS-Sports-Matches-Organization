using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalyarab
{
    public partial class Youare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void samSQL(object sender, EventArgs e)
        {

            Response.Redirect("AssociationManager.aspx");
        }

        protected void crSQL(object sender, EventArgs e)
        {
            Response.Redirect("ClubRepresentative.aspx");
        }

        protected void smSQL(object sender, EventArgs e)
        {
            Response.Redirect("StadiumManager.aspx");

        }

        protected void fanSQL(object sender, EventArgs e)
        {
            Response.Redirect("fan.aspx");
        }
    }
}