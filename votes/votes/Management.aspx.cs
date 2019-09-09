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
            Mandats[0] = 100;
            Mandats[1] = 10;
            Mandats[2] = 1;

        }
    }
}