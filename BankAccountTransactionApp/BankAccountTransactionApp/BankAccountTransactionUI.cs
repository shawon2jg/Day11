using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountTransactionApp
{
    public partial class BankAccountTransactionUI : Form
    {
        private Customer aCustomer;
        //private double getDeposit;
        private double amount;
        public BankAccountTransactionUI()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            Customer aCustomer = new Customer(accountNumberTextBox.Text, customerNameTextBox.Text);
            MessageBox.Show("Account Created Successfully!");
        }
        
        private void depositeButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);
            
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(amountTextBox.Text);

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aCustomer.GetReport());
        }
    }
}
