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
    public partial class SearchFlightForm : Form
    {
        List<Customer> customerList = new List<Customer>();
        List<Flight> flightList = new List<Flight>();

        public SearchFlightForm()
        {
            InitializeComponent();
            Load += SearchFlightForm_Load;
        }

        private void SearchFlightForm_Load(object sender, EventArgs e)
        {
            string customerFilePath = System.IO.Directory.GetCurrentDirectory() + @"\customers.json";
            string flightFilePath = System.IO.Directory.GetCurrentDirectory() + @"\flights.json";

            var serializingSettings = new DataContractJsonSerializerSettings();

            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;

            StreamReader reader = new StreamReader(customerFilePath);
            string customerJsonData = reader.ReadToEnd();
            reader.Close();

            reader = new StreamReader(flightFilePath);
            string flightJsonData = reader.ReadToEnd();
            reader.Close();

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();

            if (jsSerializer.Deserialize<List<Customer>>(customerJsonData) != null)
            {
                customerList = jsSerializer.Deserialize<List<Customer>>(customerJsonData);
            }

            if (jsSerializer.Deserialize<List<Flight>>(flightJsonData) != null)
            {
                flightList = jsSerializer.Deserialize<List<Flight>>(flightJsonData);
            }

            searchFlightDataGridView.DataSource = flightList;
            searchFlightCustomerDataGridView.DataSource = customerList;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchFlightId = searchTextBox.Text;

            List<Flight> flightSearchResults = flightList.FindAll((Flight flight) => {
                return flight.id.Equals(searchFlightId);
            });

            List<Customer> flightCustomerSearchResults = customerList.FindAll((Customer customer) => {
                return flightSearchResults.Any((Flight flight) => {
                    return customer.flightId.Equals(flight.id);
                });
            });

            searchFlightDataGridView.DataSource = flightSearchResults;
            searchFlightCustomerDataGridView.DataSource = flightCustomerSearchResults;
        }

        private void clearFlightSearchButton_Click(object sender, EventArgs e)
        {
            searchFlightDataGridView.DataSource = flightList;
            searchFlightCustomerDataGridView.DataSource = customerList;

            searchTextBox.Text = "";
        }
    }
}
