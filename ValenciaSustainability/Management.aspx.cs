using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValenciaSustainability
{
    public partial class Management : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditAuditors.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void ReportsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReportsWebForm.aspx");
        }

        protected void AuditsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GridViewAuditsWebForm.aspx");
        }
    }
}