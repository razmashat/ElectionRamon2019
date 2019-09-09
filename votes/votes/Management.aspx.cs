using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace votes
{
    public partial class Management : System.Web.UI.Page
    {
        public static int[] Mandats = new int[31];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Manager"].ToString() != "yes")
            {
                Response.Redirect(@"https://he.wikipedia.org/wiki/%D7%A9%D7%92%D7%99%D7%90%D7%94_404");
            }
            Mandats[0] = 100;
            Mandats[1] = 10;
            Mandats[2] = 1;

        }
    }
}