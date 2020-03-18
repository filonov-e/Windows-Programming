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
