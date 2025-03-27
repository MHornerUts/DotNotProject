using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGroupProject
{
    public partial class AreaManagerForm : Form
    {
        InitialForm initialForm;


        AreaManager areaManager;
        List<MenuItem> offlist;
        List<MenuItem>? onlist;

        public AreaManagerForm(InitialForm prevous, AreaManager aM)
        {
            InitializeComponent();
            initialForm = prevous;

            offlist = new List<MenuItem>();

            areaManager = aM;

            upDateComboBox();
        }

        //Updates the combo boxs 
        public void upDateComboBox()
        {
            comboBox1.Items.Clear();
            try
            {
                foreach (Restaurant res in areaManager.GetRestaurants())
                {
                    comboBox1.Items.Add(res.name);
                    comboBox2.Items.Add(res.name);
                }

            }
            catch (NullReferenceException ex) { }

        }

        //Adds items to the offlist 
        public void add_to_list(MenuItem item)
        {
            ListViewItem list = new ListViewItem(item.GetName());
            list.SubItems.Add(item.GetPrice().ToString());
            offlist.Add(item);
            listView2.Items.Add(list);
        }

        //Closes this form
        private void button4_Click(object sender, EventArgs e)
        {
            initialForm.Show();
            this.Close();
        }

        //Changes the tab
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Opens the editing menu form and passes the currently selected restaurant
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                EditingMenuForm form = new EditingMenuForm(this, areaManager.restaurants.Find(Restaurant => Restaurant.name == comboBox1.SelectedItem).stockList);
                form.Show();
            }
            catch (NullReferenceException ex)
            {

            }

        }

        //Returns the item in the onlist based on the given string
        private MenuItem GetCurrentItemOnlist(string s)
        {
            foreach (MenuItem item in onlist)
            {
                if (item.GetName() == s)
                {
                    return item;
                }
            }

            return null;
        }

        //Returns the item in teh offlist based on the given string
        private MenuItem GetCurrentItemOfflist(string s)
        {
            foreach (MenuItem item in offlist)
            {
                if (item.GetName() == s)
                {
                    return item;
                }
            }

            return null;
        }

        //Updates the listView items to the selected resturant
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            listView2.Items.Clear();

            try
            {
                onlist = areaManager.restaurants.Find(Restaurant => Restaurant.name == comboBox1.SelectedItem).menu;
                foreach (MenuItem item in onlist)
                {

                    ListViewItem item2 = new ListViewItem(item.GetName());

                    item2.SubItems.Add(item.GetPrice().ToString());

                    listView1.Items.Add(item2);

                }
            }
            catch (NullReferenceException ex)
            {
                listView1.Items.Clear();
            }

        }

        //Moves the item to the other list and does the same with the list
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listView2.SelectedItems)
                {
                    MenuItem m = GetCurrentItemOfflist(item.Text);
                    onlist.Add(m);
                    offlist.Remove(m);
                    listView2.Items.Remove(item);
                    listView1.Items.Add(item);
                    areaManager.Save();
                }
            }
            catch (Exception ex)
            {

            }
        }

        //Moves the item to the other list and does the same with the list
        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    MenuItem m = GetCurrentItemOnlist(item.Text);
                    offlist.Add(m);
                    onlist.Remove(m);
                    listView1.Items.Remove(item);
                    listView2.Items.Add(item);
                    areaManager.Save();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        //Creates a new restarant with basic defaults
        private void button8_Click(object sender, EventArgs e)
        {
            areaManager.CreateRestaurant(textBox1.Text);

            upDateComboBox();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                FinanceMenuForm form = new FinanceMenuForm(areaManager.restaurants.Find(Restaurant => Restaurant.name == comboBox2.SelectedItem));
                form.Show();
            }
            catch (NullReferenceException ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        //Saves all the changes to areamanager file

    }
}
