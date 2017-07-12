using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ValenciaSustainability
{

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TestValenciaDataBaseConnection();
        }

        public void TestValenciaDataBaseConnection()
        {

            string connectionString = ConfigurationManager.ConnectionStrings["ValenciaConnection"].ToString();

            // describe what to get from the database
            //      for example:  select * from Campus will get the entire Campus Database
            string selectStatement = "select * from Campus;";


            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(selectStatement, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var s = string.Format(@"<br/>{0}", reader[0]);

                        Response.Write(s);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }


        public void ClearForm(CheckBoxList control)
        {
            CheckBoxList myControl = control;

            myControl.ClearSelection();
        }

       

    }
}
