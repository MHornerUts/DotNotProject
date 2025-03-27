using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO.Pem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormGroupProject
{
    public partial class RestaurantForm : Form
    {
        public static Restaurant SelectedRestaurant;

        public RestaurantForm(Restaurant restaurant)
        {
            InitializeComponent();
            SelectedRestaurant = restaurant;
            LoginTitle.Text = (SelectedRestaurant.name + " Login");
        }
        private void RestaurantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Save(SelectedRestaurant);
        }

        private void AttendListUpdate()
        {
            // Clear any existing columns
            AttendantList.Columns.Clear();

            // Create two columns for "Name" and "Password"
            AttendantList.Columns.Add("Name", 200); // Name column with a width of 200 pixels
            AttendantList.Columns.Add("Password", 200); // Password column with a width of 200 pixels

            // Clear existing items in the list
            AttendantList.Items.Clear();

            foreach (var attender in SelectedRestaurant.Attendants)
            {
                ListViewItem item = new ListViewItem(attender.Name);
                item.SubItems.Add(attender.Password.ToString());

                // Add the item to the list
                AttendantList.Items.Add(item);
            }
        }

        private void SaleMenuUpdate()
        {
            // Clear any existing columns
            SaleMenu.Columns.Clear();

            // Create two columns for "Name" and "Price"
            SaleMenu.Columns.Add("Name", 200); // Name column with a width of x pixels
            SaleMenu.Columns.Add("Price", 50); // Price column with a width of x pixels

            // Clear existing items in the list
            SaleMenu.Items.Clear();

            foreach (var menuItem in SelectedRestaurant.menu)
            {
                // Create a ListViewItem and associate it with the MenuItem using the Tag property
                ListViewItem item = new ListViewItem(menuItem.name);
                item.SubItems.Add(menuItem.price.ToString());

                // Set the Tag property to associate the ListViewItem with the MenuItem
                item.Tag = menuItem;

                // Add the item to the list
                SaleMenu.Items.Add(item);
            }
        }

        private void SaleUpdate()
        {
            SaleDisplay.Columns.Clear();


            SaleDisplay.Columns.Add("Name", 100);
            SaleDisplay.Columns.Add("Price", 50);
            SaleDisplay.Columns.Add("Quantity", 100);

            SaleDisplay.Items.Clear();

            foreach (var menuItem in SelectedRestaurant.sale)
            {

                ListViewItem item = new ListViewItem(menuItem.name);
                item.SubItems.Add(menuItem.price.ToString());
                item.SubItems.Add(menuItem.quantity.ToString());

                // Add the item to the list
                SaleDisplay.Items.Add(item);
            }
        }

        private void SaleListUpdate(List<MenuItem> sale)
        {
            SaleListDetails.Columns.Clear();

            SaleListDetails.Columns.Add("Name", 100);
            SaleListDetails.Columns.Add("Price", 50);
            SaleListDetails.Columns.Add("Quantity", 100);

            SaleListDetails.Items.Clear();

            foreach (var menuItem in sale)
            {

                ListViewItem item = new ListViewItem(menuItem.name);
                item.SubItems.Add(menuItem.price.ToString());
                item.SubItems.Add(menuItem.quantity.ToString());

                // Add the item to the list
                SaleListDetails.Items.Add(item);
            }
        }

        private void OrderUpdate()
        {
            CurrentOrderList.Columns.Clear();


            CurrentOrderList.Columns.Add("Name", 100);
            CurrentOrderList.Columns.Add("Price", 50);
            CurrentOrderList.Columns.Add("Quantity", 100);

            CurrentOrderList.Items.Clear();

            foreach (var stock in SelectedRestaurant.currentOrder.OrderStocks)
            {

                ListViewItem item = new ListViewItem(stock.name);
                item.SubItems.Add(stock.price.ToString());
                item.SubItems.Add(stock.orderQuantity.ToString());

                // Add the item to the list
                CurrentOrderList.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User SelectedUser = SelectedRestaurant.Login(UsernameTextbox.Text, PasswordTextbox.Text);
            if (SelectedUser is Manager)
            {
                TabController.SelectedIndex = 1;
            }
            else if (SelectedUser is Attendant)
            {
                TabController.SelectedIndex = 2;
            }
            else
            {
                FailTextbox.Text = ("Invalid Credentials. Try Again");
            }
            AttendListUpdate();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtitle_TextChanged(object sender, EventArgs e)
        {
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        //ManagerMenusButtons
        private void button4_Click(object sender, EventArgs e) // AddAttendent
        {
            TabController.SelectedIndex = 3;
        }
        private void button5_Click(object sender, EventArgs e) //ViewAttendent
        {
            AttendListUpdate();
            TabController.SelectedIndex = 4;
        }
        private void button6_Click(object sender, EventArgs e) //OrderStock
        {
            OrderStockList.Columns.Clear();

            OrderStockList.Columns.Add("Name", 100);
            OrderStockList.Columns.Add("Price", 100);
            OrderStockList.Columns.Add("Amount", 100);
            OrderStockList.Columns.Add("Recommended Amount", 150);

            OrderStockList.Items.Clear();

            foreach (var stock in SelectedRestaurant.stockList)
            {

                ListViewItem item = new ListViewItem(stock.name);
                item.SubItems.Add(stock.price.ToString());
                item.SubItems.Add(stock.amount.ToString());
                item.SubItems.Add(stock.recommendedOrderAmount.ToString());
                item.Tag = stock;
                // Add the item to the list
                OrderStockList.Items.Add(item);
            }
            TabController.SelectedIndex = 7;
        }

        private void button7_Click(object sender, EventArgs e) //View Stock
        {
            StockListBox.Columns.Clear();

            StockListBox.Columns.Add("Name", 100);
            StockListBox.Columns.Add("Price", 100);
            StockListBox.Columns.Add("Amount", 100);
            StockListBox.Columns.Add("Recommended Amount", 150);

            StockListBox.Items.Clear();

            foreach (var stock in SelectedRestaurant.stockList)
            {

                ListViewItem item = new ListViewItem(stock.name);
                item.SubItems.Add(stock.price.ToString());
                item.SubItems.Add(stock.amount.ToString());
                item.SubItems.Add(stock.recommendedOrderAmount.ToString());

                // Add the item to the list
                StockListBox.Items.Add(item);
            }
            TabController.SelectedIndex = 8;
        }
        private void button8_Click(object sender, EventArgs e) //Logout
        {
            TabController.SelectedIndex = 0;
        }

        private void button22_Click(object sender, EventArgs e) //EndDay
        {
            Debug.WriteLine("Button22");

            SelectedRestaurant.AdjustProjection();
        }
        //

        //AttendantMenuButtons
        private void button9_Click(object sender, EventArgs e) //Make Sale
        {
            TabController.SelectedIndex = 5;
            SaleMenuUpdate();
            SelectedRestaurant.sale.Clear();
        }

        private void button2_Click(object sender, EventArgs e) //View Sales
        {
            SalesList.Items.Clear();
            for (int i = 0; i < SelectedRestaurant.saleList.Count; i++)
            {
                SalesList.Items.Add($"{i + 1}. {SelectedRestaurant.saleList[i]}");
            }
            TabController.SelectedIndex = 6;
        }

        private void button11_Click(object sender, EventArgs e) //Logout
        {
            TabController.SelectedIndex = 0;
        }

        //


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAttendantPassword_TextChanged(object sender, EventArgs e)
        {

        }



        //CreateAttendentButtons
        private void button12_Click(object sender, EventArgs e) //Back
        {
            CreateAttendantName.Text = ("");
            CreateAttendantPassword.Text = ("");
            AttendantFeedback.Text = ("");
            TabController.SelectedIndex = 1;
        }
        private void button13_Click(object sender, EventArgs e) //CreateAttendant
        {
            if (!string.IsNullOrWhiteSpace(CreateAttendantName.Text) && !string.IsNullOrWhiteSpace(CreateAttendantPassword.Text))
            {
                SelectedRestaurant.CreateAttendant(CreateAttendantName.Text, CreateAttendantPassword.Text);
                AttendantFeedback.Text = ("Successfully Created");
            }
            else AttendantFeedback.Text = ("Please Try Again");
            AttendListUpdate();
        }

        private void AttendantFeedback_TextChanged(object sender, EventArgs e)
        {

        }


        //Sale List Buttons
        private void button16_Click(object sender, EventArgs e) // AddtoSale
        {
            float SaleTotal = 0;
            // Check if an item is selected in the ListView
            if (SaleMenu.SelectedItems.Count > 0)
            {
                // Assuming your ListViewItem.Tag contains MenuItem objects
                if (SaleMenu.SelectedItems[0].Tag is MenuItem selectedObject)
                {
                    if (float.TryParse(QuantityText.Text, out float quantity) && (quantity > 0 || quantity < 0))
                    {
                        InvalidQuantityText.Text = "";
                        if (SelectedRestaurant.sale.Any(item => item.name == selectedObject.name))
                            selectedObject.quantity += quantity;
                        else
                        {
                            selectedObject.quantity = quantity;
                            SelectedRestaurant.sale.Add(selectedObject);
                        }
                        SaleUpdate();

                        foreach (MenuItem item in SelectedRestaurant.sale)
                            SaleTotal += item.quantity * item.price;
                        SaleTotalText.Text = ("Sale Total: " + SaleTotal.ToString());
                    }
                    else
                    {
                        InvalidQuantityText.Text = "Enter a valid quantity!";
                    }
                }
            }
            else
            {
                Debug.WriteLine("Not Working");
            }
        }

        private void button15_Click(object sender, EventArgs e) //TenderSale
        {
            InvalidSaleText.Text = "";
            bool validSale = true;

            foreach (MenuItem item in SelectedRestaurant.sale)
            {
                foreach (Ingredient ingredient in item.ingredientList)
                {
                    Stock stock = SelectedRestaurant.stockList.Find(stock => stock.name == ingredient.name);
                    if (ingredient.quantity * item.quantity > stock.amount)
                    {
                        InvalidSaleText.Text = "Invalid Sale!";
                        validSale = false;
                    }
                }
            }

            if (validSale)
            {
                // Create a new list to store the sale items to be added
                List<MenuItem> saleToAdd = new List<MenuItem>(SelectedRestaurant.sale);

                foreach (MenuItem item in saleToAdd)
                {
                    foreach (Ingredient ingredient in item.ingredientList)
                    {
                        Stock stock = SelectedRestaurant.stockList.Find(stock => stock.name == ingredient.name);
                        if (item.quantity * ingredient.quantity > 0)
                        {
                            stock.amount -= item.quantity * ingredient.quantity;
                        }
                    }
                }
                SaleDisplay.Columns.Clear();
                SaleDisplay.Items.Clear();
                SelectedRestaurant.saleList.Add(saleToAdd);
                SelectedRestaurant.sale.Clear();
                InvalidSaleText.Text = "Sale Tendered!";
            }
        }

        private void button17_Click(object sender, EventArgs e) //Cancel
        {
            SelectedRestaurant.sale.Clear();
            InvalidSaleText.Text = "";
            InvalidQuantityText.Text = "";
            SaleTotalText.Text = "Sale Total: ";
            TabController.SelectedIndex = 2;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        //Sale History
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) //SalesListClick
        {
            if (SalesList.SelectedIndex >= 0 && SalesList.SelectedIndex < SelectedRestaurant.saleList.Count)
            {
                int selectedIndex = SalesList.SelectedIndex;
                SaleListUpdate(SelectedRestaurant.saleList[selectedIndex]);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TabController.SelectedIndex = 2;
        }

        //ViewStock
        private void button18_Click(object sender, EventArgs e)
        {
            TabController.SelectedIndex = 1;
        }

        //OrderStock
        private void button20_Click_1(object sender, EventArgs e)
        {
            StockQuantityFail.Text = "";
            float SaleTotal = 0;
            // Check if an item is selected in the ListView
            if (OrderStockList.SelectedItems.Count > 0)
            {
                // Assuming your ListViewItem.Tag contains MenuItem objects
                if (OrderStockList.SelectedItems[0].Tag is Stock selectedObject)
                {
                    if (float.TryParse(OrderStockQuantity.Text, out float quantity) && (quantity > 0))
                    {
                        StockQuantityFail.Text = "";
                        if (SelectedRestaurant.currentOrder.OrderStocks.Any(item => item.name == selectedObject.name))
                            selectedObject.orderQuantity += quantity;
                        else
                        {
                            selectedObject.orderQuantity = quantity;
                            SelectedRestaurant.currentOrder.OrderStocks.Add(selectedObject);
                        }
                        OrderUpdate();
                    }
                    else
                    {
                        StockQuantityFail.Text = "Enter a valid quantity!";
                    }
                }
            }
        }
    }
}
