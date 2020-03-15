using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Assignment7_1
{
    public partial class ModifyFlightForm : Form
    {
        List<Flight> flightList = new List<Flight>();

        private string flightFilePath = System.IO.Directory.GetCurrentDirectory() + @"\flights.json";
        private DataContractJsonSerializer jsonSerializer;

        public ModifyFlightForm()
        {
            InitializeComponent();
            Load += ModifyFlightForm_Load;
        }

        private void ModifyFlightForm_Load(object sender, EventArgs e)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();

            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;

            jsonSerializer = new DataContractJsonSerializer(typeof(List<Flight>), serializingSettings);

            StreamReader reader = new StreamReader(flightFilePath);
            string flightJsonData = reader.ReadToEnd();
            reader.Close();

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();

            if (jsSerializer.Deserialize<List<Flight>>(flightJsonData) != null)
            {
                flightList = jsSerializer.Deserialize<List<Flight>>(flightJsonData);
            }
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

            flightList.Add(newFlight);

            FileStream fileWriter = new FileStream(flightFilePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, flightList);
            fileWriter.Close();

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

            Flight flightToUpdate = flightList.Find((Flight flight) => (
                flight.id.Equals(updateFlightId)
            ));

            if (flightToUpdate != null)
            {
                flightList.RemoveAll((Flight flight) => (
                    flight.id.Equals(updateFlightId)
                ));

                flightToUpdate.company = updateFlightCompanyName;
                flightToUpdate.origin = updateFlightOrigin;
                flightToUpdate.destination = updateFlightDestination;
                flightToUpdate.date = updateFlightDate;

                flightList.Add(flightToUpdate);

                FileStream fileWriter = new FileStream(flightFilePath, FileMode.Create);
                jsonSerializer.WriteObject(fileWriter, flightList);
                fileWriter.Close();

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

            if (flightList.Exists((Flight flight) => flight.id.Equals(removeFlightId)))
            {
                flightList.RemoveAll((Flight flight) => (
                    flight.id.Equals(removeFlightId)
                ));

                FileStream fileWriter = new FileStream(flightFilePath, FileMode.Create);
                jsonSerializer.WriteObject(fileWriter, flightList);
                fileWriter.Close();

                removeFlightIdTextBox.Text = "";

                MessageBox.Show("Removed flight with id: " + removeFlightId);
            } else
            {
                MessageBox.Show("Flight with id: " + removeFlightId + " was not found!");
            }
        }
    }
}
