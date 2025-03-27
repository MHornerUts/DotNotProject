using System.Windows.Forms;

namespace WinFormGroupProject
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ExitButton = new Button();
            AreaManagerButton = new Button();
            SupplierButton = new Button();
            RestaurantButton = new Button();
            Subtitle = new TextBox();
            Title = new TextBox();
            tabPage2 = new TabPage();
            textBox11 = new TextBox();
            listBox1 = new ListBox();
            tabPage3 = new TabPage();
            button3 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage4 = new TabPage();
            button2 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button5 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(568, 361);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ExitButton);
            tabPage1.Controls.Add(AreaManagerButton);
            tabPage1.Controls.Add(SupplierButton);
            tabPage1.Controls.Add(RestaurantButton);
            tabPage1.Controls.Add(Subtitle);
            tabPage1.Controls.Add(Title);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(560, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(162, 279);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(225, 40);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // AreaManagerButton
            // 
            AreaManagerButton.Location = new Point(162, 187);
            AreaManagerButton.Name = "AreaManagerButton";
            AreaManagerButton.Size = new Size(225, 40);
            AreaManagerButton.TabIndex = 10;
            AreaManagerButton.Text = "Area Manager Login";
            AreaManagerButton.UseVisualStyleBackColor = true;
            AreaManagerButton.Click += AreaManagerButton_Click;
            // 
            // SupplierButton
            // 
            SupplierButton.Location = new Point(162, 233);
            SupplierButton.Name = "SupplierButton";
            SupplierButton.Size = new Size(225, 40);
            SupplierButton.TabIndex = 9;
            SupplierButton.Text = "Supply Manager Login";
            SupplierButton.UseVisualStyleBackColor = true;
            SupplierButton.Click += SupplierButton_Click;
            // 
            // RestaurantButton
            // 
            RestaurantButton.Location = new Point(162, 141);
            RestaurantButton.Name = "RestaurantButton";
            RestaurantButton.Size = new Size(225, 40);
            RestaurantButton.TabIndex = 8;
            RestaurantButton.Text = "Restaurant Login";
            RestaurantButton.UseVisualStyleBackColor = true;
            RestaurantButton.Click += RestaurantButton_Click;
            // 
            // Subtitle
            // 
            Subtitle.BackColor = Color.White;
            Subtitle.BorderStyle = BorderStyle.None;
            Subtitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Subtitle.Location = new Point(121, 92);
            Subtitle.Name = "Subtitle";
            Subtitle.ReadOnly = true;
            Subtitle.Size = new Size(335, 28);
            Subtitle.TabIndex = 7;
            Subtitle.Text = "Please select an option:";
            Subtitle.TextAlign = HorizontalAlignment.Center;
            // 
            // Title
            // 
            Title.BackColor = Color.White;
            Title.BorderStyle = BorderStyle.None;
            Title.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(26, 13);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Size = new Size(525, 73);
            Title.TabIndex = 6;
            Title.Text = "Main Menu";
            Title.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(560, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.White;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.Location = new Point(105, 34);
            textBox11.Margin = new Padding(3, 2, 3, 2);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(350, 24);
            textBox11.TabIndex = 1;
            textBox11.Text = "Select a Restaurant";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // listBox1
            // 
            listBox1.DataSource = listBox1.CustomTabOffsets;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(127, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(306, 169);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(560, 333);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(204, 144);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(285, 144);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(165, 115);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(245, 23);
            textBox4.TabIndex = 4;
            textBox4.UseSystemPasswordChar = true;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(99, 118);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(60, 16);
            textBox5.TabIndex = 3;
            textBox5.Text = "Password:";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(99, 92);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(60, 16);
            textBox2.TabIndex = 1;
            textBox2.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(165, 52);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(245, 28);
            textBox1.TabIndex = 0;
            textBox1.Text = "Area Manager Login";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(textBox6);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Controls.Add(textBox8);
            tabPage4.Controls.Add(textBox9);
            tabPage4.Controls.Add(textBox10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(560, 333);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(209, 136);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(66, 25);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(281, 136);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(66, 25);
            button4.TabIndex = 11;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(157, 109);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(247, 23);
            textBox6.TabIndex = 10;
            textBox6.UseSystemPasswordChar = true;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Location = new Point(91, 112);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(60, 16);
            textBox7.TabIndex = 9;
            textBox7.Text = "Password:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(157, 82);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(247, 23);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Location = new Point(91, 85);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(60, 16);
            textBox9.TabIndex = 7;
            textBox9.Text = "Username:";
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(157, 50);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(247, 28);
            textBox10.TabIndex = 6;
            textBox10.Text = "Supply Manager Login";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.Location = new Point(243, 238);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 361);
            Controls.Add(tabControl1);
            Name = "InitialForm";
            Text = "InitialForm";
            Load += InitialForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button ExitButton;
        private Button AreaManagerButton;
        private Button SupplierButton;
        private Button RestaurantButton;
        private TextBox Subtitle;
        private TextBox Title;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Button button3;
        private TextBox textBox11;
        private TabPage tabPage4;
        private Button button2;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button5;
    }
}