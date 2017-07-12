using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValenciaSustainability
{
    public partial class GridViewAuditsWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Selected Audit ID From GridView
            GridViewRow row = GridView1.SelectedRow;

            String myAuditID = row.Cells[1].Text;

            // TEST
              Response.Write("THIS IS myAuditID " + myAuditID);

            Response.Redirect("~/HomePage.aspx?GridViewAuditID=" + myAuditID);
          
        }
    }
}