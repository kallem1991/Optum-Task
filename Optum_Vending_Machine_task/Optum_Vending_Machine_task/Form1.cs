using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Optum_Vending_Machine_task.

namespace Optum_Vending_Machine_task
{
    public partial class Form1 : Form
    {
       Product pObj = new Product();
       Coin cObj = new Coin();
        public double price=0;
        public double value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> ProdList = pObj.GetProducts();

            foreach (var item in ProdList)
            {
                comboBox1.Items.Add(item.pName);
            }
            List<Coin> CoinList = cObj.GetCoins();

            foreach (var item in CoinList)
            {
                comboBox2.Items.Add(item.cName);
            }

        }
     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Product> ProdList = pObj.GetProducts();
             price = (from n in ProdList
                         where n.pName.Contains(comboBox1.SelectedItem.ToString())
                         select n.price).FirstOrDefault();
            lbl_price.Text = "$ " + price.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Penny")
            {
                MessageBox.Show("Penny not accepted");
            }
            else
            {
                List<Coin> CoinList = cObj.GetCoins();
                value = (from n in CoinList
                         where n.cName.Contains(comboBox2.SelectedItem.ToString())
                         select n.value).FirstOrDefault();
                label5.Text = "$ " + value.ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //double total = Convert.ToDouble(comboBox2.SelectedItem.ToString()) * Convert.ToDouble(comboBox3.SelectedItem.ToString());
            double total = value * Convert.ToDouble(comboBox3.SelectedItem);
            label5.Text = "$ " + total.ToString();
            
            if (price == total)
                MessageBox.Show("Inserted coins OK");

            else if (price > total)
                {
                    MessageBox.Show("Insert more coins");
                }
                else if (price < total)

                {
                    MessageBox.Show("Change Amount:"+(total-price));

                }
            }
        }
    }

