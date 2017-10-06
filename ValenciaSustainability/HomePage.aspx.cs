using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

//October 4rth 2017. This is a new version of my program!

namespace ValenciaSustainability
{

    public partial class HomePage : System.Web.UI.Page
    {
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ValenciaLocalDBConnectionString"].ConnectionString);

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ValenciaLocalDBConnectionString"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // GET AUDIT ID FROM SELECTED GRIDVIEW
                String homePageAuditID;
                homePageAuditID = "";

                homePageAuditID = Request.QueryString["GridViewAuditID"];
                // TEST
                // Response.Write("THIS IS homePageAuditID " + homePageAuditID);

                Calendar1.SelectedDate = DateTime.Today;

                //// Load controls with all choices
                LoadAuditors();
                LoadCampuses();
                LoadBuildings();
                LoadLabRooms();
                LoadLots();
                LoadAuditTypes();
                LoadSprinklerZones();
                LoadComputersOn();
                LoadProjectorsOn();
                LoadTvsOn();
                LoadParkingLightsOn();

                // Select Records Based On Selected AuditID in GridView
                // Select One Record From Database and load into DropDownLists
                SelectAuditorNameFromAuditRecord2();
                SelectCampusFromAuditRecord2();
                SelectBuildingFromAuditRecord2();
                SelectRoomNumberFromAuditRecord2();
                SelectAuditTypeFromAuditRecord2();
                SelectComputersOnFromAuditRecord2();
                SelectTvsOnFromAuditRecord2();
                SelectProjectorsOnFromAuditRecord2();
                SelectLightsOnFromAuditRecord2();
                SelectParkingLotFromAuditRecord2();
                SelectSprinklerZoneFromAuditRecord2();
                SelectDateFromAuditRecord2();
                SelectDateFromAuditRecord2();


                // Select One Record From Database and load into CheckBoxLists
                SelectCheckBoxListsFromAuditRecord2();

