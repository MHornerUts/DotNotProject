using MailKit.Search;
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
    public partial class SupplyManagerForm : Form
    {
        InitialForm initialForm;
        String email;
        SupplyManager supplyManager;
        AreaManager areaManager;
        List<Supplier> suppliers;
        List<Order> orders;
        private Boolean safe;
        public SupplyManagerForm(InitialForm previous, SupplyManager supplyManager, AreaManager areaManager)
        {
            safe = false;
            this.supplyManager = supplyManager;
            InitializeComponent();
            initialForm = previous;

            this.areaManager = areaManager;

            //Sets the suppliers 
            this.suppliers = areaManager.supp;

            //Sets the orders 
            this.orders = areaManager.orders;

            //Adds all current orders to the right list
            foreach (Order order in orders)
            {
                ListViewItem item = new ListViewItem(order.OrderID.ToString());
                item.SubItems.Add(order.OrderDesc);
                listView2.Items.Add(item);
            }

            //Adds all current suppliers to the right list
            foreach (Supplier sup in suppliers)
            {
                ListViewItem item = new ListViewItem(sup.name);
                item.SubItems.Add(sup.email);
                listView1.Items.Add(item);
            }

            //Blanks out some labels 
            email = "";
            label7.Text = "";


            foreach (Restaurant res in supplyManager.restaurants)
            {
                comboBox1.Items.Add(res.name);
            }
        }

        //Closes the form
        private void button4_Click(object sender, EventArgs e)
        {
            initialForm.Show();
            this.Close();
        }

        //Changes the selected index
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        //Updates email based on selected listview item
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                email = listView1.SelectedItems[0].SubItems[1].Text;
                label2.Text = email;
            }
            catch (Exception ex)
            {
                label2.Text = "";
                email = "";

            }
        }

        //Sends a email to selected supplier
        private void button5_Click(object sender, EventArgs e)
        {
            string msg = textBox1.Text;

            if (label1.Text != "" & textBox1.Text != "")
            {
                MsgLoadingForm frm = new MsgLoadingForm(msg, email, "Message Sent");
                frm.Show();


                this.Show();
            }

        }
        
        //Adds new stock to the selected restaurant
        private void button6_Click(object sender, EventArgs e)
        {


            if (textBox4.Text != "" && numericUpDown1.Value > 0 && safe)
            {
                Stock stock = new Stock { name = textBox4.Text, price = (float)numericUpDown1.Value, amount = 0, orderQuantity = 0 };

                supplyManager.restaurants.Find(Restaurant => Restaurant.name == comboBox1.SelectedItem).stockList.Add(stock);

                areaManager.Save();

                label7.Text = "Item Added";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //Changes selected index
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        //Changes selected index
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Changes boolean to ensure the user has entered something
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            safe = true;
        }

        //Confirms the selected order
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                
                orders.Find(Order => Order.OrderID.ToString() == listView2.SelectedItems[0].SubItems[0].Text).ConfirmOrder();
                orders.Remove(orders.Find(Order => Order.OrderID.ToString() == listView2.SelectedItems[0].SubItems[0].Text));
                listView2.SelectedItems[0].Remove();
                areaManager.Save();
            }
            catch (NullReferenceException ex) { }
            catch (ArgumentOutOfRangeException ex) { }
        }

        //Deletes the selected order
        private void button8_Click(object sender, EventArgs e)
        {
            try {
                orders.Remove(orders.Find(Order => Order.OrderID.ToString() == listView2.SelectedItems[0].SubItems[0].Text));
                listView2.SelectedItems[0].Remove();
                areaManager.Save();
            } 
            catch (NullReferenceException ex) { }
            catch (ArgumentOutOfRangeException ex) { }
        }
    }
}
