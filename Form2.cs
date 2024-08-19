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
    public partial class Form2 : Form
    {
        public Form2(string customerName, double lastMonthReading, double thisMonthReading, double consumption, int totalMoneyInt)
        {
            InitializeComponent();
            tbxCustomerName.Text = customerName;
            tbxLastMonthReading.Text = lastMonthReading + " m³";
            tbxThisMonthReading.Text = thisMonthReading + " m³";
            tbxConsumption.Text = consumption + " m³";
            tbxAmountNeedToPaid.Text = totalMoneyInt + " VND";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