                // Select One Record From Database and load into TextBox's
                SelectKitchenTextBoxValueFromAuditRecord2();
                SelectTempTextBoxValueFromAuditRecord2();
                SelectIrrigationTextBoxValueFromAuditRecord2();
                SelectAhuTextBoxValueFromAuditRecord2();
                SelectParkingLightsTextBoxValueFromAuditRecord2();
                SelectLabTextBoxValueFromAuditRecord2();
                SelectMarqueeTextBoxValueFromAuditRecord2();
                SelectOtherTextBoxValueFromAuditRecord2();
                SelectEnergyCostTextBoxValueFromAuditRecord2();

            }
        }

        // Select Kitchen Text Box Value from Database Based on AuditID When Record Selected From GridView. 
        public void SelectKitchenTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter KitchenDa;
            DataSet KitchenDs = new DataSet();
            string KitchenQuery;

            string KitchenQueryInput = "null";

            KitchenQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                KitchenQuery = "Select KitchenNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                KitchenQueryInput = Request.QueryString["GridViewAuditID"];

                KitchenDa = new SqlDataAdapter(KitchenQuery, con);

                KitchenDa.Fill(KitchenDs);

                var KitchenDt = KitchenDs.Tables[0];

                var kitchenText = (String)KitchenDt.Rows[0]["KitchenNotes"];

                KitchenTextBox.Text = kitchenText;

            }
        }

        // Select Temp Text Box Value from Database Based on AuditID When Record Selected From GridView.  
        public void SelectTempTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter TempDa;
            DataSet TempDs = new DataSet();
            string TempQuery;

            string TempQueryInput = "null";

            TempQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                TempQuery = "Select TemperatureNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                TempQueryInput = Request.QueryString["GridViewAuditID"];

                TempDa = new SqlDataAdapter(TempQuery, con);

                TempDa.Fill(TempDs);

                var TempDt = TempDs.Tables[0];

                var TempText = (String)TempDt.Rows[0]["TemperatureNotes"];

                TempTextBox.Text = TempText;

            }
        }

        // Select Irrigation Text Box Value from Database  Based on AuditID When Record Selected From GridView. 
        public void SelectIrrigationTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter IrrigationDa;
            DataSet IrrigationDs = new DataSet();
            string IrrigationQuery;

            string IrrigationQueryInput = "null";

            IrrigationQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                IrrigationQuery = "Select IrrigationNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                IrrigationQueryInput = Request.QueryString["GridViewAuditID"];

                IrrigationDa = new SqlDataAdapter(IrrigationQuery, con);

                IrrigationDa.Fill(IrrigationDs);

                var IrrigationDt = IrrigationDs.Tables[0];

                var IrrigationText = (String)IrrigationDt.Rows[0]["IrrigationNotes"];

                IrrigationTextBox.Text = IrrigationText;

            }
        }

        // Select Date Calendar Value from Audit Table in Database Based on AuditID When Record Selected From GridView. 
        public void SelectDateFromAuditRecord2()
        {

            SqlDataAdapter DateDa;
            DataSet DateDs = new DataSet();
            string DateQuery;

            string DateQueryInput = "null";

            DateQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                DateQuery = "Select AuditDate from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                DateQueryInput = Request.QueryString["GridViewAuditID"];

                DateDa = new SqlDataAdapter(DateQuery, con);

                DateDa.Fill(DateDs);

                var DateDt = DateDs.Tables[0];

                var DateText = DateDt.Rows[0]["AuditDate"];

                DateTime Date = Convert.ToDateTime(DateText);

                Calendar1.SelectedDate = Date;

            }
        }

        // Select AHU Text Box Value from Database and load into AHU TextBox Based on AuditID When Record Selected From GridView. 
        public void SelectParkingLightsTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter AhuDa;
            DataSet AhuDs = new DataSet();
            string AhuQuery = "";

            string AhuQueryInput = "";

            AhuQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                AhuQuery = "Select AHUNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                AhuQueryInput = Request.QueryString["GridViewAuditID"];

                AhuDa = new SqlDataAdapter(AhuQuery, con);

                AhuDa.Fill(AhuDs);

                var AhuDt = AhuDs.Tables[0];

                var AhuText = (String)AhuDt.Rows[0]["AHUNotes"];

                AHUTextBox.Text = AhuText;

            }
        }

        // Select ParkingLightsTextBoxValue from Database and load into ParkingLightsTextBox Based on AuditID When Record Selected From GridView. 
        public void SelectAhuTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter ParkingLotLightsDa;
            DataSet ParkingLotLightsDs = new DataSet();
            string ParkingLotLightsQuery = "";

            string ParkingLotLightsQueryInput = "";

            ParkingLotLightsQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                ParkingLotLightsQuery = "Select ParkingLightsNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                ParkingLotLightsQueryInput = Request.QueryString["GridViewAuditID"];

                ParkingLotLightsDa = new SqlDataAdapter(ParkingLotLightsQuery, con);

                ParkingLotLightsDa.Fill(ParkingLotLightsDs);

                var ParkingLotLightsDt = ParkingLotLightsDs.Tables[0];

                var ParkingLotLightsText = (String)ParkingLotLightsDt.Rows[0]["ParkingLightsNotes"];

                ParkingLightsTextBox.Text = ParkingLotLightsText;

            }
        }

        // Select ComputerLabTextBoxValue from Database and load into ComputerLabTextBox Based on AuditID When Record Selected From GridView. 
        public void SelectLabTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter LabDa;
            DataSet LabDs = new DataSet();
            string LabQuery = "";

            string LabQueryInput = "";

            LabQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                LabQuery = "Select ComputerLabNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                LabQueryInput = Request.QueryString["GridViewAuditID"];

                LabDa = new SqlDataAdapter(LabQuery, con);

                LabDa.Fill(LabDs);

                var LabDt = LabDs.Tables[0];

                var LabText = (String)LabDt.Rows[0]["ComputerLabNotes"];

                LabTextBox.Text = LabText;

            }
        }

        // Select MarqueeTextBoxValue from Database and load into MarqueeTextBox Based on AuditID When Record Selected From GridView. 
        public void SelectMarqueeTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter MarqueeDa;
            DataSet MarqueeDs = new DataSet();
            string MarqueeQuery = "";

            string MarqueeQueryInput = "";

            MarqueeQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                MarqueeQuery = "Select MarqueeNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                MarqueeQueryInput = Request.QueryString["GridViewAuditID"];

                MarqueeDa = new SqlDataAdapter(MarqueeQuery, con);

                MarqueeDa.Fill(MarqueeDs);

                var MarqueeDt = MarqueeDs.Tables[0];

                var MarqueeText = (String)MarqueeDt.Rows[0]["MarqueeNotes"];

                MarqueeTextBox.Text = MarqueeText;

            }
        }

        // Select OtherTextBoxValue from Database and load into OtherTextBox Based on AuditID When Record Selected From GridView. 
        public void SelectOtherTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter OtherDa;
            DataSet OtherDs = new DataSet();
            string OtherQuery = "";

            string OtherQueryInput = "";

            OtherQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                OtherQuery = "Select OtherNotes from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                OtherQueryInput = Request.QueryString["GridViewAuditID"];

                OtherDa = new SqlDataAdapter(OtherQuery, con);

                OtherDa.Fill(OtherDs);

                var OtherDt = OtherDs.Tables[0];

                var OtherText = (String)OtherDt.Rows[0]["OtherNotes"];

                OtherTextBox.Text = OtherText;

            }
        }

        // Select EnergyCostTextBoxValue from Database and load into EnergyCostTextBox Based on AuditID When Record Selected From GridView. 
        public void SelectEnergyCostTextBoxValueFromAuditRecord2()
        {

            SqlDataAdapter EnergyCostDa;
            DataSet EnergyCostDs = new DataSet();
            string EnergyQuery = "";

            string EnergyQueryInput = "";

            EnergyQueryInput = Request.QueryString["GridViewAuditID"];

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {
                EnergyQuery = "Select EnergyUsed from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                EnergyQueryInput = Request.QueryString["GridViewAuditID"];

                EnergyCostDa = new SqlDataAdapter(EnergyQuery, con);

                EnergyCostDa.Fill(EnergyCostDs);

                var EnergyCostDt = EnergyCostDs.Tables[0];

                var EnergyCostText = (String)EnergyCostDt.Rows[0]["EnergyUsed"];

                EnergyCostTextBox.Text = EnergyCostText;

            }
        }

        // Select AuditorName from record based on AuditorID in Audit table Based on AuditID When Record Selected From GridView. 
        public void SelectAuditorNameFromAuditRecord2()
        {
            SqlDataAdapter AuditorDa;
            SqlDataAdapter AuditorDaOneValue;
            DataSet AuditorDs = new DataSet();
            DataSet AuditorDsOneValue = new DataSet();
            string AuditorQuery;
            string AuditorQueryOneValue;

            AuditorQuery = "";
            AuditorQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                AuditorQueryOneValue = "Select AuditorID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                AuditorQuery = "Select * from Auditor";

                AuditorDa = new SqlDataAdapter(AuditorQuery, con);
                AuditorDaOneValue = new SqlDataAdapter(AuditorQueryOneValue, con);

                AuditorDa.Fill(AuditorDs);
                AuditorDaOneValue.Fill(AuditorDsOneValue);

                if (AuditorDs.Tables[0].Rows.Count > 0)
                {
                    NameDropDownList.DataSource = AuditorDs;
                    NameDropDownList.DataTextField = "AuditorFirstName";
                    NameDropDownList.DataValueField = "AuditorID";
                    NameDropDownList.DataBind();
                }

                var auditNameFromDb = AuditorDsOneValue.Tables[0].Rows[0]["AuditorID"].ToString();

                NameDropDownList.SelectedValue = auditNameFromDb;

            }
        }

        // Select Campus From Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectCampusFromAuditRecord2()
        {
            SqlDataAdapter CampusDa;
            SqlDataAdapter CampusDaOneValue;
            DataSet CampusDs = new DataSet();
            DataSet CampusDsOneValue = new DataSet();
            string CampusQuery;
            string CampusQueryOneValue;

            CampusQuery = "";
            CampusQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                CampusQueryOneValue = "Select CampusID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                CampusQuery = "Select * from Campus";

                CampusDa = new SqlDataAdapter(CampusQuery, con);
                CampusDaOneValue = new SqlDataAdapter(CampusQueryOneValue, con);

                CampusDa.Fill(CampusDs);
                CampusDaOneValue.Fill(CampusDsOneValue);

                if (CampusDs.Tables[0].Rows.Count > 0)
                {
                    RoomListBox.DataSource = CampusDs;
                    RoomListBox.DataTextField = "CampusName";
                    RoomListBox.DataValueField = "CampusID";
                    RoomListBox.DataBind();
                }

                var roomFromDb = CampusDsOneValue.Tables[0].Rows[0]["CampusID"].ToString();


                CampusDropDownList.SelectedValue = roomFromDb;

            }
        }

        // Select Building from record in Audit table Based on AuditID When Record Selected From GridView. 

        public void SelectBuildingFromAuditRecord2()
        {
            SqlDataAdapter BuildingDa;
            SqlDataAdapter BuildingDaOneValue;
            DataSet BuildingDs = new DataSet();
            DataSet BuildingDsOneValue = new DataSet();
            string BuildingQuery;
            string BuildingQueryOneValue;

            BuildingQuery = "";
            BuildingQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                BuildingQueryOneValue = "Select BuildingID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                BuildingQuery = "Select * from Building";

                BuildingDa = new SqlDataAdapter(BuildingQuery, con);
                BuildingDaOneValue = new SqlDataAdapter(BuildingQueryOneValue, con);

                BuildingDa.Fill(BuildingDs);
                BuildingDaOneValue.Fill(BuildingDsOneValue);

                if (BuildingDs.Tables[0].Rows.Count > 0)
                {
                    RoomListBox.DataSource = BuildingDs;
                    RoomListBox.DataTextField = "BuildingNumber";
                    RoomListBox.DataValueField = "BuildingID";
                    RoomListBox.DataBind();
                }

                var roomFromDb = BuildingDsOneValue.Tables[0].Rows[0]["BuildingID"].ToString();


                BuildingDropDownList.SelectedValue = roomFromDb;
            }
        }

        // Select Room Number From Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectRoomNumberFromAuditRecord2()
        {
            SqlDataAdapter RoomDa;
            SqlDataAdapter RoomDaOneValue;
            DataSet RoomDs = new DataSet();
            DataSet RoomDsOneValue = new DataSet();
            string RoomQuery;
            string RoomQueryOneValue;

            RoomQuery = "";
            RoomQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                RoomQueryOneValue = "Select RoomID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                RoomQuery = "Select * from Room";

                RoomDa = new SqlDataAdapter(RoomQuery, con);
                RoomDaOneValue = new SqlDataAdapter(RoomQueryOneValue, con);

                RoomDa.Fill(RoomDs);
                RoomDaOneValue.Fill(RoomDsOneValue);

                if (RoomDs.Tables[0].Rows.Count > 0)
                {
                    RoomListBox.DataSource = RoomDs;
                    RoomListBox.DataTextField = "RoomNumber";
                    RoomListBox.DataValueField = "RoomID";
                    RoomListBox.DataBind();
                }

                var roomFromDb = RoomDsOneValue.Tables[0].Rows[0]["RoomID"].ToString();


                RoomListBox.SelectedValue = roomFromDb;
            }
        }

        public void SelectParkingLotFromAuditRecord2()
        {
            SqlDataAdapter ParkingLotDa;
            SqlDataAdapter ParkingDaOneValue;
            DataSet ParkingDs = new DataSet();
            DataSet ParkingDsOneValue = new DataSet();

            string ParkingQuery;
            string ParkingQueryOneValue;

            string get_campusid;
            get_campusid = CampusDropDownList.SelectedValue.ToString();


            ParkingQuery = "";
            ParkingQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                ParkingQueryOneValue = "Select ParkingLotID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                ParkingQuery = "Select * from ParkingLot";

                ParkingLotDa = new SqlDataAdapter(ParkingQuery, con);
                ParkingDaOneValue = new SqlDataAdapter(ParkingQueryOneValue, con);

                ParkingLotDa.Fill(ParkingDs);
                ParkingDaOneValue.Fill(ParkingDsOneValue);

                if (ParkingDs.Tables[0].Rows.Count > 0)
                {
                    ZoneDropDownList.DataSource = ParkingDs;
                    ZoneDropDownList.DataTextField = "LotName";
                    ZoneDropDownList.DataValueField = "ParkingLotID";
                    ZoneDropDownList.DataBind();
                }

                var lotFromDb = ParkingDsOneValue.Tables[0].Rows[0]["ParkingLotID"].ToString();

                ParkingLotDropDownList.SelectedValue = lotFromDb;

            }
        }

        // Select SprinklerZone from Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectSprinklerZoneFromAuditRecord2()
        {
            SqlDataAdapter SprinklerDa;
            SqlDataAdapter SprinklerDaOneValue;
            DataSet SprinklerDs = new DataSet();
            DataSet SprinklerDsOneValue = new DataSet();
            string SprinklerQuery;
            string SprinklerQueryOneValue;

            SprinklerQuery = "";
            SprinklerQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                SprinklerQueryOneValue = "Select ZoneID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                SprinklerQuery = "Select * from SprinklerZone";

                SprinklerDa = new SqlDataAdapter(SprinklerQuery, con);
                SprinklerDaOneValue = new SqlDataAdapter(SprinklerQueryOneValue, con);

                SprinklerDa.Fill(SprinklerDs);
                SprinklerDaOneValue.Fill(SprinklerDsOneValue);

                if (SprinklerDs.Tables[0].Rows.Count > 0)
                {

                    ZoneDropDownList.DataSource = SprinklerDs;
                    ZoneDropDownList.DataTextField = "Zone";
                    ZoneDropDownList.DataValueField = "ZoneID";
                    ZoneDropDownList.DataBind();

                }

                var zoneFromDb = SprinklerDsOneValue.Tables[0].Rows[0]["ZoneID"].ToString();

                ZoneDropDownList.SelectedValue = zoneFromDb;

            }

        }

        // Select AuditType from Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectAuditTypeFromAuditRecord2()
        {
            SqlDataAdapter AuditTypeDa;
            SqlDataAdapter AuditTypeDaOneValue;
            DataSet AuditTypeDs = new DataSet();
            DataSet AuditTypeDsOneValue = new DataSet();
            string AuditTypeQuery;
            string AuditTypeQueryOneValue;

            AuditTypeQuery = "";
            AuditTypeQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                AuditTypeQueryOneValue = "Select AuditTypeID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                AuditTypeQuery = "Select * from AuditType";

                AuditTypeDa = new SqlDataAdapter(AuditTypeQuery, con);
                AuditTypeDaOneValue = new SqlDataAdapter(AuditTypeQueryOneValue, con);

                AuditTypeDa.Fill(AuditTypeDs);
                AuditTypeDaOneValue.Fill(AuditTypeDsOneValue);

                if (AuditTypeDs.Tables[0].Rows.Count > 0)
                {
                    AuditDropDownList.DataSource = AuditTypeDs;
                    AuditDropDownList.DataTextField = "AuditType";
                    AuditDropDownList.DataValueField = "AuditTypeID";
                    AuditDropDownList.DataBind();
                }

                var auditTypeFromDb = AuditTypeDsOneValue.Tables[0].Rows[0]["AuditTypeID"].ToString();


                AuditDropDownList.SelectedValue = auditTypeFromDb;
            }
        }

        // Select ComputersOn from Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectComputersOnFromAuditRecord2()
        {
            SqlDataAdapter CompOnDa;
            SqlDataAdapter CompOnDaOneValue;
            DataSet CompOnDs = new DataSet();
            DataSet CompOnDsOneValue = new DataSet();
            string CompOnQuery;
            string CompOnQueryOneValue;

            CompOnQuery = "";
            CompOnQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                CompOnQueryOneValue = "Select NumberComputersOnID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                CompOnQuery = "Select * from NumberComputersOn";

                CompOnDa = new SqlDataAdapter(CompOnQuery, con);
                CompOnDaOneValue = new SqlDataAdapter(CompOnQueryOneValue, con);

                CompOnDa.Fill(CompOnDs);
                CompOnDaOneValue.Fill(CompOnDsOneValue);

                if (CompOnDs.Tables[0].Rows.Count > 0)
                {
                    CompOnDropDownList.DataSource = CompOnDs;
                    CompOnDropDownList.DataTextField = "NumberComputersOn";
                    CompOnDropDownList.DataValueField = "NumberComputersOnID";
                    CompOnDropDownList.DataBind();
                }

                var compOnFromDb = CompOnDsOneValue.Tables[0].Rows[0]["NumberComputersOnID"].ToString();


                CompOnDropDownList.SelectedValue = compOnFromDb;
            }
        }

        // Select TvsOn from Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectTvsOnFromAuditRecord2()
        {
            SqlDataAdapter TvsOnDa;
            SqlDataAdapter TvsOnDaOneValue;
            DataSet TvsOnDs = new DataSet();
            DataSet TvsOnDsOneValue = new DataSet();
            string TvsOnQuery;
            string TvsOnQueryOneValue;

            TvsOnQuery = "";
            TvsOnQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                TvsOnQueryOneValue = "Select NumberTvsOnID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                TvsOnQuery = "Select * from NumberTvsOn";

                TvsOnDa = new SqlDataAdapter(TvsOnQuery, con);
                TvsOnDaOneValue = new SqlDataAdapter(TvsOnQueryOneValue, con);

                TvsOnDa.Fill(TvsOnDs);
                TvsOnDaOneValue.Fill(TvsOnDsOneValue);

                if (TvsOnDs.Tables[0].Rows.Count > 0)
                {
                    TvsOnDropDownList.DataSource = TvsOnDs;
                    TvsOnDropDownList.DataTextField = "NumberTvsOn";
                    TvsOnDropDownList.DataValueField = "NumberTvsOnID";
                    TvsOnDropDownList.DataBind();
                }

                var tvsOnFromDb = TvsOnDsOneValue.Tables[0].Rows[0]["NumberTvsOnID"].ToString();


                TvsOnDropDownList.SelectedValue = tvsOnFromDb;
            }
        }

        // Select ProjectorsOn from AuditRecord Based on AuditID When Record Selected From GridView. 
        public void SelectProjectorsOnFromAuditRecord2()
        {
            SqlDataAdapter ProjectorsOnDa;
            SqlDataAdapter ProjectorsOnDaOneValue;
            DataSet ProjectorsOnDs = new DataSet();
            DataSet ProjectorsOnDsOneValue = new DataSet();
            string ProjectorsOnQuery;
            string ProjectorsOnQueryOneValue;

            ProjectorsOnQuery = "";
            ProjectorsOnQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                ProjectorsOnQueryOneValue = "Select NumberProjectorsOnID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                ProjectorsOnQuery = "Select * from NumberProjectorsOn";

                ProjectorsOnDa = new SqlDataAdapter(ProjectorsOnQuery, con);
                ProjectorsOnDaOneValue = new SqlDataAdapter(ProjectorsOnQueryOneValue, con);

                ProjectorsOnDa.Fill(ProjectorsOnDs);
                ProjectorsOnDaOneValue.Fill(ProjectorsOnDsOneValue);

                if (ProjectorsOnDs.Tables[0].Rows.Count > 0)
                {
                    ProjOnDropDownList.DataSource = ProjectorsOnDs;
                    ProjOnDropDownList.DataTextField = "NumberProjectorsOn";
                    ProjOnDropDownList.DataValueField = "NumberProjectorsOnID";
                    ProjOnDropDownList.DataBind();
                }

                var projOnFromDb = ProjectorsOnDsOneValue.Tables[0].Rows[0]["NumberProjectorsOnID"].ToString();


                ProjOnDropDownList.SelectedValue = projOnFromDb;
            }
        }

        // Select LightsOn from Audit Record Based on AuditID When Record Selected From GridView. 
        public void SelectLightsOnFromAuditRecord2()
        {
            SqlDataAdapter LightsOnDa;
            SqlDataAdapter LightsOnDaOneValue;
            DataSet LightsOnDs = new DataSet();
            DataSet LightsOnDsOneValue = new DataSet();
            string LightsOnQuery;
            string LightsOnQueryOneValue;

            LightsOnQuery = "";
            LightsOnQueryOneValue = "";

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                LightsOnQueryOneValue = "Select NumberLightsOnID from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];

                LightsOnQuery = "Select * from NumberLightsOn";

                LightsOnDa = new SqlDataAdapter(LightsOnQuery, con);
                LightsOnDaOneValue = new SqlDataAdapter(LightsOnQueryOneValue, con);

                LightsOnDa.Fill(LightsOnDs);
                LightsOnDaOneValue.Fill(LightsOnDsOneValue);

                if (LightsOnDs.Tables[0].Rows.Count > 0)
                {
                    LightsOnDropDownList.DataSource = LightsOnDs;
                    LightsOnDropDownList.DataTextField = "NumberLightsOn";
                    LightsOnDropDownList.DataValueField = "NumberLightsOnID";
                    LightsOnDropDownList.DataBind();
                }

                var lightsOnFromDb = LightsOnDsOneValue.Tables[0].Rows[0]["NumberLightsOnID"].ToString();


                LightsOnDropDownList.SelectedValue = lightsOnFromDb;
            }
        }

        // Select CheckBox Values from Audit DB Record Based on AuditID When Record Selected From GridView. 
        public void SelectCheckBoxListsFromAuditRecord2()
        {

            if (Request.QueryString["GridViewAuditID"] == null)
            {
                ClearCheckBoxs(KitchenCheckBoxList);
                ClearCheckBoxs(AHUCheckBoxList);
                ClearCheckBoxs(IrrigationCheckBoxList);
                ClearCheckBoxs(ParkingLightsCheckBoxList);
                ClearCheckBoxs(TempCheckBoxList);
                ClearCheckBoxs(LabCheckBoxList);
                ClearCheckBoxs(MarqueeCheckBoxList);
                ClearDropDown(NameDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearDropDown(CampusDropDownList);
                ClearDropDown(BuildingDropDownList);
                ClearDropDown(ParkingLotDropDownList);
                ClearDropDown(ZoneDropDownList);
                ClearDropDown(AuditDropDownList);
                ClearDropDown(CompOnDropDownList);
                ClearDropDown(TvsOnDropDownList);
                ClearDropDown(ProjOnDropDownList);
                ClearDropDown(LightsOnDropDownList);
                ClearTextBoxs(KitchenTextBox);
                ClearTextBoxs(AHUTextBox);
                ClearTextBoxs(IrrigationTextBox);
                ClearTextBoxs(ParkingLightsTextBox);
                ClearTextBoxs(TempTextBox);
                ClearTextBoxs(LabTextBox);
                ClearTextBoxs(OtherTextBox);
                ClearTextBoxs(MarqueeTextBox);
            }
            else
            {

                var auditDs = new DataSet();
                var auditQuery = "Select * from Audit WHERE AuditID = " + Request.QueryString["GridViewAuditID"];
                var auditDa = new SqlDataAdapter(auditQuery, con);
                auditDa.Fill(auditDs);

                var dt = auditDs.Tables[0];

                var waterRunning = (bool)dt.Rows[0]["WaterRunning"];
                var waterLeak = (bool)dt.Rows[0]["KitchenWaterLeak"];
                var lightsOn = (bool)dt.Rows[0]["KitchenLightsOn"];
                var fridgeOpen = (bool)dt.Rows[0]["FridgeOpen"];
                var freezerOpen = (bool)dt.Rows[0]["FreezerOpen"];
                var kitchenOther = (bool)dt.Rows[0]["KitchenOther"];

                var filter = (bool)dt.Rows[0]["Filter"];
                var aHUWaterLeak = (bool)dt.Rows[0]["AHUWaterLeak"];
                var airLeak = (bool)dt.Rows[0]["AirLeak"];
                var noise = (bool)dt.Rows[0]["Noise"];
                var vFD = (bool)dt.Rows[0]["VFD"];
                var inHand = (bool)dt.Rows[0]["InHand"];
                var error = (bool)dt.Rows[0]["Error"];
                var aHUOther = (bool)dt.Rows[0]["AHUOther"];

                var headAdjustment = (bool)dt.Rows[0]["HeadAdjustment"];
                var brokenHead = (bool)dt.Rows[0]["BrokenHead"];
                var irrigationOnDay = (bool)dt.Rows[0]["IrrigationOnDayTime"];
                var irrigationOnNight = (bool)dt.Rows[0]["IrrigationOnNightTime"];
                var manualOverride = (bool)dt.Rows[0]["ManualOverride"];
                var irriagationWaterLeak = (bool)dt.Rows[0]["IrrigationWaterLeak"];
                var irrigationOther = (bool)dt.Rows[0]["IrrigationOther"];

                var securityMode = (bool)dt.Rows[0]["SecurityMode"];
                var locked = (bool)dt.Rows[0]["Locked"];
                var lightsOnDay = (bool)dt.Rows[0]["LightsOnDayTime"];
                var lightsOnNight = (bool)dt.Rows[0]["LightsOnNightTime"];
                var brokenBulb = (bool)dt.Rows[0]["BrokenBulb"];
                var parkingLightsOther = (bool)dt.Rows[0]["ParkingLightsOther"];

                var tempTooCold = (bool)dt.Rows[0]["TempTooCold"];
                var tempTooHot = (bool)dt.Rows[0]["TempTooHot"];
                var thermostateBroken = (bool)dt.Rows[0]["ThermostatBroken"];
                var tempOther = (bool)dt.Rows[0]["TempOther"];
                var kitchenWaterLeak = (bool)dt.Rows[0]["KitchenWaterLeak"];
                var tVSOn = (bool)dt.Rows[0]["TvsOn"];
                var projectorsOn = (bool)dt.Rows[0]["ProjectorsOn"];
                var labLightsOn = (bool)dt.Rows[0]["LabLightsOn"];
                var labOther = (bool)dt.Rows[0]["LabOther"];

                var marqueeOnDay = (bool)dt.Rows[0]["MarqueeOnDayTime"];
                var marqueeOnNight = (bool)dt.Rows[0]["MarqueeOnNightTime"];
                var brokenPixels = (bool)dt.Rows[0]["BrokenPixels"];
                var marqueeOther = (bool)dt.Rows[0]["MarqueeOther"];

                KitchenCheckBoxList.Items[0].Selected = waterRunning;
                KitchenCheckBoxList.Items[1].Selected = waterLeak;
                KitchenCheckBoxList.Items[2].Selected = lightsOn;
                KitchenCheckBoxList.Items[3].Selected = fridgeOpen;
                KitchenCheckBoxList.Items[4].Selected = freezerOpen;
                KitchenCheckBoxList.Items[5].Selected = kitchenOther;

                AHUCheckBoxList.Items[0].Selected = filter;
                AHUCheckBoxList.Items[1].Selected = aHUWaterLeak;
                AHUCheckBoxList.Items[2].Selected = airLeak;
                AHUCheckBoxList.Items[3].Selected = noise;
                AHUCheckBoxList.Items[4].Selected = vFD;
                AHUCheckBoxList.Items[5].Selected = inHand;
                AHUCheckBoxList.Items[6].Selected = error;
                AHUCheckBoxList.Items[7].Selected = aHUOther;

                IrrigationCheckBoxList.Items[0].Selected = headAdjustment;
                IrrigationCheckBoxList.Items[1].Selected = brokenHead;
                IrrigationCheckBoxList.Items[2].Selected = irrigationOnDay;
                IrrigationCheckBoxList.Items[3].Selected = irrigationOnNight;
                IrrigationCheckBoxList.Items[4].Selected = manualOverride;
                IrrigationCheckBoxList.Items[5].Selected = irriagationWaterLeak;
                IrrigationCheckBoxList.Items[6].Selected = irrigationOther;

                ParkingLightsCheckBoxList.Items[0].Selected = securityMode;
                ParkingLightsCheckBoxList.Items[1].Selected = locked;
                ParkingLightsCheckBoxList.Items[2].Selected = lightsOnDay;
                ParkingLightsCheckBoxList.Items[3].Selected = lightsOnNight;
                ParkingLightsCheckBoxList.Items[4].Selected = brokenBulb;
                ParkingLightsCheckBoxList.Items[5].Selected = parkingLightsOther;

                TempCheckBoxList.Items[0].Selected = tempTooCold;
                TempCheckBoxList.Items[1].Selected = tempTooHot;
                TempCheckBoxList.Items[2].Selected = thermostateBroken;
                TempCheckBoxList.Items[3].Selected = tempOther;

                LabCheckBoxList.Items[0].Selected = kitchenWaterLeak;
                LabCheckBoxList.Items[1].Selected = tVSOn;
                LabCheckBoxList.Items[2].Selected = projectorsOn;
                LabCheckBoxList.Items[3].Selected = labLightsOn;
                LabCheckBoxList.Items[4].Selected = labOther;

                MarqueeCheckBoxList.Items[0].Selected = marqueeOnDay;
                MarqueeCheckBoxList.Items[1].Selected = marqueeOnNight;
                MarqueeCheckBoxList.Items[2].Selected = brokenPixels;
                MarqueeCheckBoxList.Items[3].Selected = marqueeOther;

                ParkingLightsCheckBoxList.Items[0].Selected = securityMode;
                ParkingLightsCheckBoxList.Items[1].Selected = locked;
                ParkingLightsCheckBoxList.Items[2].Selected = lightsOnDay;
                ParkingLightsCheckBoxList.Items[3].Selected = lightsOnNight;
                ParkingLightsCheckBoxList.Items[4].Selected = brokenBulb;
                ParkingLightsCheckBoxList.Items[5].Selected = parkingLightsOther;

            }
        }

        // Select Name Drop Down List With AuditorFirstName Feild Data From Auditor Table In Database. 
        public void SelectAuditor()
        {
            var auditDs = new DataSet();
            var auditQuery = "Select * from Audit";
            var auditDa = new SqlDataAdapter(auditQuery, con);
            auditDa.Fill(auditDs);

            var dt = auditDs.Tables[0];

            var auditorFirstName = (String)dt.Rows[0]["AuditName"];

            NameDropDownList.SelectedValue = auditorFirstName;
        }

        // Select LabRoomListBox From Audit Table In Database. 
        public void SelectLabRoom()
        {
            var RoomDs = new DataSet();
            var auditQuery = "Select * from Room";
            var auditDa = new SqlDataAdapter(auditQuery, con);
            auditDa.Fill(RoomDs);

            var dt = RoomDs.Tables[0];

            String RoomIDSTring = dt.Rows[0]["RoomNumber"].ToString();

            var auditLabRoomNumber = RoomIDSTring;

            RoomListBox.SelectedValue = auditLabRoomNumber;
        }

        // Select CampusDropDownList With CampusName Feild Data From Campus Table In Database. 
        public void SelectCampus()
        {
            var CampusDs = new DataSet();
            var campusQuery = "Select * from Campus";
            var campusDa = new SqlDataAdapter(campusQuery, con);
            campusDa.Fill(CampusDs);

            var dt = CampusDs.Tables[0];

            var campusName = (String)dt.Rows[2]["CampusName"];

            CampusDropDownList.SelectedValue = campusName;
        }

        // Select BuildingDropDownList With BuildingNumber Feild Data From Building Table In Database. 
        public void SelectBuilding()
        {
            var buildingDataSet = new DataSet();
            var buildingQuery = "Select * from Building";
            var buildingDataAdapter = new SqlDataAdapter(buildingQuery, con);
            buildingDataAdapter.Fill(buildingDataSet);

            var dt = buildingDataSet.Tables[0];

            var buildingNumber = (String)dt.Rows[0]["BuildingNumber"];
            var buildingID = (int)dt.Rows[0]["buildingID"];
            buildingID = 2;

            BuildingDropDownList.SelectedValue = buildingNumber;
        }

        // Select AuditType Drop Down List With AuditType Feild Data From AuditType Table In Database. 
        public void SelectAuditType()
        {
            var auditDs = new DataSet();
            var auditQuery = "Select * from AuditType";
            var auditDa = new SqlDataAdapter(auditQuery, con);
            auditDa.Fill(auditDs);

            var dt = auditDs.Tables[0];

            var auditTypeName = (String)dt.Rows[1]["AuditType"];

            AuditDropDownList.SelectedValue = auditTypeName;
        }

        // Load All Choices From Computers On Table in DB into CompOnDropDownList
        public void LoadComputersOn()
        {

            SqlDataAdapter compOnDa;
            DataSet compOnDs = new DataSet();
            string compOnQuery;

            compOnQuery = "Select * from NumberComputersOn";
            compOnDa = new SqlDataAdapter(compOnQuery, con);

            compOnDa.Fill(compOnDs);
            if (compOnDs.Tables[0].Rows.Count > 0)
            {
                CompOnDropDownList.DataSource = compOnDs;
                CompOnDropDownList.DataTextField = "NumberComputersOn";
                CompOnDropDownList.DataValueField = "NumberComputersOnID";
                CompOnDropDownList.DataBind();
                CompOnDropDownList.SelectedIndex = 0;
            }
        }

        // Load All Choices From Projectors On Table in DB into ProjectorsOnDropDownList
        public void LoadProjectorsOn()
        {

            SqlDataAdapter projOnDa;
            DataSet projOnDs = new DataSet();
            string projOnQuery;

            projOnQuery = "Select * from NumberProjectorsOn";
            projOnDa = new SqlDataAdapter(projOnQuery, con);

            projOnDa.Fill(projOnDs);
            if (projOnDs.Tables[0].Rows.Count > 0)
            {
                ProjOnDropDownList.DataSource = projOnDs;
                ProjOnDropDownList.DataTextField = "NumberProjectorsOn";
                ProjOnDropDownList.DataValueField = "NumberProjectorsOnID";
                ProjOnDropDownList.DataBind();
                ProjOnDropDownList.SelectedIndex = 0;
            }
        }

        // Load All Choices From Parking Tvs On Table in DB into TvsOnDropDownList
        public void LoadTvsOn()
        {

            SqlDataAdapter tvsOnDa;
            DataSet tvsOnDs = new DataSet();
            string tvsOnQuery;

            tvsOnQuery = "Select * from NumberTvsOn";
            tvsOnDa = new SqlDataAdapter(tvsOnQuery, con);

            tvsOnDa.Fill(tvsOnDs);
            if (tvsOnDs.Tables[0].Rows.Count > 0)
            {
                TvsOnDropDownList.DataSource = tvsOnDs;
                TvsOnDropDownList.DataTextField = "NumberTvsOn";
                TvsOnDropDownList.DataValueField = "NumberTvsOnID";
                TvsOnDropDownList.DataBind();
                TvsOnDropDownList.SelectedIndex = 0;
            }
        }

        // Load All Choices From Parking Lights On Table in DB into lightsOnDropDownList
        public void LoadParkingLightsOn()
        {

            SqlDataAdapter parkingLightsOnDa;
            DataSet parkingLightsOnDs = new DataSet();
            string parkingLightsOnQuery;

            parkingLightsOnQuery = "Select * from NumberLightsOn";
            parkingLightsOnDa = new SqlDataAdapter(parkingLightsOnQuery, con);

            parkingLightsOnDa.Fill(parkingLightsOnDs);
            if (parkingLightsOnDs.Tables[0].Rows.Count > 0)
            {
                LightsOnDropDownList.DataSource = parkingLightsOnDs;
                LightsOnDropDownList.DataTextField = "NumberLightsOn";
                LightsOnDropDownList.DataValueField = "NumberLightsOnID";
                LightsOnDropDownList.DataBind();
                LightsOnDropDownList.SelectedIndex = 0;
            }
        }

        // Load all auditor choices from database into auditor drop down
        public void LoadAuditors()
        {
            SqlDataAdapter LoadAuditorsDa;
            DataSet LoadAuditorsDs = new DataSet();
            string LoadAuditorsQuery;

            LoadAuditorsQuery = "Select * from Auditor";
            LoadAuditorsDa = new SqlDataAdapter(LoadAuditorsQuery, con);

            LoadAuditorsDa.Fill(LoadAuditorsDs);
            if (LoadAuditorsDs.Tables[0].Rows.Count > 0)
            {
                NameDropDownList.DataSource = LoadAuditorsDs;
                NameDropDownList.DataTextField = "AuditorFirstName";
                NameDropDownList.DataValueField = "AuditorID";
                NameDropDownList.DataBind();
                NameDropDownList.SelectedIndex = 0;
            }
        }

        // Load all campus choices from database into campus drop down
        public void LoadCampuses()
        {
            SqlDataAdapter LoadCampusesDa;
            DataSet LoadCampusesDs = new DataSet();
            string LoadCampusesQuery;

            LoadCampusesQuery = "Select * from Campus";
            LoadCampusesDa = new SqlDataAdapter(LoadCampusesQuery, con);

            LoadCampusesDa.Fill(LoadCampusesDs);
            if (LoadCampusesDs.Tables[0].Rows.Count > 0)
            {
                CampusDropDownList.DataSource = LoadCampusesDs;
                CampusDropDownList.DataTextField = "CampusName";
                CampusDropDownList.DataValueField = "CampusID";
                CampusDropDownList.DataBind();
                CampusDropDownList.SelectedIndex = 7;
            }
        }

        // Load all building choices from database into building drop down
        public void LoadBuildings()
        {
            SqlDataAdapter LoadBuildingsDa;
            DataSet LoadBuildingsDs = new DataSet();
            string LoadBuildingsQuery;

            LoadBuildingsQuery = "Select * from Building";
            LoadBuildingsDa = new SqlDataAdapter(LoadBuildingsQuery, con);

            LoadBuildingsDa.Fill(LoadBuildingsDs);
            if (LoadBuildingsDs.Tables[0].Rows.Count > 0)
            {
                BuildingDropDownList.DataSource = LoadBuildingsDs;
                BuildingDropDownList.DataTextField = "BuildingNumber";
                BuildingDropDownList.DataValueField = "BuildingID";
                BuildingDropDownList.DataBind();
                BuildingDropDownList.SelectedIndex = 0;
            }
        }

        // Load all lab room choices from database into lab room list box
        public void LoadLabRooms()
        {
            SqlDataAdapter LoadLabRoomsDa;
            DataSet LoadLabRoomsDs = new DataSet();
            string LoadLabRoomsQuery;

            LoadLabRoomsQuery = "Select * from Room";
            LoadLabRoomsDa = new SqlDataAdapter(LoadLabRoomsQuery, con);

            LoadLabRoomsDa.Fill(LoadLabRoomsDs);
            if (LoadLabRoomsDs.Tables[0].Rows.Count > 0)
            {
                RoomListBox.DataSource = LoadLabRoomsDs;
                RoomListBox.DataTextField = "RoomNumber";
                RoomListBox.DataValueField = "RoomID";
                RoomListBox.DataBind();
                RoomListBox.SelectedIndex = 0;
            }
        }

        // Load all parking lot choices from database into parking lot drop down
        public void LoadLots()
        {
            SqlDataAdapter LoadLotsDa;
            DataSet LoadLotsDs = new DataSet();
            string LoadLotsQuery;

            LoadLotsQuery = "Select * from ParkingLot";
            LoadLotsDa = new SqlDataAdapter(LoadLotsQuery, con);

            LoadLotsDa.Fill(LoadLotsDs);
            if (LoadLotsDs.Tables[0].Rows.Count > 0)
            {
                ParkingLotDropDownList.DataSource = LoadLotsDs;
                ParkingLotDropDownList.DataTextField = "LotName";
                ParkingLotDropDownList.DataValueField = "ParkingLotID";
                ParkingLotDropDownList.DataBind();
                ParkingLotDropDownList.SelectedIndex = 0;
            }
        }

        // Load all sprinkler choices from database into sprinkler zone drop down
        public void LoadSprinklerZones()
        {
            SqlDataAdapter LoadSprinklerZonesDa;
            DataSet LoadSprinklerZonesDs = new DataSet();
            string LoadSprinklerZonesQuery;

            LoadSprinklerZonesQuery = "Select * from SprinklerZone";
            LoadSprinklerZonesDa = new SqlDataAdapter(LoadSprinklerZonesQuery, con);

            LoadSprinklerZonesDa.Fill(LoadSprinklerZonesDs);
            if (LoadSprinklerZonesDs.Tables[0].Rows.Count > 0)
            {
                ZoneDropDownList.DataSource = LoadSprinklerZonesDs;
                ZoneDropDownList.DataTextField = "Zone";
                ZoneDropDownList.DataValueField = "ZoneID";
                ZoneDropDownList.DataBind();
                ZoneDropDownList.SelectedIndex = 0;
            }

            string CampusValue = CampusDropDownList.SelectedValue;
            // Test
            // Response.Write(CampusValue + "  this is Campus Value");
        }

        // Load all sprinkler choices from database into sprinkler zone drop down
        public void FilterSprinklerZonesByCampusID()
        {
            SqlDataAdapter LoadSprinklerZonesDa;
            DataSet LoadSprinklerZonesDs = new DataSet();
            string LoadSprinklerZonesQuery;

            LoadSprinklerZonesQuery = "Select * from SprinklerZone Where CampusID = " + CampusDropDownList.SelectedValue;
            LoadSprinklerZonesDa = new SqlDataAdapter(LoadSprinklerZonesQuery, con);

            LoadSprinklerZonesDa.Fill(LoadSprinklerZonesDs);
            if (LoadSprinklerZonesDs.Tables[0].Rows.Count > 0)
            {
                ZoneDropDownList.DataSource = LoadSprinklerZonesDs;
                ZoneDropDownList.DataTextField = "Zone";
                ZoneDropDownList.DataValueField = "ZoneID";
                ZoneDropDownList.DataBind();
                ZoneDropDownList.SelectedIndex = 0;
            }
        }

        // Load all audit type choices from database into audit type drop down
        public void LoadAuditTypes()
        {
            SqlDataAdapter LoadAuditTypesDa;
            DataSet LoadAuditTypesDs = new DataSet();
            string LoadAuditTypesQuery;

            LoadAuditTypesQuery = "Select * from AuditType";
            LoadAuditTypesDa = new SqlDataAdapter(LoadAuditTypesQuery, con);

            LoadAuditTypesDa.Fill(LoadAuditTypesDs);
            if (LoadAuditTypesDs.Tables[0].Rows.Count > 0)
            {
                AuditDropDownList.DataSource = LoadAuditTypesDs;
                AuditDropDownList.DataTextField = "AuditType";
                AuditDropDownList.DataValueField = "AuditTypeID";
                AuditDropDownList.DataBind();
                AuditDropDownList.SelectedIndex = 0;
            }
        }

        protected void ClearFormButton_Click(object sender, EventArgs e)
        {

            ClearCheckBoxs(KitchenCheckBoxList);
            ClearCheckBoxs(AHUCheckBoxList);
            ClearCheckBoxs(IrrigationCheckBoxList);
            ClearCheckBoxs(ParkingLightsCheckBoxList);
            ClearCheckBoxs(TempCheckBoxList);
            ClearCheckBoxs(LabCheckBoxList);
            ClearCheckBoxs(MarqueeCheckBoxList);
            ClearDropDown(NameDropDownList);
            ClearDropDown(CompOnDropDownList);
            ClearDropDown(TvsOnDropDownList);
            ClearDropDown(ProjOnDropDownList);
            ClearDropDown(LightsOnDropDownList);
            ClearDropDown(CampusDropDownList);
            ClearDropDown(BuildingDropDownList);
            ClearDropDown(ParkingLotDropDownList);
            ClearDropDown(ZoneDropDownList);
            ClearDropDown(AuditDropDownList);
            ClearDropDown(CompOnDropDownList);
            ClearDropDown(TvsOnDropDownList);
            ClearDropDown(ProjOnDropDownList);
            ClearDropDown(LightsOnDropDownList);
            ClearTextBoxs(KitchenTextBox);
            ClearTextBoxs(AHUTextBox);
            ClearTextBoxs(IrrigationTextBox);
            ClearTextBoxs(ParkingLightsTextBox);
            ClearTextBoxs(TempTextBox);
            ClearTextBoxs(LabTextBox);
            ClearTextBoxs(OtherTextBox);
            ClearTextBoxs(MarqueeTextBox);
            ListBoxLabel.Visible = false;

        }

        protected void KitchenCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void AuditDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Save()
        {
            if (Request.QueryString["GridViewAuditID"] == null)
            {
                // We are inserting
                Insert("insert into Audit ( CampusName, BuildingName, RoomName, ZoneName, NumberLightsOnID, NumberTvsOnID, NumberProjectorsOnID, NumberComputersOnID, ZoneID, CampusID, BuildingID, Image, EnergyUsed, Filter, AHUWaterLeak, AirLeak, Noise, VFD, InHand, Error, AHUOther, ComputersOn, TvsOn, ProjectorsOn, LabLightsOn, LabOther, HeadAdjustment, BrokenHead, IrrigationOnDayTime, IrrigationOnNightTime, ManualOverride, IrrigationWaterLeak, IrrigationOther, SecurityMode, Locked, LightsOnDayTime, LightsOnNightTime, BrokenBulb, ParkingLightsOther, TempTooCold, TempTooHot, ThermostatBroken, TempOther, MarqueeOnDayTime, MarqueeOnNightTime, BrokenPixels, MarqueeOther, WaterRunning, KitchenWaterLeak, KitchenLightsOn, FridgeOpen, FreezerOpen, KitchenOther, AHUNotes, ComputerLabNotes, KitchenNotes, IrrigationNotes, TemperatureNotes, MarqueeNotes, OtherNotes, ParkingLightsNotes, AuditName, AuditDate, AuditTypeID, AuditTypeName, RoomID, AuditorID, ParkingLotID, LotName, NumberComputersOn, NumberProjectorsOn, NumberTvsOn, NumberLightsOn) values ('" + CampusDropDownList.SelectedItem + "', '" + BuildingDropDownList.SelectedItem + "','" + RoomListBox.SelectedItem + "','" + ZoneDropDownList.SelectedItem + "','" + LightsOnDropDownList.SelectedValue + "', '" + TvsOnDropDownList.SelectedValue + "' , '" + ProjOnDropDownList.SelectedValue + "', '" + CompOnDropDownList.SelectedValue + "', '" + ZoneDropDownList.SelectedValue + "'  , '" + CampusDropDownList.SelectedValue + "','" + BuildingDropDownList.SelectedValue + "', '" + ImageFileUpload.FileName + "' , '" + EnergyCostTextBox.Text + "', '" + AHUCheckBoxList.Items[0].Selected + "','" + AHUCheckBoxList.Items[1].Selected + "', '" + AHUCheckBoxList.Items[2].Selected + "','" + AHUCheckBoxList.Items[3].Selected + "','" + AHUCheckBoxList.Items[4].Selected + "', '" + AHUCheckBoxList.Items[5].Selected + "','" + AHUCheckBoxList.Items[6].Selected + "', '" + AHUCheckBoxList.Items[7].Selected + "','" + LabCheckBoxList.Items[0].Selected + "','" + LabCheckBoxList.Items[1].Selected + "','" + LabCheckBoxList.Items[2].Selected + "','" + LabCheckBoxList.Items[3].Selected + "','" + LabCheckBoxList.Items[4].Selected + "',  '" + IrrigationCheckBoxList.Items[0].Selected + "', '" + IrrigationCheckBoxList.Items[1].Selected + "', '" + IrrigationCheckBoxList.Items[2].Selected + "', '" + IrrigationCheckBoxList.Items[3].Selected + "', '" + IrrigationCheckBoxList.Items[4].Selected + "', '" + IrrigationCheckBoxList.Items[5].Selected + "', '" + IrrigationCheckBoxList.Items[6].Selected + "', '" + ParkingLightsCheckBoxList.Items[0].Selected + "', '" + ParkingLightsCheckBoxList.Items[1].Selected + "', '" + ParkingLightsCheckBoxList.Items[2].Selected + "', '" + ParkingLightsCheckBoxList.Items[3].Selected + "', '" + ParkingLightsCheckBoxList.Items[4].Selected + "', '" + ParkingLightsCheckBoxList.Items[5].Selected + "', '" + TempCheckBoxList.Items[0].Selected + "',  '" + TempCheckBoxList.Items[1].Selected + "', '" + TempCheckBoxList.Items[2].Selected + "', '" + TempCheckBoxList.Items[3].Selected + "', '" + MarqueeCheckBoxList.Items[0].Selected + "', '" + MarqueeCheckBoxList.Items[1].Selected + "', '" + MarqueeCheckBoxList.Items[2].Selected + "',  '" + MarqueeCheckBoxList.Items[3].Selected + "',   '" + KitchenCheckBoxList.Items[0].Selected + "', '" + KitchenCheckBoxList.Items[1].Selected + "',  '" + KitchenCheckBoxList.Items[2].Selected + "',  '" + KitchenCheckBoxList.Items[3].Selected + "',   '" + KitchenCheckBoxList.Items[4].Selected + "', '" + KitchenCheckBoxList.Items[5].Selected + "', '" + AHUTextBox.Text + "', '" + LabTextBox.Text + "', '" + KitchenTextBox.Text + "', '" + IrrigationTextBox.Text + "', '" + TempTextBox.Text + "', '" + MarqueeTextBox.Text + "', '" + OtherTextBox.Text + "',  '" + ParkingLightsTextBox.Text + "' , '" + NameDropDownList.SelectedItem + "', '" + Calendar1.TodaysDate + "','" + AuditDropDownList.SelectedValue + "', '" + AuditDropDownList.SelectedItem + "', '" + RoomListBox.SelectedValue + "','" + NameDropDownList.SelectedValue + "','" + ParkingLotDropDownList.SelectedValue + "','" + ParkingLotDropDownList.SelectedItem + "', '" + CompOnDropDownList.SelectedItem + "', '" + ProjOnDropDownList.SelectedItem + "', '" + TvsOnDropDownList.SelectedItem + "', '" + LightsOnDropDownList.SelectedItem + "');");
            }
            else
            {
                // We are updating
                Insert("Update Audit Set CampusName = '" + CampusDropDownList.SelectedItem + "', BuildingName = '" + BuildingDropDownList.SelectedItem + "', RoomName = '" + RoomListBox.SelectedItem + "', ZoneName = '" + ZoneDropDownList.SelectedItem + "', NumberLightsOnID = '" + LightsOnDropDownList.SelectedValue + "', NumberTvsOnID = '" + TvsOnDropDownList.SelectedValue + "', NumberProjectorsOnID = '" + ProjOnDropDownList.SelectedValue + "', NumberComputersOnID = '" + CompOnDropDownList.SelectedValue + "', ZoneID = '" + ZoneDropDownList.SelectedValue + "', CampusID = '" + CampusDropDownList.SelectedValue + " ', BuildingID = '" + BuildingDropDownList.SelectedValue + " ', Image =  '" + ImageFileUpload.FileName + "', AuditName = '" + NameDropDownList.SelectedItem + "', AuditTypeID = '" + AuditDropDownList.SelectedValue + "', AuditorID = '" + NameDropDownList.SelectedValue + "', EnergyUsed = '" + EnergyCostTextBox.Text + "', Filter = '" + AHUCheckBoxList.Items[0].Selected + "', AHUWaterLeak = '" + AHUCheckBoxList.Items[1].Selected + "' , AirLeak = '" + AHUCheckBoxList.Items[2].Selected + "', Noise = '" + AHUCheckBoxList.Items[3].Selected + "', VFD =  '" + AHUCheckBoxList.Items[4].Selected + "', InHand= '" + AHUCheckBoxList.Items[5].Selected + "', Error = '" + AHUCheckBoxList.Items[6].Selected + "', AHUOther = '" + AHUCheckBoxList.Items[7].Selected + "', ComputersOn =  '" + LabCheckBoxList.Items[0].Selected + "', TvsOn = '" + LabCheckBoxList.Items[1].Selected + "', ProjectorsOn = '" + LabCheckBoxList.Items[2].Selected + "', LabLightsOn = '" + LabCheckBoxList.Items[3].Selected + "', LabOther = '" + LabCheckBoxList.Items[4].Selected + "', HeadAdjustment = '" + IrrigationCheckBoxList.Items[0].Selected + "', BrokenHead = '" + IrrigationCheckBoxList.Items[1].Selected + "', IrrigationOnDayTime = '" + IrrigationCheckBoxList.Items[2].Selected + "', IrrigationOnNightTime = '" + IrrigationCheckBoxList.Items[3].Selected + "', ManualOverride = '" + IrrigationCheckBoxList.Items[4].Selected + "', IrrigationWaterLeak = '" + IrrigationCheckBoxList.Items[5].Selected + "', IrrigationOther = '" + IrrigationCheckBoxList.Items[6].Selected + "', SecurityMode = '" + ParkingLightsCheckBoxList.Items[0].Selected + "', Locked = '" + ParkingLightsCheckBoxList.Items[1].Selected + "', LightsOnDayTime = '" + ParkingLightsCheckBoxList.Items[2].Selected + "', LightsOnNightTime = '" + ParkingLightsCheckBoxList.Items[3].Selected + "', BrokenBulb = '" + ParkingLightsCheckBoxList.Items[4].Selected + "', ParkingLightsOther = '" + ParkingLightsCheckBoxList.Items[5].Selected + "', TempTooCold = '" + TempCheckBoxList.Items[0].Selected + "', TempTooHot = '" + TempCheckBoxList.Items[1].Selected + "',ThermostatBroken =  '" + TempCheckBoxList.Items[2].Selected + "', TempOther =  '" + TempCheckBoxList.Items[3].Selected + "', MarqueeOnDayTime = '" + MarqueeCheckBoxList.Items[0].Selected + "', MarqueeOnNightTime = '" + MarqueeCheckBoxList.Items[1].Selected + "', BrokenPixels = '" + MarqueeCheckBoxList.Items[2].Selected + "', MarqueeOther = '" + MarqueeCheckBoxList.Items[3].Selected + "', WaterRunning = '" + KitchenCheckBoxList.Items[0].Selected + "', KitchenWaterLeak = '" + KitchenCheckBoxList.Items[1].Selected + "', KitchenLightsOn = '" + KitchenCheckBoxList.Items[2].Selected + "', FridgeOpen = '" + KitchenCheckBoxList.Items[3].Selected + "', FreezerOpen = '" + KitchenCheckBoxList.Items[4].Selected + "', KitchenOther = '" + KitchenCheckBoxList.Items[5].Selected + "', AHUNotes = '" + AHUTextBox.Text + "', ComputerLabNotes = '" + LabTextBox.Text + "', KitchenNotes = '" + KitchenTextBox.Text + "', IrrigationNotes = '" + IrrigationTextBox.Text + "', TemperatureNotes = '" + TempTextBox.Text + "', MarqueeNotes = '" + MarqueeTextBox.Text + "', OtherNotes = '" + OtherTextBox.Text + "', ParkingLightsNotes = '" + ParkingLightsTextBox.Text + "'  ,  AuditDate = '" + Calendar1.TodaysDate + "',  AuditTypeName = '" + AuditDropDownList.SelectedItem + "', RoomID = '" + RoomListBox.SelectedValue + "',  ParkingLotID = '" + ParkingLotDropDownList.SelectedValue + "', LotName = '" + ParkingLotDropDownList.SelectedItem + "', NumberComputersOn = '" + CompOnDropDownList.SelectedItem + "', NumberProjectorsOn = '" + ProjOnDropDownList.SelectedItem + "', NumberTvsOn = '" + TvsOnDropDownList.SelectedItem + "', NumberLightsOn = '" + LightsOnDropDownList.SelectedItem + "'  Where AuditID = " + Request.QueryString["GridViewAuditID"]);
            }
        }

        public void Insert(string sql)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            command = new SqlCommand(sql, con);
            con.Open();
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
        }

        string myGuid = Guid.NewGuid().ToString() + ".jpg";

        protected void SubmitButton_Click(object sender, EventArgs e)
        {


            // Response.Write("This is myGuid Value !  " + myGuid);

            if ((ImageFileUpload.PostedFile != null) && (ImageFileUpload.PostedFile.ContentLength > 0))
            {
                // string fn = System.IO.Path.GetFileName(ImageFileUpload.PostedFile.FileName);
                string fn = System.IO.Path.GetFileName(myGuid);
                string SaveLocation = Server.MapPath("Data") + "\\" + fn;
                try
                {
                    ImageFileUpload.PostedFile.SaveAs(SaveLocation);
                    SaveImage(myGuid);
                    Response.Write("The image has been saved.");
                }
                catch (Exception ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }
            else
            {
                // Response.Write("Please select a file to upload.");

            }

            Save();

            //String QueryInput = Request.QueryString["GridViewAuditID"];
            //Response.Redirect("~/HomePage? auditid= " + QueryInput);      

        }

        protected void LabCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void MarqueeCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TempCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ParkingLightsCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void IrrigationCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void AHUCheckBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void EastListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CampusDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter building drop down list based on what campus is chosen in campus drop down list
            string get_campusid, get_campusname;
            get_campusid = CampusDropDownList.SelectedValue.ToString();
            get_campusname = CampusDropDownList.SelectedItem.Text;

            if (get_campusid != "-1")
            {
                SqlDataAdapter SelectCampusDa;
                DataSet SelectCampusDs = new DataSet();
                string SelectCampusQuery;

                SelectCampusQuery = "Select BuildingID, BuildingNumber from Building where CampusID='" + get_campusid.ToString() + "'";
                SelectCampusDa = new SqlDataAdapter(SelectCampusQuery, con);
                SelectCampusDa.Fill(SelectCampusDs);
                if (SelectCampusDs.Tables[0].Rows.Count > 0)
                {
                    BuildingDropDownList.DataSource = SelectCampusDs;
                    BuildingDropDownList.DataTextField = "BuildingNumber";
                    BuildingDropDownList.DataValueField = "BuildingID";
                    BuildingDropDownList.DataBind();
                    BuildingDropDownList.Items.Insert(0, new ListItem("NA ", "0"));
                    //BuildingDropDownList.SelectedIndex = 0;
                }
            }

            // Filter parking lot drop down list based on what campus is chosen in campus drop down list
            string get_campusid2, get_campusname2;
            get_campusid2 = CampusDropDownList.SelectedValue.ToString();
            get_campusname2 = CampusDropDownList.SelectedItem.Text;

            if (get_campusid2 != "-1")
            {
                SqlDataAdapter SelectCampusDa2;
                DataSet SelectCampusDs2 = new DataSet();
                string SelectCampusQuery2;

                SelectCampusQuery2 = "Select ParkingLotID, LotName from ParkingLot where CampusID='" + get_campusid2.ToString() + "'";
                SelectCampusDa2 = new SqlDataAdapter(SelectCampusQuery2, con);
                SelectCampusDa2.Fill(SelectCampusDs2);
                if (SelectCampusDs2.Tables[0].Rows.Count > 0)
                {
                    ParkingLotDropDownList.DataSource = SelectCampusDs2;
                    ParkingLotDropDownList.DataTextField = "LotName";
                    ParkingLotDropDownList.DataValueField = "ParkingLotID";
                    ParkingLotDropDownList.DataBind();
                    ParkingLotDropDownList.Items.Insert(0, new ListItem("NA ", "0"));
                }
            }

            // Filter ZoneDropDownList based on what campus is chosen in campus drop down list
            string get_campusid3, get_campusname3;
            get_campusid3 = CampusDropDownList.SelectedValue.ToString();
            get_campusname3 = CampusDropDownList.SelectedItem.Text;

            if (get_campusid3 != "-1")
            {
                SqlDataAdapter SelectCampusDa3;
                DataSet SelectCampusDs3 = new DataSet();
                string SelectCampusQuery3;

                SelectCampusQuery3 = "Select ZoneID, Zone from SprinklerZone where CampusID='" + get_campusid3.ToString() + "'";
                SelectCampusDa3 = new SqlDataAdapter(SelectCampusQuery3, con);
                SelectCampusDa3.Fill(SelectCampusDs3);
                if (SelectCampusDs3.Tables[0].Rows.Count > 0)
                {
                    ZoneDropDownList.DataSource = SelectCampusDs3;
                    ZoneDropDownList.DataTextField = "Zone";
                    ZoneDropDownList.DataValueField = "ZoneID";
                    ZoneDropDownList.DataBind();
                    ZoneDropDownList.Items.Insert(0, new ListItem("NA ", "0"));
                }
            }
        }

        protected void BuildingDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Filter room list box based on what building is chosen in building drop down list
            string get_buildingid, get_buildingname;
            get_buildingid = BuildingDropDownList.SelectedValue.ToString();
            get_buildingname = BuildingDropDownList.SelectedItem.Text;

            if (get_buildingid != "-1")
            {
                SqlDataAdapter SelectRoomsDa;
                DataSet SelectRoomsDs = new DataSet();
                string SelectRoomsQuery;

                SelectRoomsQuery = "Select RoomID, RoomNumber from Room where BuildingID='" + get_buildingid.ToString() + "'";
                SelectRoomsDa = new SqlDataAdapter(SelectRoomsQuery, con);
                SelectRoomsDa.Fill(SelectRoomsDs);
                if (SelectRoomsDs.Tables[0].Rows.Count > 0)
                {
                    RoomListBox.DataSource = SelectRoomsDs;
                    RoomListBox.DataTextField = "RoomNumber";
                    RoomListBox.DataValueField = "RoomID";
                    RoomListBox.DataBind();
                    RoomListBox.SelectedIndex = 0;
                }
            }
        }

        protected void RoomDropDownListEast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Clear Drop Down Lists On Form
        public void ClearDropDown(DropDownList dropDownControl)
        {
            DropDownList dDLControl = dropDownControl;
            dDLControl.ClearSelection();
        }

        // Clear Check Boxes On Form
        public void ClearCheckBoxs(CheckBoxList checkBoxListControl)
        {
            CheckBoxList cBLControl = checkBoxListControl;
            cBLControl.ClearSelection();
        }

        // Clear Text Boxes
        public void ClearTextBoxs(TextBox textBoxControl)
        {
            TextBox tBControl = textBoxControl;
            tBControl.Text = "";
        }

        // Check Current Room
        public void CheckCurrentRoom(String Campus)
        {
            int LabLocationIndex;
            LabLocationIndex = 0;

            LabLocationIndex = BuildingDropDownList.SelectedIndex;

            RoomListBox.SelectedIndex = LabLocationIndex;

        }

        // Show or Hide Label
        public void ShowOrHideLabel(Label labelControl, Boolean showHideLabel)
        {
            Label myLabel = labelControl;

            Boolean showHide = showHideLabel;

            if (showHide == true)
            {
                myLabel.Visible = true;
            }
            else if (showHide == false)
            {
                myLabel.Visible = false;
            }
        }

        protected void WestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BldgRoomCheckBoxListEast_SelectedIndexChanged(object sender, EventArgs e)
        {

            CheckCurrentRoom("East");
        }

        protected void BldgRoomCheckBoxListDistrictOffice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BldgRoomCheckBoxListSPS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ManagementButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditAuditors.aspx");
        }

        protected void CampusDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ListBoxEast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void AuditorNameDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {


        }

        protected void FormManagementButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm2.aspx");
        }

        protected void Auditor_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ParkingLotDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SavePDFButton_Click(object sender, EventArgs e)
        {

        }

        protected void ZoneDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        protected void EnergyUseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Decimal compWattsUsed = 0;
            Decimal tVsWattsUsed = 0;
            Decimal projectorWattsUsed = 0;
            Decimal lightsWattsUsed = 0;
            Decimal compTimeUsed = 0;
            Decimal tVsTimeUsed = 0;
            Decimal projTimeUsed = 0;
            Decimal lightsTimeUsed = 0;
            Decimal numCompOn = 0;
            Decimal numTvsOn = 0;
            Decimal numProjOn = 0;
            Decimal numLightsOn = 0;

            numCompOn = Decimal.Parse(CompOnDropDownList.SelectedValue);
            numTvsOn = Decimal.Parse(TvsOnDropDownList.SelectedValue);
            numProjOn = Decimal.Parse(ProjOnDropDownList.SelectedValue);
            numLightsOn = Decimal.Parse(LightsOnDropDownList.SelectedValue);
            compWattsUsed = Decimal.Parse(CompWattsTextBox.Text);
            projectorWattsUsed = Decimal.Parse(ProjectorWattsUsedTextBox.Text);
            tVsWattsUsed = Decimal.Parse(TVsWattsTextBox.Text);
            lightsWattsUsed = Decimal.Parse(LightsWattsUsedTextBox.Text);

            compTimeUsed = Decimal.Parse(ComputersTimeTextBox.Text);

            projTimeUsed = Decimal.Parse(ProjectorTimeUsedTextBox.Text);

            tVsTimeUsed = Decimal.Parse(TVsTimeTextBox.Text);

            lightsTimeUsed = Decimal.Parse(LightsTimeUsedTextBox.Text);

            Decimal kWHCost = Decimal.Parse(CostPerKWHTextBox.Text);

            Decimal compKWHUsed = ((compWattsUsed * compTimeUsed) / 1000);
            Decimal projKWHUsed = ((projectorWattsUsed * projTimeUsed) / 1000);
            Decimal tVsKWHUsed = ((tVsWattsUsed * tVsTimeUsed) / 1000);
            Decimal lightsKWHUsed = ((lightsWattsUsed * lightsTimeUsed) / 1000);
            Decimal totalKWHUsed = (compKWHUsed * numCompOn) + (projKWHUsed * numProjOn) + (tVsKWHUsed * numTvsOn) + (lightsKWHUsed * numLightsOn);

            Decimal TotalCostEnergyUsed = (totalKWHUsed * kWHCost);


            // Format decimal value to two spaces after the decimal
            String TotalCostEnergyUsedString = String.Format("{0:C2}", TotalCostEnergyUsed);

            EnergyCostTextBox.Text = TotalCostEnergyUsedString.ToString() + "\u00A2";
        }

        protected void TvsOnDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Management.aspx");
        }

        public void SaveImage(string myString)
        {

            // THIS IS THE PATH FOR AN IMAGE
            // http://localhost:56840/Data/7567f9ab-a5af-4cab-9837-d4059a7df7f4.jpg

            String myImageLink = "";


            //String myImageLink = "<a href='http://localhost:56840/Data/" + myGuid + "'>hyperlink</a>";


            myImageLink = string.Format("<a href=http://localhost:56840/Data/{0}>putFriendlyNameHere</a>", myGuid);


            if (Request.QueryString["auditid"] == null)
            {
                // We are inserting
                Insert("insert into Audit (ImageLink, ImageName, CampusName, BuildingName, RoomName, ZoneName, NumberLightsOnID, NumberTvsOnID, NumberProjectorsOnID, NumberComputersOnID, ZoneID, CampusID, BuildingID, Image, EnergyUsed, Filter, AHUWaterLeak, AirLeak, Noise, VFD, InHand, Error, AHUOther, ComputersOn, TvsOn, ProjectorsOn, LabLightsOn, LabOther, HeadAdjustment, BrokenHead, IrrigationOnDayTime, IrrigationOnNightTime, ManualOverride, IrrigationWaterLeak, IrrigationOther, SecurityMode, Locked, LightsOnDayTime, LightsOnNightTime, BrokenBulb, ParkingLightsOther, TempTooCold, TempTooHot, ThermostatBroken, TempOther, MarqueeOnDayTime, MarqueeOnNightTime, BrokenPixels, MarqueeOther, WaterRunning, KitchenWaterLeak, KitchenLightsOn, FridgeOpen, FreezerOpen, KitchenOther, AHUNotes, ComputerLabNotes, KitchenNotes, IrrigationNotes, TemperatureNotes, MarqueeNotes, OtherNotes, ParkingLightsNotes, AuditName, AuditDate, AuditTypeID, AuditTypeName, RoomID, AuditorID, ParkingLotID, LotName, NumberComputersOn, NumberProjectorsOn, NumberTvsOn, NumberLightsOn) values ('" + myImageLink + "' ,'" + myString + "', '" + CampusDropDownList.SelectedItem + "', '" + BuildingDropDownList.SelectedItem + "','" + RoomListBox.SelectedItem + "','" + ZoneDropDownList.SelectedItem + "','" + LightsOnDropDownList.SelectedValue + "', '" + TvsOnDropDownList.SelectedValue + "' , '" + ProjOnDropDownList.SelectedValue + "', '" + CompOnDropDownList.SelectedValue + "', '" + ZoneDropDownList.SelectedValue + "'  , '" + CampusDropDownList.SelectedValue + "','" + BuildingDropDownList.SelectedValue + "', '" + ImageFileUpload.FileName + "' , '" + EnergyCostTextBox.Text + "', '" + AHUCheckBoxList.Items[0].Selected + "','" + AHUCheckBoxList.Items[1].Selected + "', '" + AHUCheckBoxList.Items[2].Selected + "','" + AHUCheckBoxList.Items[3].Selected + "','" + AHUCheckBoxList.Items[4].Selected + "', '" + AHUCheckBoxList.Items[5].Selected + "','" + AHUCheckBoxList.Items[6].Selected + "', '" + AHUCheckBoxList.Items[7].Selected + "','" + LabCheckBoxList.Items[0].Selected + "','" + LabCheckBoxList.Items[1].Selected + "','" + LabCheckBoxList.Items[2].Selected + "','" + LabCheckBoxList.Items[3].Selected + "','" + LabCheckBoxList.Items[4].Selected + "',  '" + IrrigationCheckBoxList.Items[0].Selected + "', '" + IrrigationCheckBoxList.Items[1].Selected + "', '" + IrrigationCheckBoxList.Items[2].Selected + "', '" + IrrigationCheckBoxList.Items[3].Selected + "', '" + IrrigationCheckBoxList.Items[4].Selected + "', '" + IrrigationCheckBoxList.Items[5].Selected + "', '" + IrrigationCheckBoxList.Items[6].Selected + "', '" + ParkingLightsCheckBoxList.Items[0].Selected + "', '" + ParkingLightsCheckBoxList.Items[1].Selected + "', '" + ParkingLightsCheckBoxList.Items[2].Selected + "', '" + ParkingLightsCheckBoxList.Items[3].Selected + "', '" + ParkingLightsCheckBoxList.Items[4].Selected + "', '" + ParkingLightsCheckBoxList.Items[5].Selected + "', '" + TempCheckBoxList.Items[0].Selected + "',  '" + TempCheckBoxList.Items[1].Selected + "', '" + TempCheckBoxList.Items[2].Selected + "', '" + TempCheckBoxList.Items[3].Selected + "', '" + MarqueeCheckBoxList.Items[0].Selected + "', '" + MarqueeCheckBoxList.Items[1].Selected + "', '" + MarqueeCheckBoxList.Items[2].Selected + "',  '" + MarqueeCheckBoxList.Items[3].Selected + "',   '" + KitchenCheckBoxList.Items[0].Selected + "', '" + KitchenCheckBoxList.Items[1].Selected + "',  '" + KitchenCheckBoxList.Items[2].Selected + "',  '" + KitchenCheckBoxList.Items[3].Selected + "',   '" + KitchenCheckBoxList.Items[4].Selected + "', '" + KitchenCheckBoxList.Items[5].Selected + "', '" + AHUTextBox.Text + "', '" + LabTextBox.Text + "', '" + KitchenTextBox.Text + "', '" + IrrigationTextBox.Text + "', '" + TempTextBox.Text + "', '" + MarqueeTextBox.Text + "', '" + OtherTextBox.Text + "',  '" + ParkingLightsTextBox.Text + "' , '" + NameDropDownList.SelectedItem + "', '" + Calendar1.TodaysDate + "','" + AuditDropDownList.SelectedValue + "', '" + AuditDropDownList.SelectedItem + "', '" + RoomListBox.SelectedValue + "','" + NameDropDownList.SelectedValue + "','" + ParkingLotDropDownList.SelectedValue + "','" + ParkingLotDropDownList.SelectedItem + "', '" + CompOnDropDownList.SelectedItem + "', '" + ProjOnDropDownList.SelectedItem + "', '" + TvsOnDropDownList.SelectedItem + "', '" + LightsOnDropDownList.SelectedItem + "');");

                // We are inserting ImageName into Image Table
                InsertImage("insert into Image (ImageName) values ( '" + myString + "' );");

            }
            else
            {
                // We are updating
                Insert("Update Audit Set ImageName = '" + myString + "', CampusName = '" + CampusDropDownList.SelectedItem + "', BuildingName = '" + BuildingDropDownList.SelectedItem + "', RoomName = '" + RoomListBox.SelectedItem + "', ZoneName = '" + ZoneDropDownList.SelectedItem + "', NumberLightsOnID = '" + LightsOnDropDownList.SelectedValue + "', NumberTvsOnID = '" + TvsOnDropDownList.SelectedValue + "', NumberProjectorsOnID = '" + ProjOnDropDownList.SelectedValue + "', NumberComputersOnID = '" + CompOnDropDownList.SelectedValue + "', ZoneID = '" + ZoneDropDownList.SelectedValue + "', CampusID = '" + CampusDropDownList.SelectedValue + " ', BuildingID = '" + BuildingDropDownList.SelectedValue + " ', Image =  '" + ImageFileUpload.FileName + "', AuditName = '" + NameDropDownList.SelectedItem + "', AuditTypeID = '" + AuditDropDownList.SelectedValue + "', AuditorID = '" + NameDropDownList.SelectedValue + "', EnergyUsed = '" + EnergyCostTextBox.Text + "', Filter = '" + AHUCheckBoxList.Items[0].Selected + "', AHUWaterLeak = '" + AHUCheckBoxList.Items[1].Selected + "' , AirLeak = '" + AHUCheckBoxList.Items[2].Selected + "', Noise = '" + AHUCheckBoxList.Items[3].Selected + "', VFD =  '" + AHUCheckBoxList.Items[4].Selected + "', InHand= '" + AHUCheckBoxList.Items[5].Selected + "', Error = '" + AHUCheckBoxList.Items[6].Selected + "', AHUOther = '" + AHUCheckBoxList.Items[7].Selected + "', ComputersOn =  '" + LabCheckBoxList.Items[0].Selected + "', TvsOn = '" + LabCheckBoxList.Items[1].Selected + "', ProjectorsOn = '" + LabCheckBoxList.Items[2].Selected + "', LabLightsOn = '" + LabCheckBoxList.Items[3].Selected + "', LabOther = '" + LabCheckBoxList.Items[4].Selected + "', HeadAdjustment = '" + IrrigationCheckBoxList.Items[0].Selected + "', BrokenHead = '" + IrrigationCheckBoxList.Items[1].Selected + "', IrrigationOnDayTime = '" + IrrigationCheckBoxList.Items[2].Selected + "', IrrigationOnNightTime = '" + IrrigationCheckBoxList.Items[3].Selected + "', ManualOverride = '" + IrrigationCheckBoxList.Items[4].Selected + "', IrrigationWaterLeak = '" + IrrigationCheckBoxList.Items[5].Selected + "', IrrigationOther = '" + IrrigationCheckBoxList.Items[6].Selected + "', SecurityMode = '" + ParkingLightsCheckBoxList.Items[0].Selected + "', Locked = '" + ParkingLightsCheckBoxList.Items[1].Selected + "', LightsOnDayTime = '" + ParkingLightsCheckBoxList.Items[2].Selected + "', LightsOnNightTime = '" + ParkingLightsCheckBoxList.Items[3].Selected + "', BrokenBulb = '" + ParkingLightsCheckBoxList.Items[4].Selected + "', ParkingLightsOther = '" + ParkingLightsCheckBoxList.Items[5].Selected + "', TempTooCold = '" + TempCheckBoxList.Items[0].Selected + "', TempTooHot = '" + TempCheckBoxList.Items[1].Selected + "',ThermostatBroken =  '" + TempCheckBoxList.Items[2].Selected + "', TempOther =  '" + TempCheckBoxList.Items[3].Selected + "', MarqueeOnDayTime = '" + MarqueeCheckBoxList.Items[0].Selected + "', MarqueeOnNightTime = '" + MarqueeCheckBoxList.Items[1].Selected + "', BrokenPixels = '" + MarqueeCheckBoxList.Items[2].Selected + "', MarqueeOther = '" + MarqueeCheckBoxList.Items[3].Selected + "', WaterRunning = '" + KitchenCheckBoxList.Items[0].Selected + "', KitchenWaterLeak = '" + KitchenCheckBoxList.Items[1].Selected + "', KitchenLightsOn = '" + KitchenCheckBoxList.Items[2].Selected + "', FridgeOpen = '" + KitchenCheckBoxList.Items[3].Selected + "', FreezerOpen = '" + KitchenCheckBoxList.Items[4].Selected + "', KitchenOther = '" + KitchenCheckBoxList.Items[5].Selected + "', AHUNotes = '" + AHUTextBox.Text + "', ComputerLabNotes = '" + LabTextBox.Text + "', KitchenNotes = '" + KitchenTextBox.Text + "', IrrigationNotes = '" + IrrigationTextBox.Text + "', TemperatureNotes = '" + TempTextBox.Text + "', MarqueeNotes = '" + MarqueeTextBox.Text + "', OtherNotes = '" + OtherTextBox.Text + "', ParkingLightsNotes = '" + ParkingLightsTextBox.Text + "'  ,  AuditDate = '" + Calendar1.TodaysDate + "',  AuditTypeName = '" + AuditDropDownList.SelectedItem + "', RoomID = '" + RoomListBox.SelectedValue + "',  ParkingLotID = '" + ParkingLotDropDownList.SelectedValue + "', LotName = '" + ParkingLotDropDownList.SelectedItem + "', NumberComputersOn = '" + CompOnDropDownList.SelectedItem + "', NumberProjectorsOn = '" + ProjOnDropDownList.SelectedItem + "', NumberTvsOn = '" + TvsOnDropDownList.SelectedItem + "', NumberLightsOn = '" + LightsOnDropDownList.SelectedItem + "'  Where AuditID = " + Request.QueryString["auditid"]);

                // We are updating ImageName in Image Table
                InsertImage("Update Image Set ImageName = '" + myString + "'  Where AuditID = " + Request.QueryString["auditid"]);

            }
        }

        public void InsertImage(string sql)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            command = new SqlCommand(sql, con);
            con.Open();
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
        }

        protected void NewAuditFormButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HomePage.aspx");
        }

    }
}



