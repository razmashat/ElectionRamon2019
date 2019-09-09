using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace votes
{
    public partial class VotePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            button5.Visible = Session["Manager"].ToString() == "yes";
        }

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            //((ImageButton)sender).CommandArgument;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Management.aspx");
        }
    }
}