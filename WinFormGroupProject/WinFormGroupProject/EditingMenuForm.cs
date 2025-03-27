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
    public partial class EditingMenuForm : Form
    {
        AreaManagerForm areaManagerForm;
        List<Stock> stocks;

        //Constucter doing constucter things
        public EditingMenuForm(AreaManagerForm form, List<Stock> stocks)
        {
            InitializeComponent();
            areaManagerForm = form;
            
            this.stocks = stocks;
            
            //adds all stocks to a checked list box
            foreach (Stock ing in stocks) { 
                checkedListBox1.Items.Add(ing.name);
            }


        }

        //Creates a new stock item based on the selected stock items in the checked list box
        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(numericUpDown1.Value.ToString());

            List<Stock> stocks = new List<Stock>();

            foreach (String s in checkedListBox1.Items) {
                foreach (Stock ing in stocks) { 
                    if (ing.name == s)
                    {
                        stocks.Add(ing);
                    }
                }
            }

            List<Ingredient> ingredients = new List<Ingredient>();

            foreach (Stock s in stocks)
            {
                ingredients.Add(new Ingredient(s.name, 1));
            }

            MenuItem menuItem = new MenuItem(textBox1.Text, (float) numericUpDown1.Value, ingredients);

            areaManagerForm.add_to_list(menuItem);

            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
