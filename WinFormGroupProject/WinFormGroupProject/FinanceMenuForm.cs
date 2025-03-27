using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGroupProject
{
    public partial class FinanceMenuForm : Form
    {
        Restaurant restaurant;
        public FinanceMenuForm(Restaurant restaurant)
        {
            InitializeComponent();
            this.restaurant = restaurant;
        }

        private void FinanceMenuForm_Load(object sender, EventArgs e)
        {
            label3.Text = HighestStockItem().name;

            label5.Text = HighestStockItem().amount.ToString();

            foreach (MenuItem item in MenuItemsUsing(HighestStockItem()))
            {
                ListViewItem item1 = new ListViewItem(item.GetName());
                item1.SubItems.Add(item.GetPrice().ToString());
                listView1.Items.Add(item1);
            }

            foreach (Stock menuItem in restaurant.stockList)
            {
                comboBox1.Items.Add(menuItem.name);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Returns a list of the menu items using a certain stock
        private List<MenuItem> MenuItemsUsing(Stock stock)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (MenuItem menuItem in restaurant.menu)
            {

                if (!(menuItem.GetList().Find(Stock => Stock.name == stock.name) is null))
                {
                    items.Add(menuItem);
                }
            }
            return items;
        }

        //Returns the item with the highest quantity
        private Stock HighestStockItem()
        {
            Stock stockBig = new Stock() { amount = (float)0 };
            foreach (Stock stock in restaurant.stockList)
            {
                if (stockBig.amount < stock.amount)
                {
                    stockBig = stock;
                }
            }
            return stockBig;
        }

        //Converts ingredients to stock 
        private List<Stock> GetAvStock(MenuItem item)
        {
            List<Stock> list = new List<Stock>();

            foreach (Ingredient ing in item.GetList())
            {
                if (!(restaurant.stockList.Find(Stock => Stock.name == ing.name) is null))
                {
                    list.Add(restaurant.stockList.Find(Stock => Stock.name == ing.name));
                }
            }

            return list;
        }

        //Returns the stock ingredient amount with the lowest quantity 
        private float amountMakeable(MenuItem item)
        {
            float lowest = GetAvStock(item)[0].amount;

            foreach (Stock stock in GetAvStock(item))
            {
                if (stock.amount < lowest)
                {
                    lowest = stock.amount;
                }
            }

            return lowest;
        }

        //Finds the item with the least stock
        private Stock lowestItem(MenuItem item)
        {
            Stock stock1 = restaurant.stockList.Find(Stock => Stock.name == item.ingredientList[0].name);

            foreach (Stock stock in GetAvStock(item))
            {
                if (stock.amount < stock1.amount)
                {
                    stock1 = stock;
                }
            }


            return stock1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stock stock = restaurant.stockList.Find(Stock => Stock.name == comboBox1.SelectedItem);
            label9.Text = stock.price.ToString();
            label11.Text = stock.amount.ToString();

            listView2.Items.Clear();
            foreach (MenuItem item in MenuItemsUsing(stock))
            {
                ListViewItem item1 = new ListViewItem(item.GetName());
                item1.SubItems.Add(item.GetPrice().ToString());
                item1.SubItems.Add(amountMakeable(item).ToString());
                item1.SubItems.Add(lowestItem(item).name);
                listView2.Items.Add(item1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
    }
}
