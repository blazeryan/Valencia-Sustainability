using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace ValenciaSustainability
{
    public partial class NewLabWebForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ValenciaLocalDBConnectionString"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetBuilding();
            }
        }

        protected void LabRoomTextBox_TextChanged(object sender, EventArgs e)
        {


        }


        protected void InsertLabRoomButton_Click(object sender, EventArgs e)
        {

            String RoomNumber = null;
            String BuildingID = "";

            RoomNumber = LabRoomTextBox.Text;
            BuildingID = CampusDropDownList.SelectedValue;

            string connectionString = ConfigurationManager.ConnectionStrings["ValenciaLocalDBConnectionString"].ToString();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
              new System.Data.SqlClient.SqlConnection(connectionString);

            // get buildingID from database building table
            string get_buildingid;
            get_buildingid = BuildingDropDownList.SelectedValue.ToString();

            if (get_buildingid != "-1")
            {
                query = "Select BuildingID, BuildingNumber from Building where BuildingID='" + get_buildingid.ToString() + "'";
                da = new SqlDataAdapter(query, con);

                // Add room number record to database table
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT Room (RoomNumber, BuildingID ) VALUES ('" + RoomNumber + "', '" + get_buildingid + "' )";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();
            }

            // Test buildingID
            Response.Write(get_buildingid + "this is building id");
        }

        protected void BuildingDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CampusDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string get_campusid, get_campusname;
            get_campusid = CampusDropDownList.SelectedValue.ToString();
            get_campusname = CampusDropDownList.SelectedItem.Text;

            if (get_campusid != "-1")
            {
                query = "Select BuildingID, BuildingNumber from Building where CampusID='" + get_campusid.ToString() + "'";
                da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    BuildingDropDownList.DataSource = ds;
                    BuildingDropDownList.DataTextField = "BuildingNumber";
                    BuildingDropDownList.DataValueField = "BuildingID";
                    BuildingDropDownList.DataBind();
                    BuildingDropDownList.Items.Insert(0, new ListItem("Choose " + get_campusname.ToString() + " Building ", "0"));
                    BuildingDropDownList.SelectedIndex = 0;

                }
            }
        }


        public void GetBuilding()
        {
            query = "Select * from Campus";
            da = new SqlDataAdapter(query, con);

            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                CampusDropDownList.DataSource = ds;
                CampusDropDownList.DataTextField = "CampusName";
                CampusDropDownList.DataValueField = "CampusID";
                CampusDropDownList.DataBind();
                CampusDropDownList.SelectedIndex = 0;
            }
        }

        protected void CmpusSqlDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void LabRoomTextBox_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void CampusDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Campus_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {


        }

        protected void Building_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void Campus_Selecting1(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}
