using System.Diagnostics;

namespace WinFormGroupProject
{
    public partial class InitialForm : Form
    {
        public List<Restaurant> InitialFormrestaurants = new List<Restaurant>();
        public List<AreaManager> areaManagers1 = new List<AreaManager>();
        public InitialForm(List<Restaurant> restaurants, List<AreaManager> areaManagers)
        {

            InitializeComponent();

            /*
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < areaManagers.Count)
            {
                listBox1.DataSource = areaManagers[selectedIndex].Restaurant;
            }
            */

            listBox1.DataSource = restaurants;
            listBox1.DisplayMember = "Name";

            InitialFormrestaurants = restaurants;
            areaManagers1 = areaManagers;

        }

        private void InitialForm_Load(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < InitialFormrestaurants.Count)
            {
                RestaurantForm form2 = new RestaurantForm(InitialFormrestaurants[selectedIndex]);
                form2.ShowDialog();
            }
        }

        private void RestaurantButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void AreaManagerButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AreaManagerForm areaManagerForm = new AreaManagerForm(this, areaManagers1[0]);

            if (areaManagers1[0].Name == textBox3.Text && areaManagers1[0].Password == textBox4.Text)
            {
                areaManagerForm.Show();
                textBox3.Text = "";
                textBox4.Text = "";
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //areaManagers1[0].CreateSupplier(areaManagers1[0].restaurants[0]);
            try
            {
                SupplyManager sm = areaManagers1[0].SupplyManagerLogin(textBox8.Text, textBox6.Text);
                if (sm != null)
                {
                    SupplyManagerForm supplyManagerForm = new SupplyManagerForm(this, sm, areaManagers1[0]);

                    supplyManagerForm.Show();
                    textBox8.Text = "";
                    textBox6.Text = "";
                    this.Hide();
                }

            }
            catch (NullReferenceException) { }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}