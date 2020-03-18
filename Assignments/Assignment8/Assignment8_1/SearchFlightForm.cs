using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Assignment8_1
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
            string databasePath = System.IO.Directory.GetCurrentDirectory() + @"\Database.accdb";

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbDataReader reader;

            OleDbCommand commandCustomers = new OleDbCommand("SELECT * from  Customers", connection);
            OleDbCommand commandFlights = new OleDbCommand("SELECT * from  Flights", connection);

            reader = commandCustomers.ExecuteReader();

            Customer customerBuffer;
            while (reader.Read())
            {
                string id = reader.GetFieldValue<int>(0).ToString();
                string name = reader.GetFieldValue<string>(1);
                string flightId = reader.GetFieldValue<string>(2);

                customerBuffer = new Customer(id, name, flightId);

                customerList.Add(customerBuffer);
            }

            reader = commandFlights.ExecuteReader();

            Flight flightBuffer;
            while (reader.Read())
            {
                string id = reader.GetFieldValue<int>(0).ToString();
                string company = reader.GetFieldValue<string>(1);
                string origin = reader.GetFieldValue<string>(2);
                string destination = reader.GetFieldValue<string>(3);
                string date = reader.GetFieldValue<string>(4);

                flightBuffer = new Flight(id, company, origin, destination, date);

                flightList.Add(flightBuffer);
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
