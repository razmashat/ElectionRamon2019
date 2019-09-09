using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace votes
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] arr = new string[7]; 
            Session["Manager"] = "no";
            if (Request.Form["submit"] != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Request.Form["tz"].ToString() == arr[i])
                    {
                        Session["Manager"] = "yes";
                    }
                }
                Response.Redirect("VotePage.aspx");
            }
            //if (/*פה נכנס הדאל*/)
            //{
            //    Response.Redirect("VotePage.aspx");
            //}

        }

    }
}