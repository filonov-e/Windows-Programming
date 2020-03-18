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
    public partial class ModifyCustomerForm : Form
    {
        private string databasePath = System.IO.Directory.GetCurrentDirectory() + @"\Database.accdb";
        
        public ModifyCustomerForm()
        {
            InitializeComponent();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string newCustomerId = addCustomerIdTextBox.Text;
            string newCustomerName = addCustomerNameTextBox.Text;
            string newCustomerFlightId = addCustomerFlightIdTextBox.Text;

            Customer newCustomer = new Customer(newCustomerId, newCustomerName, newCustomerFlightId);

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbCommand commandInsertCustomer = new OleDbCommand(
                "INSERT INTO Customers (ID, customer_name, customer_flight_id) VALUES (@id, @name, @flightId)", 
                connection
            );

            commandInsertCustomer.Parameters.AddWithValue("@id", int.Parse(newCustomer.id));
            commandInsertCustomer.Parameters.AddWithValue("@name", newCustomer.name);
            commandInsertCustomer.Parameters.AddWithValue("@flightId", newCustomer.flightId);

            commandInsertCustomer.ExecuteNonQuery();

            addCustomerIdTextBox.Text = "";
            addCustomerNameTextBox.Text = "";
            addCustomerFlightIdTextBox.Text = "";

            MessageBox.Show("Added customer with id: " + newCustomerId);
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            string updateCustomerId = updateCustomerIdTextBox.Text;
            string updateCustomerName = updateCustomerNameTextBox.Text;
            string updateCustomerFlightId = updateCustomerFlightIdTextBox.Text;

            Customer customerToUpdate = new Customer(updateCustomerId, updateCustomerName, updateCustomerFlightId);

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbCommand commandUpdateCustomer = new OleDbCommand(
                "UPDATE Customers SET customer_name = @name, customer_flight_id = @flightId WHERE ID = @id",
                connection
            );

            commandUpdateCustomer.Parameters.AddWithValue("@name", customerToUpdate.name);
            commandUpdateCustomer.Parameters.AddWithValue("@flightId", customerToUpdate.flightId);
            commandUpdateCustomer.Parameters.AddWithValue("@id", int.Parse(customerToUpdate.id));

            int rowsAffected = commandUpdateCustomer.ExecuteNonQuery();

            if (rowsAffected != 0)
            {
                updateCustomerIdTextBox.Text = "";
                updateCustomerNameTextBox.Text = "";
                updateCustomerFlightIdTextBox.Text = "";

                MessageBox.Show("Updated customer with id: " + updateCustomerId);
            } else
            {
                MessageBox.Show("Customer with id: " + updateCustomerId + " was not found!");
            }
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            string removeCustomerId = removeCustomerIdTextBox.Text;

            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + databasePath);

            connection.Open();

            OleDbCommand commandDeleteCustomer = new OleDbCommand(
                "DELETE FROM Customers WHERE ID = @id",
                connection
            );

            commandDeleteCustomer.Parameters.AddWithValue("@id", int.Parse(removeCustomerId));

            int rowsAffected = commandDeleteCustomer.ExecuteNonQuery();

            if (rowsAffected != 0)
            {
                removeCustomerIdTextBox.Text = "";

                MessageBox.Show("Removed customer with id: " + removeCustomerId);
            } else
            {
                MessageBox.Show("Customer with id: " + removeCustomerId + " was not found!");
            }
        }
    }
}
