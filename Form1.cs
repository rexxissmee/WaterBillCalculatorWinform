using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBillCalculatorWinform
{
    public partial class Form1 : Form
    {
        public List<Invoice> invoices = new List<Invoice>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Add item to combo box
            cbbCustomerType.Items.Add("Please select customer type");
            cbbCustomerType.Items.Add("Household customer");
            cbbCustomerType.Items.Add("Administrative agency, public services");
            cbbCustomerType.Items.Add("Production units");
            cbbCustomerType.Items.Add("Business services");
            cbbCustomerType.SelectedIndex = 0;

            //Add column to listview
            lvwWaterBill.View = View.Details;
            lvwWaterBill.Columns.Add("Customer name", 125, HorizontalAlignment.Center);
            lvwWaterBill.Columns.Add("Last month's water meter reading", 250, HorizontalAlignment.Center);
            lvwWaterBill.Columns.Add("This month's water meter reading", 250, HorizontalAlignment.Center);
            lvwWaterBill.Columns.Add("Consumption", 125, HorizontalAlignment.Center);
            lvwWaterBill.Columns.Add("Total water bill", 120, HorizontalAlignment.Center);

            //Update show button state
            UpdateShowButtonState();
        }

        //Enable number of people
        private void cbbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = cbbCustomerType.Text;
            if (customerType == "Household customer")
            {
                tbxNumOfPeople.Enabled = true;
            }
            else
            {
                tbxNumOfPeople.Enabled = false;
                tbxNumOfPeople.Text = "";
            }
        }

        //Clear input data
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCustomerName.Clear();
            tbxNumOfPeople.Clear();
            tbxLastMonthReading.Clear();
            tbxThisMonthReading.Clear();
            cbbCustomerType.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare variables
            string customerName = tbxCustomerName.Text.Trim();
            string customerType = cbbCustomerType.Text;
            int numOfPeople;
            double lastMonthReading;
            double thisMonthReading;

            //Validation check
            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (customerType == "Please select customer type")
            {
                MessageBox.Show("Please select customer type!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbxNumOfPeople.Text == "" && customerType == "Household customer")
            {
                MessageBox.Show("Please enter number of people!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!int.TryParse(tbxNumOfPeople.Text, out numOfPeople) && customerType == "Household customer" || numOfPeople <= 0 && customerType == "Household customer")
            {
                MessageBox.Show("Invalid number of people, please try again!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbxLastMonthReading.Text == "")
            {
                MessageBox.Show("Please enter last month water meter reading!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(tbxLastMonthReading.Text, out lastMonthReading) || lastMonthReading < 0)
            {
                MessageBox.Show("Invalid last month water meter reading, please try again!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (tbxThisMonthReading.Text == "")
            {
                MessageBox.Show("Please enter this month water meter reading!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!double.TryParse(tbxThisMonthReading.Text, out thisMonthReading) || thisMonthReading <= lastMonthReading)
            {
                MessageBox.Show("Invalid this month water meter reading, please try again!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Show result
            var waterBill = Calculator (customerType, numOfPeople, lastMonthReading, thisMonthReading);                        
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthReading.ToString());
            item.SubItems.Add(thisMonthReading.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvwWaterBill.Items.Add(item);

            //Update show button state
            UpdateShowButtonState();

            //Store data
            Invoice data = new Invoice
            {
                CustomerName = customerName,
                LastMonthReading = lastMonthReading,
                ThisMonthReading = thisMonthReading,
                Consumption = waterBill.Item1,
                TotalMoneyInt = (int)waterBill.Item2,
            };
            invoices.Add(data);
        }

        //Calculate
        private (double, double) Calculator (string customerType, int numberOfPeople, double lastMonthReading, double thisMonthReading)
        {
            double consumption = thisMonthReading - lastMonthReading;
            double waterMoney = 0;

            switch (customerType)
            {
                case "Household customer":
                    double averageConsump = consumption / numberOfPeople;
                    if (averageConsump < 10)
                    {
                        waterMoney = consumption * 5973;
                    }
                    else if (averageConsump >= 10 && averageConsump < 20)
                    {
                        waterMoney = consumption * 7052;
                    }
                    else if (averageConsump >= 20 && averageConsump < 30)
                    {
                        waterMoney = consumption * 8699;
                    }
                    else
                    {
                        waterMoney = consumption * 15929;
                    }
                    break;
                case "Administrative agency, public services":
                    waterMoney = consumption * 9955;
                    break;
                case "Production units":
                    waterMoney = consumption * 11615;
                    break;
                case "Business services":
                    waterMoney = consumption * 22068;
                    break;
            }

            double totalMoney = (waterMoney * 1.1) * 1.1;   //(Water money + 10% (Environment protection fees)) + 10% (VAT)
            int totalMoneyInt = (int)totalMoney;
            return (consumption, totalMoneyInt);
        }

        //Update show button state
        private void UpdateShowButtonState()
        {
            btnShowDetail.Enabled = lvwWaterBill.Items.Count > 0;
        }

        //Show detail bill
        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            if (lvwWaterBill.SelectedItems.Count > 0)
            {
                int selectedIndex = lvwWaterBill.SelectedItems[0].Index;
                Invoice selectedInvoice = invoices[selectedIndex];

                // Pass data to Form2
                Form2 form2 = new Form2
                    (
                    selectedInvoice.CustomerName,
                    selectedInvoice.LastMonthReading,
                    selectedInvoice.ThisMonthReading,
                    selectedInvoice.Consumption,
                    selectedInvoice.TotalMoneyInt
                    );
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please select a water bill to show detail!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void lvwWaterBill_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvwWaterBill.SelectedItems.Count > 0)
            {
                int selectedIndex = lvwWaterBill.SelectedItems[0].Index;
                Invoice selectedInvoice = invoices[selectedIndex];

                // Pass data to Form2
                Form2 form2 = new Form2
                (
                    selectedInvoice.CustomerName,
                    selectedInvoice.LastMonthReading,
                    selectedInvoice.ThisMonthReading,
                    selectedInvoice.Consumption,
                    selectedInvoice.TotalMoneyInt
                );
                form2.Show();
            }
        }

        //Search
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string target = tbxSearch.Text.ToLower().Trim();
            lvwWaterBill.Items.Clear();
            bool searchState = false;

            if (target == "")
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthReading.ToString());
                    item.SubItems.Add(invoice.ThisMonthReading.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.TotalMoneyInt.ToString());
                    lvwWaterBill.Items.Add(item);                    
                }
                searchState = true;
            }
            else
            {
                foreach (Invoice invoice in invoices)
                {   if (invoice.CustomerName.ToLower().Contains(target))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthReading.ToString());
                        item.SubItems.Add(invoice.ThisMonthReading.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.TotalMoneyInt.ToString());
                        lvwWaterBill.Items.Add(item);
                        searchState = true;
                    }                    
                }
            }            

            if (!searchState)
            {
                ListViewItem item = new ListViewItem("No result");
                lvwWaterBill.Items.Add(item);
            }
        }

        //Sorting menu
        private void btnSortName_Click(object sender, EventArgs e)
        {
            cmsSortName.Show(btnSortName, new Point(7, btnSortName.Height));
        }
        private void btnSortConsump_Click(object sender, EventArgs e)
        {
            cmsSortConsump.Show(btnSortConsump, new Point(0, btnSortConsump.Height));
        }
        private void btnSortTotalBill_Click(object sender, EventArgs e)
        {
            cmsSortTotalBill.Show(btnSortTotalBill, new Point(-15, btnSortTotalBill.Height));
        }

        //Sort data
        private void AToZName(object sender, EventArgs e)
        {
            invoices = invoices.OrderBy(invoice => invoice.CustomerName).ToList();
            UpdateListView();
        }
        private void ZToAName(object sender, EventArgs e)
        {
            invoices = invoices.OrderByDescending(invoice => invoice.CustomerName).ToList();
            UpdateListView();
        }
        private void LowToHighConsump(object sender, EventArgs e)
        {
            invoices = invoices.OrderBy(invoice => invoice.Consumption).ToList();
            UpdateListView();
        }
        private void HighToLowConsump(object sender, EventArgs e)
        {
            invoices = invoices.OrderByDescending(invoice => invoice.Consumption).ToList();
            UpdateListView();
        }
        private void LowToHighTotalBill(object sender, EventArgs e)
        {
            invoices = invoices.OrderBy(invoice => invoice.TotalMoneyInt).ToList();
            UpdateListView();
        }
        private void HighToLowTotalBill(object sender, EventArgs e)
        {
            invoices = invoices.OrderByDescending(invoice => invoice.TotalMoneyInt).ToList();
            UpdateListView();
        }

        //Update listview
        private void UpdateListView()
        {
            lvwWaterBill.Items.Clear();
            foreach (Invoice invoice in invoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthReading.ToString());
                item.SubItems.Add(invoice.ThisMonthReading.ToString());
                item.SubItems.Add(invoice.Consumption.ToString());
                item.SubItems.Add(invoice.TotalMoneyInt.ToString());
                lvwWaterBill.Items.Add(item);
            }
        }
    }

    public class Invoice
    {
        public string CustomerName { get; set; }
        public double LastMonthReading {get; set; }
        public double ThisMonthReading {get; set; }
        public double Consumption {get; set; }
        public int TotalMoneyInt {get; set; }
    }
}
