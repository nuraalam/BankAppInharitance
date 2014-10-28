using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAppinheritance
{
    public partial class BankAppUI : Form
    {
        private SavingAccount aSavingAccount;
        private CheeckingAccount aCheeckingAccount;
      
       

        public BankAppUI()
        {
            InitializeComponent();
        }

        private void savingAccountCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                aSavingAccount = new SavingAccount(Convert.ToInt32(savingAccountNumberTextBox.Text), Convert.ToDouble(interestRateTextBox.Text));
                MessageBox.Show("Saving Account has been Created");
            }
            catch (Exception)
            {
                MessageBox.Show("Fill the field accordingly");
               
            }
           
        }

        private void cheeckingAccountCreateButton_Click(object sender, EventArgs e)
        {

            try
            {
                aCheeckingAccount = new CheeckingAccount(Convert.ToInt32(cheeckingAccountNumberTextBox.Text), Convert.ToDouble(serviceChargeTextBox.Text));
                MessageBox.Show("Cheecking Account has been created");
            }
            catch (Exception)
            {

                MessageBox.Show("Please fill the field accordingly");
            }
           
        }

        private void doItButton_Click(object sender, EventArgs e)
        {
            if (selectAccountComboBox.Text=="Cheecking Account"&&aCheeckingAccount == null)
            {
                MessageBox.Show("Please create a cheecking account first");
                return;
            }
            if (selectAccountComboBox.Text=="Saving Account"&&aSavingAccount == null)
            {
                MessageBox.Show("Please create a saving account first");
                return;
            }
           string msg="Please checked deposite or withdraw button ";
            try
            {
                if (depositeRadioButton.Checked)
                {
                    msg = Deposite(Convert.ToDouble(amountTextBox.Text), selectAccountComboBox.Text);
                    
                }
                if(withdrawRadioButton.Checked)
                {
                    msg = Withdraw(Convert.ToDouble(amountTextBox.Text), selectAccountComboBox.Text);
                   
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please put the numbers in amount field");

            }
            MessageBox.Show(msg);
            
        }
        public string Deposite(double amount, string text)
        {
            if (text == "Saving Account")
            {

                aSavingAccount.Deposite(amount);
               
                aSavingAccount.InterestRate = (aSavingAccount.Balance * aSavingAccount.InterestRate) / 100;
               
                

            }
            if (text == "Cheecking Account")
            {
                
                aCheeckingAccount.Deposite(amount-aCheeckingAccount.ServiceCharge);
                aCheeckingAccount.NoOfTransaction++;

            }
            if (text=="")
            {
                return "Please select the account first";
                
            }
            return amount + "tk has been deposited";

        }
        public string Withdraw(double amount, string text)
        {
            if (text == "Saving Account")
            {

                if (!aSavingAccount.Withdraw(amount))
                    return "You balance will be lower than 1000";
            }

            if (text == "Cheecking Account")
            {
               
                if(!aCheeckingAccount.Withdraw(amount+aCheeckingAccount.ServiceCharge))
                    return "You balance will be lower than 0";
            }
            return amount + "tk has been withdrawn";

        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            string msgDisplay="";
            try
            {
                msgDisplay = "Saving Acc Number: " + aSavingAccount.AccountNumber + ",   Balance: " + aSavingAccount.Balance +
                                                  ",    Interest Amount: " + aSavingAccount.InterestRate;
              
            }
            catch (Exception exceptionObj)
            {

                msgDisplay = "No saving Account";
            }
            try
            {
                msgDisplay += ",    Cheecking Acc Number: " + aCheeckingAccount.AccountNumber + ",  Balance: " +
                                           aCheeckingAccount.Balance+", No of Transaction: "+aCheeckingAccount.NoOfTransaction;
            }
            catch (Exception)
            {
                
                msgDisplay+=",   No Cheecking Account";
            }
           
            displayTextBox.Text = msgDisplay;
        }

    }
}
