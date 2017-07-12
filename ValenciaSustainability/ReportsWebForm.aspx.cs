using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValenciaSustainability
{
    public partial class ReportsWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( !Page.IsPostBack )
            {
                
            }
        }

        protected void AHUReportsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AuditReportAHUWebForm.aspx");
        }

        protected void TemperatureButton_Click(object sender, EventArgs e)
        {

        }

        protected void LabRoomButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LabRoomReports.aspx");
        }

        protected void MarqueeReportsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MarqueeWebForm.aspx");
        }

        protected void ParkingLightsReportButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ParkingLightsReportsWebForm.aspx");
        }

        protected void TempButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TempReportsWebForm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysAuditReportsWebForm.aspx");
        }

        protected void AuditReportsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AuditReportsWebForm.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysAHUAuditReport.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysLabRoomReportWebForm.aspx");
        }

        protected void TodaysKitchenReportButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysKitchenReportWebForm.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysParkingLightsReportWebForm.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysMarqueeReportWebForm.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TodaysTempReportWebForm.aspx");
        }

        protected void KitchenReportsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/KitchenAuditReportsWebForm.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
             Response.Redirect("~/ImageReportWebForm.aspx");
        }
    }
}