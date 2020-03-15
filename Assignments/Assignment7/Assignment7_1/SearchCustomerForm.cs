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
    public partial class SearchCustomerForm : Form
    {
        List<Customer> customerList = new List<Customer>();
        List<Flight> flightList = new List<Flight>();
        
        public SearchCustomerForm()
        {
            InitializeComponent();
            Load += SearchCustomerForm_Load;
        }

        private void SearchCustomerForm_Load(object sender, EventArgs e)
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

            searchCustomerDataGridView.DataSource = customerList;
            searchCustomerFlightDataGridView.DataSource = flightList;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchCustomerId = searchTextBox.Text;

            List<Customer> customerSearchResults = customerList.FindAll((Customer customer) => {
                return customer.id.Equals(searchCustomerId);
            });

            List<Flight> customerFlightSearchResults = flightList.FindAll((Flight flight) => {
                return customerSearchResults.Any((Customer customer) => {
                    return flight.id.Equals(customer.flightId);
                });
            });

            searchCustomerDataGridView.DataSource = customerSearchResults;
            searchCustomerFlightDataGridView.DataSource = customerFlightSearchResults;
        }

        private void clearCustomerSearchButton_Click(object sender, EventArgs e)
        {
            searchCustomerDataGridView.DataSource = customerList;
            searchCustomerFlightDataGridView.DataSource = flightList;

            searchTextBox.Text = "";
        }
    }
}
