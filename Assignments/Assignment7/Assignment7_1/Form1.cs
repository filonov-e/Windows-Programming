using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            SearchCustomerForm searchCustomerForm = new SearchCustomerForm();
            searchCustomerForm.Show();
        }

        private void modifyCustomerButton_Click(object sender, EventArgs e)
        {
            ModifyCustomerForm modifyCustomerForm = new ModifyCustomerForm();
            modifyCustomerForm.Show();
        }

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            SearchFlightForm searchFlightForm = new SearchFlightForm();
            searchFlightForm.Show();
        }

        private void modifyFlightButton_Click(object sender, EventArgs e)
        {
            ModifyFlightForm modifyFlightForm = new ModifyFlightForm();
            modifyFlightForm.Show();
        }
    }
}
