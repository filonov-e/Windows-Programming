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
    public partial class ModifyCustomerForm : Form
    {
        List<Customer> customerList = new List<Customer>();

        private string customerFilePath = System.IO.Directory.GetCurrentDirectory() + @"\customers.json";
        private DataContractJsonSerializer jsonSerializer;

        public ModifyCustomerForm()
        {
            InitializeComponent();
            Load += ModifyCustomerForm_Load;
        }

        public void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            var serializingSettings = new DataContractJsonSerializerSettings();

            serializingSettings.UseSimpleDictionaryFormat = true;
            serializingSettings.DateTimeFormat = new DateTimeFormat("d.M.yyyy");
            serializingSettings.MaxItemsInObjectGraph = 1000;

            jsonSerializer = new DataContractJsonSerializer(typeof(List<Customer>), serializingSettings);

            StreamReader reader = new StreamReader(customerFilePath);
            string customerJsonData = reader.ReadToEnd();
            reader.Close();

            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();

            if (jsSerializer.Deserialize<List<Customer>>(customerJsonData) != null)
            {
                customerList = jsSerializer.Deserialize<List<Customer>>(customerJsonData);
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string newCustomerId = addCustomerIdTextBox.Text;
            string newCustomerName = addCustomerNameTextBox.Text;
            string newCustomerFlightId = addCustomerFlightIdTextBox.Text;

            Customer newCustomer = new Customer(newCustomerId, newCustomerName, newCustomerFlightId);

            customerList.Add(newCustomer);

            FileStream fileWriter = new FileStream(customerFilePath, FileMode.Create);
            jsonSerializer.WriteObject(fileWriter, customerList);
            fileWriter.Close();

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

            Customer customerToUpdate = customerList.Find((Customer customer) => (
                customer.id.Equals(updateCustomerId)
            ));

            if (customerToUpdate != null)
            {
                customerList.RemoveAll((Customer customer) => (
                    customer.id.Equals(updateCustomerId)
                ));

                customerToUpdate.name = updateCustomerName;
                customerToUpdate.flightId = updateCustomerFlightId;

                customerList.Add(customerToUpdate);

                FileStream fileWriter = new FileStream(customerFilePath, FileMode.Create);
                jsonSerializer.WriteObject(fileWriter, customerList);
                fileWriter.Close();

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

            if (customerList.Exists((Customer customer) => customer.id.Equals(removeCustomerId)))
            {
                customerList.RemoveAll((Customer customer) => (
                    customer.id.Equals(removeCustomerId)
                ));

                FileStream fileWriter = new FileStream(customerFilePath, FileMode.Create);
                jsonSerializer.WriteObject(fileWriter, customerList);
                fileWriter.Close();

                removeCustomerIdTextBox.Text = "";

                MessageBox.Show("Removed customer with id: " + removeCustomerId);
            } else
            {
                MessageBox.Show("Customer with id: " + removeCustomerId + " was not found!");
            }
        }
    }
}
