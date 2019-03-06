using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomerMaintenanceClasses;

namespace CustomerMaintenance
{
    // This is the starting point for exercise 12-1 from
    // "Murach's C# 2010" by Joel Murach
    // (c) 2010 by Mike Murach & Associates, Inc. 
    // www.murach.com

    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, System.EventArgs e)
        {

        }

        // Declare a method to iterate through each customer in list and add display text to list box
        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add(customer.GetDisplayText() + "\t");
            }
        }

        private List<Customer> customers = null;

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}