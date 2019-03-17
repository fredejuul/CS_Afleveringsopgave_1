using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afleveringsopgave_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Constants for calculations
            const double SaleFromShopvisitsPercent = 0.20;
            const int TicketPriceAvg = 175;
            const int SaleBeverageAvg = 70;
            const int SaleSportsGoodsAvg = 245;
            const int SubscriptionPrice6Months = 999;
            const int TvRightsPerChannel = 1000000;
            const double TotalCostsPercent = 0.64;

            //Input variables for calculations
            int ticketsSold = Convert.ToInt32(textBox1.Text);
            int channelsCoverage = Convert.ToInt32(textBox2.Text);
            int visitsSportsshop = Convert.ToInt32(textBox3.Text);
            int motionSubscription = Convert.ToInt32(textBox4.Text);
            double attendenceShowup = (double)(Convert.ToInt32(textBox5.Text)) / 100;

            //Calculations
            double saleFromShop = (Convert.ToDouble(visitsSportsshop) * SaleFromShopvisitsPercent) * SaleSportsGoodsAvg;
            int ticketSaleIncome = TicketPriceAvg * ticketsSold;
            int subscriptionIncome = SubscriptionPrice6Months * motionSubscription;
            int TvRightsIncome = TvRightsPerChannel * channelsCoverage;
            double beverageIncome = (ticketsSold * attendenceShowup) * SaleBeverageAvg;
            double totalSale = ticketSaleIncome + subscriptionIncome + TvRightsIncome + beverageIncome + saleFromShop;
            double income = totalSale * (1 - TotalCostsPercent);

            //Return text to form
            textBox6.Text = totalSale.ToString("C");
            textBox7.Text = income.ToString("C");
        }
    }
}
