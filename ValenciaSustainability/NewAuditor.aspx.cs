using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValenciaSustainability
{
    public partial class NewAuditor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            String firstName = null;
            String middleName = null;
            String lastName = null;
            String email = null;
            String phoneNumber = null;

            firstName = FirstNameTextBox.Text;
            middleName = MiddleNameTextBox.Text;
            lastName = LastNameTextBox.Text;
            email = EmailTextBox.Text;
            phoneNumber = PhoneNumberTextBox.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["ValenciaLocalDBConnectionString"].ToString();

            System.Data.SqlClient.SqlConnection sqlConnection1 =
              new System.Data.SqlClient.SqlConnection(connectionString);

            // Add TextBoxString to DB Table
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Auditor (AuditorFirstName, AuditorMiddleName, AuditorLastName, AuditorEmail, AuditorPhoneNumber) VALUES ('" + firstName + "', '" + middleName + "', '" + lastName + "', '" + email + "', '" + phoneNumber + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        protected void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void MiddleNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}