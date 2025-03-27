namespace WinFormGroupProject
{
    partial class SupplyManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            tabPage3 = new TabPage();
            label8 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button6 = new Button();
            tabPage4 = new TabPage();
            button8 = new Button();
            button7 = new Button();
            listView2 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(298, 44);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 0;
            label1.Text = "Supply Manager";
            // 
            // button1
            // 
            button1.Location = new Point(298, 122);
            button1.Name = "button1";
            button1.Size = new Size(219, 29);
            button1.TabIndex = 1;
            button1.Text = "Message Supplier";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(298, 197);
            button2.Name = "button2";
            button2.Size = new Size(219, 29);
            button2.TabIndex = 2;
            button2.Text = "Create New Stock Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(298, 275);
            button3.Name = "button3";
            button3.Size = new Size(219, 29);
            button3.TabIndex = 3;
            button3.Text = "Confirm Orders";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(363, 355);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 446);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(789, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(789, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(468, 18);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 51);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(468, 287);
            textBox1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(452, 366);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 1;
            button5.Text = "Msg";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.Location = new Point(68, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(160, 287);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(numericUpDown1);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button6);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(789, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(225, 254);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 12;
            label8.Text = "Resturant";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(318, 254);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(319, 190);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 375);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 343);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(331, 52);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 7;
            label5.Text = "New stock Item";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(319, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 192);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 2;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 114);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // button6
            // 
            button6.Location = new Point(319, 311);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 0;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(listView2);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(789, 413);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(19, 215);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 2;
            button8.Text = "Deny";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(19, 123);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 1;
            button7.Text = "Confirm";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3 });
            listView2.Location = new Point(150, 39);
            listView2.Name = "listView2";
            listView2.Size = new Size(601, 326);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Desc";
            columnHeader3.Width = 500;
            // 
            // SupplyManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "SupplyManagerForm";
            Text = "SupplyManagerForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button5;
        private ListView listView1;
        private TextBox textBox1;
        private Label label2;
        private Button button6;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Button button8;
        private Button button7;
        private ListView listView2;
        private Label label8;
        private ComboBox comboBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}