using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Assignment8_1
{
    public partial class ModifyFlightForm : Form
    {
        private string databasePath = System.IO.Directory.GetCurrentDirectory() + @"\Database.accdb";

        public ModifyFlightForm()
        {
            InitializeComponent();
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            string newFlightId = addFlightIdTextBox.Text;
            string newFlightCompanyName = addFlightCompanyNameTextBox.Text;
            string newFlightOrigin = addFlightOriginTextBox.Text;
            string newFlightDestination = addFlightDestinationTextBox.Text;
            string newFlightDate = addFlightDateTextBox.Text;

            Flight newFlight = new Flight(
                newFlightId, 
                newFlightCompanyName, 
                newFlightOrigin,
                newFlightDestination,
                newFlightDate
            );

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbCommand commandInsertFlight = new OleDbCommand(
                "INSERT INTO Flights (ID, flight_company, flight_origin, flight_destination, flight_date) VALUES (@id, @company, @origin, @destination, @date)",
                connection
            );

            commandInsertFlight.Parameters.AddWithValue("@id", int.Parse(newFlight.id));
            commandInsertFlight.Parameters.AddWithValue("@company", newFlight.company);
            commandInsertFlight.Parameters.AddWithValue("@origin", newFlight.origin);
            commandInsertFlight.Parameters.AddWithValue("@destination", newFlight.destination);
            commandInsertFlight.Parameters.AddWithValue("@date", newFlight.date);

            commandInsertFlight.ExecuteNonQuery();

            addFlightIdTextBox.Text = "";
            addFlightCompanyNameTextBox.Text = "";
            addFlightOriginTextBox.Text = "";
            addFlightDestinationTextBox.Text = "";
            addFlightDateTextBox.Text = "";

            MessageBox.Show("Added flight with id: " + newFlightId);
        }

        private void updateFlightButton_Click(object sender, EventArgs e)
        {
            string updateFlightId = updateFlightIdTextBox.Text;
            string updateFlightCompanyName = updateFlightCompanyNameTextBox.Text;
            string updateFlightOrigin = updateFlightOriginTextBox.Text;
            string updateFlightDestination = updateFlightDestinationTextBox.Text;
            string updateFlightDate = updateFlightDateTextBox.Text;

            Flight flightToUpdate = new Flight(
                updateFlightId,
                updateFlightCompanyName,
                updateFlightOrigin,
                updateFlightDestination,
                updateFlightDate
            );

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbCommand commandUpdateFlight = new OleDbCommand(
                "UPDATE Flights SET flight_company = @company, flight_origin = @origin, flight_destination = @destination, flight_date = @date WHERE ID = @id",
                connection
            );

            commandUpdateFlight.Parameters.AddWithValue("@company", flightToUpdate.company);
            commandUpdateFlight.Parameters.AddWithValue("@origin", flightToUpdate.origin);
            commandUpdateFlight.Parameters.AddWithValue("@destination", flightToUpdate.destination);
            commandUpdateFlight.Parameters.AddWithValue("@date", flightToUpdate.date);
            commandUpdateFlight.Parameters.AddWithValue("@id", int.Parse(flightToUpdate.id));

            int rowsAffected = commandUpdateFlight.ExecuteNonQuery();

            if (rowsAffected != 0)
            {
                updateFlightIdTextBox.Text = "";
                updateFlightCompanyNameTextBox.Text = "";
                updateFlightOriginTextBox.Text = "";
                updateFlightDestinationTextBox.Text = "";
                updateFlightDateTextBox.Text = "";

                MessageBox.Show("Updated flight with id: " + updateFlightId);
            } else
            {
                MessageBox.Show("Flight with id: " + updateFlightId + " was not found!");
            }
        }

        private void removeFlightButton_Click(object sender, EventArgs e)
        {
            string removeFlightId = removeFlightIdTextBox.Text;

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbCommand commandDeleteFlight = new OleDbCommand(
                "DELETE FROM Flights WHERE ID = @id",
                connection
            );

            commandDeleteFlight.Parameters.AddWithValue("@id", int.Parse(removeFlightId));

            int rowsAffected = commandDeleteFlight.ExecuteNonQuery();

            if (rowsAffected != 0)
            {
                removeFlightIdTextBox.Text = "";

                MessageBox.Show("Removed flight with id: " + removeFlightId);
            } else
            {
                MessageBox.Show("Flight with id: " + removeFlightId + " was not found!");
            }
        }
    }
}
