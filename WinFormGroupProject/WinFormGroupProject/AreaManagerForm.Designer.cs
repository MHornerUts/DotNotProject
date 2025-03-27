namespace WinFormGroupProject
{
    partial class AreaManagerForm
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
            button8 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            listView2 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            tabPage4 = new TabPage();
            comboBox2 = new ComboBox();
            button9 = new Button();
            label6 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 25);
            label1.Name = "label1";
            label1.Size = new Size(204, 41);
            label1.TabIndex = 0;
            label1.Text = "Area Manager";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(311, 115);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 1;
            button1.Text = "New Store";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(311, 191);
            button2.Name = "button2";
            button2.Size = new Size(132, 29);
            button2.TabIndex = 2;
            button2.Text = "Edit Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(311, 268);
            button3.Name = "button3";
            button3.Size = new Size(132, 29);
            button3.TabIndex = 3;
            button3.Text = "View Finacials";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(334, 343);
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
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(798, 445);
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
            tabPage1.Size = new Size(790, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(790, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(325, 333);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 3;
            button8.Text = "Create";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 185);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 1;
            label5.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(listView2);
            tabPage3.Controls.Add(listView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(790, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(64, 289);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 8;
            button7.Text = "New";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(64, 227);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "Remove";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(64, 169);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 21);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 5;
            label4.Text = "Store";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(37, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 21);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 3;
            label3.Text = "Addable Menu Items";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 21);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 2;
            label2.Text = "Current Menu Items";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listView2.Location = new Point(518, 61);
            listView2.Name = "listView2";
            listView2.Size = new Size(243, 306);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Name";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(268, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(244, 306);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Price";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Controls.Add(button9);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(790, 412);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(301, 171);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // button9
            // 
            button9.Location = new Point(328, 301);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 0;
            button9.Text = "Select Store";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(247, 72);
            label6.Name = "label6";
            label6.Size = new Size(248, 38);
            label6.TabIndex = 4;
            label6.Text = "Create a new store";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(328, 68);
            label7.Name = "label7";
            label7.Size = new Size(120, 38);
            label7.TabIndex = 2;
            label7.Text = "Finance ";
            // 
            // AreaManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "AreaManagerForm";
            Text = "AreaManagerForm";
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
        private ListView listView2;
        private ListView listView1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Button button6;
        private Button button5;
        private Label label4;
        private Button button7;
        private Label label5;
        private TextBox textBox1;
        private Button button8;
        private ComboBox comboBox2;
        private Button button9;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label6;
        private Label label7;
    }
}