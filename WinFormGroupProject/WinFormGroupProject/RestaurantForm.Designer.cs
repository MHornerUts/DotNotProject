namespace WinFormGroupProject
{
    partial class RestaurantForm
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
            TabController = new TabControl();
            tabPage1 = new TabPage();
            FailTextbox = new TextBox();
            button3 = new Button();
            button1 = new Button();
            PasswordTextbox = new TextBox();
            textBox5 = new TextBox();
            UsernameTextbox = new TextBox();
            textBox2 = new TextBox();
            LoginTitle = new TextBox();
            tabPage2 = new TabPage();
            button22 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            Subtitle = new TextBox();
            Title = new TextBox();
            tabPage3 = new TabPage();
            button2 = new Button();
            button11 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            tabPage4 = new TabPage();
            AttendantFeedback = new TextBox();
            button13 = new Button();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox7 = new TextBox();
            button12 = new Button();
            CreateAttendantPassword = new TextBox();
            CreateAttendantName = new TextBox();
            tabPage5 = new TabPage();
            button14 = new Button();
            textBox4 = new TextBox();
            AttendantList = new ListView();
            tabPage6 = new TabPage();
            SaleTotalText = new TextBox();
            InvalidSaleText = new TextBox();
            InvalidQuantityText = new TextBox();
            textBox17 = new TextBox();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            button17 = new Button();
            button16 = new Button();
            QuantityText = new TextBox();
            SaleMenu = new ListView();
            button15 = new Button();
            SaleDisplay = new ListView();
            textBox6 = new TextBox();
            tabPage7 = new TabPage();
            button10 = new Button();
            SaleListDetails = new ListView();
            SalesList = new ListBox();
            textBox8 = new TextBox();
            tabPage8 = new TabPage();
            textBox18 = new TextBox();
            StockQuantityFail = new TextBox();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            textBox22 = new TextBox();
            button19 = new Button();
            button20 = new Button();
            OrderStockQuantity = new TextBox();
            OrderStockList = new ListView();
            button21 = new Button();
            CurrentOrderList = new ListView();
            textBox12 = new TextBox();
            tabPage9 = new TabPage();
            button18 = new Button();
            StockListBox = new ListView();
            textBox13 = new TextBox();
            TabController.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            tabPage9.SuspendLayout();
            SuspendLayout();
            // 
            // TabController
            // 
            TabController.Controls.Add(tabPage1);
            TabController.Controls.Add(tabPage2);
            TabController.Controls.Add(tabPage3);
            TabController.Controls.Add(tabPage4);
            TabController.Controls.Add(tabPage5);
            TabController.Controls.Add(tabPage6);
            TabController.Controls.Add(tabPage7);
            TabController.Controls.Add(tabPage8);
            TabController.Controls.Add(tabPage9);
            TabController.Dock = DockStyle.Fill;
            TabController.Location = new Point(0, 0);
            TabController.Name = "TabController";
            TabController.SelectedIndex = 0;
            TabController.Size = new Size(592, 341);
            TabController.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(FailTextbox);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(PasswordTextbox);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(UsernameTextbox);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(LoginTitle);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(584, 313);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FailTextbox
            // 
            FailTextbox.BorderStyle = BorderStyle.None;
            FailTextbox.Location = new Point(242, 190);
            FailTextbox.Name = "FailTextbox";
            FailTextbox.Size = new Size(100, 16);
            FailTextbox.TabIndex = 21;
            // 
            // button3
            // 
            button3.Location = new Point(226, 161);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 20;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(307, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Location = new Point(195, 132);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.PasswordChar = '*';
            PasswordTextbox.Size = new Size(215, 23);
            PasswordTextbox.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.White;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Location = new Point(129, 135);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(60, 16);
            textBox5.TabIndex = 17;
            textBox5.Text = "Password:";
            textBox5.TextAlign = HorizontalAlignment.Right;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Location = new Point(195, 103);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.Size = new Size(215, 23);
            UsernameTextbox.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(129, 110);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(60, 16);
            textBox2.TabIndex = 15;
            textBox2.Text = "Name:";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // LoginTitle
            // 
            LoginTitle.BackColor = Color.White;
            LoginTitle.BorderStyle = BorderStyle.None;
            LoginTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTitle.Location = new Point(180, 69);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.ReadOnly = true;
            LoginTitle.Size = new Size(230, 28);
            LoginTitle.TabIndex = 14;
            LoginTitle.Text = "Placeholder";
            LoginTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button22);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(Subtitle);
            tabPage2.Controls.Add(Title);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(584, 313);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(180, 244);
            button22.Name = "button22";
            button22.Size = new Size(225, 25);
            button22.TabIndex = 21;
            button22.Text = "End Day";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button8
            // 
            button8.Location = new Point(180, 276);
            button8.Name = "button8";
            button8.Size = new Size(225, 25);
            button8.TabIndex = 20;
            button8.Text = "Logout";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(180, 212);
            button7.Name = "button7";
            button7.Size = new Size(225, 25);
            button7.TabIndex = 19;
            button7.Text = "View Stock";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(180, 180);
            button6.Name = "button6";
            button6.Size = new Size(225, 25);
            button6.TabIndex = 18;
            button6.Text = "Order Stock";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(180, 148);
            button5.Name = "button5";
            button5.Size = new Size(225, 25);
            button5.TabIndex = 17;
            button5.Text = "View Attendants";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(180, 116);
            button4.Name = "button4";
            button4.Size = new Size(225, 25);
            button4.TabIndex = 16;
            button4.Text = "Create Attendant";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Subtitle
            // 
            Subtitle.BackColor = Color.White;
            Subtitle.BorderStyle = BorderStyle.None;
            Subtitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Subtitle.Location = new Point(125, 82);
            Subtitle.Name = "Subtitle";
            Subtitle.ReadOnly = true;
            Subtitle.Size = new Size(335, 28);
            Subtitle.TabIndex = 13;
            Subtitle.Text = "Please select an option:";
            Subtitle.TextAlign = HorizontalAlignment.Center;
            Subtitle.TextChanged += Subtitle_TextChanged;
            // 
            // Title
            // 
            Title.BackColor = Color.White;
            Title.BorderStyle = BorderStyle.None;
            Title.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            Title.Location = new Point(30, 3);
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Size = new Size(525, 73);
            Title.TabIndex = 12;
            Title.Text = "Manager Menu";
            Title.TextAlign = HorizontalAlignment.Center;
            Title.TextChanged += Title_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(584, 313);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(180, 180);
            button2.Name = "button2";
            button2.Size = new Size(225, 40);
            button2.TabIndex = 20;
            button2.Text = "View Sales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button11
            // 
            button11.Location = new Point(180, 226);
            button11.Name = "button11";
            button11.Size = new Size(225, 40);
            button11.TabIndex = 19;
            button11.Text = "Logout";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button9
            // 
            button9.Location = new Point(180, 134);
            button9.Name = "button9";
            button9.Size = new Size(225, 40);
            button9.TabIndex = 16;
            button9.Text = "Make Sale";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(125, 85);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(335, 28);
            textBox1.TabIndex = 15;
            textBox1.Text = "Please select an option:";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged_2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(30, 6);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(525, 73);
            textBox3.TabIndex = 14;
            textBox3.Text = "Attendant Menu";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(AttendantFeedback);
            tabPage4.Controls.Add(button13);
            tabPage4.Controls.Add(textBox10);
            tabPage4.Controls.Add(textBox11);
            tabPage4.Controls.Add(textBox9);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(CreateAttendantPassword);
            tabPage4.Controls.Add(CreateAttendantName);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(584, 313);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // AttendantFeedback
            // 
            AttendantFeedback.BackColor = Color.White;
            AttendantFeedback.BorderStyle = BorderStyle.None;
            AttendantFeedback.Location = new Point(185, 156);
            AttendantFeedback.Name = "AttendantFeedback";
            AttendantFeedback.ReadOnly = true;
            AttendantFeedback.Size = new Size(219, 16);
            AttendantFeedback.TabIndex = 21;
            AttendantFeedback.TextAlign = HorizontalAlignment.Center;
            AttendantFeedback.TextChanged += AttendantFeedback_TextChanged;
            // 
            // button13
            // 
            button13.Location = new Point(310, 184);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 20;
            button13.Text = "Create";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.White;
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Location = new Point(119, 124);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(60, 16);
            textBox10.TabIndex = 19;
            textBox10.Text = "Password:";
            textBox10.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.White;
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Location = new Point(119, 99);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(60, 16);
            textBox11.TabIndex = 18;
            textBox11.Text = "Name:";
            textBox11.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.White;
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(100, 53);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(385, 19);
            textBox9.TabIndex = 4;
            textBox9.Text = "Please enter a name and password for the Attendant";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.White;
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(199, 19);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(186, 28);
            textBox7.TabIndex = 3;
            textBox7.Text = "Create Attendant";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button12
            // 
            button12.Location = new Point(199, 184);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 2;
            button12.Text = "Back";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // CreateAttendantPassword
            // 
            CreateAttendantPassword.Location = new Point(185, 125);
            CreateAttendantPassword.Name = "CreateAttendantPassword";
            CreateAttendantPassword.Size = new Size(219, 23);
            CreateAttendantPassword.TabIndex = 1;
            CreateAttendantPassword.TextChanged += CreateAttendantPassword_TextChanged;
            // 
            // CreateAttendantName
            // 
            CreateAttendantName.Location = new Point(185, 96);
            CreateAttendantName.Name = "CreateAttendantName";
            CreateAttendantName.Size = new Size(219, 23);
            CreateAttendantName.TabIndex = 0;
            CreateAttendantName.TextChanged += textBox4_TextChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button14);
            tabPage5.Controls.Add(textBox4);
            tabPage5.Controls.Add(AttendantList);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(584, 313);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(255, 270);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 14;
            button14.Text = "Back";
            button14.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(30, 16);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(525, 42);
            textBox4.TabIndex = 13;
            textBox4.Text = "Attendant List";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // AttendantList
            // 
            AttendantList.Location = new Point(92, 64);
            AttendantList.Name = "AttendantList";
            AttendantList.Size = new Size(400, 200);
            AttendantList.TabIndex = 3;
            AttendantList.UseCompatibleStateImageBehavior = false;
            AttendantList.View = View.Details;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(SaleTotalText);
            tabPage6.Controls.Add(InvalidSaleText);
            tabPage6.Controls.Add(InvalidQuantityText);
            tabPage6.Controls.Add(textBox17);
            tabPage6.Controls.Add(textBox16);
            tabPage6.Controls.Add(textBox15);
            tabPage6.Controls.Add(button17);
            tabPage6.Controls.Add(button16);
            tabPage6.Controls.Add(QuantityText);
            tabPage6.Controls.Add(SaleMenu);
            tabPage6.Controls.Add(button15);
            tabPage6.Controls.Add(SaleDisplay);
            tabPage6.Controls.Add(textBox6);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(584, 313);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // SaleTotalText
            // 
            SaleTotalText.BackColor = Color.White;
            SaleTotalText.BorderStyle = BorderStyle.None;
            SaleTotalText.Location = new Point(318, 228);
            SaleTotalText.Name = "SaleTotalText";
            SaleTotalText.ReadOnly = true;
            SaleTotalText.Size = new Size(258, 16);
            SaleTotalText.TabIndex = 16;
            SaleTotalText.Text = "Sale Total: ";
            // 
            // InvalidSaleText
            // 
            InvalidSaleText.BackColor = Color.White;
            InvalidSaleText.BorderStyle = BorderStyle.None;
            InvalidSaleText.Location = new Point(318, 254);
            InvalidSaleText.Multiline = true;
            InvalidSaleText.Name = "InvalidSaleText";
            InvalidSaleText.ReadOnly = true;
            InvalidSaleText.Size = new Size(258, 15);
            InvalidSaleText.TabIndex = 15;
            InvalidSaleText.TextAlign = HorizontalAlignment.Center;
            // 
            // InvalidQuantityText
            // 
            InvalidQuantityText.BackColor = Color.White;
            InvalidQuantityText.BorderStyle = BorderStyle.None;
            InvalidQuantityText.Location = new Point(79, 259);
            InvalidQuantityText.Multiline = true;
            InvalidQuantityText.Name = "InvalidQuantityText";
            InvalidQuantityText.ReadOnly = true;
            InvalidQuantityText.Size = new Size(91, 33);
            InvalidQuantityText.TabIndex = 14;
            InvalidQuantityText.TextAlign = HorizontalAlignment.Center;
            InvalidQuantityText.TextChanged += textBox18_TextChanged;
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.White;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox17.Location = new Point(318, 48);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(100, 22);
            textBox17.TabIndex = 13;
            textBox17.Text = "Current Order";
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.White;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox16.Location = new Point(8, 48);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(100, 22);
            textBox16.TabIndex = 12;
            textBox16.Text = "Menu";
            // 
            // textBox15
            // 
            textBox15.BackColor = Color.White;
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Location = new Point(79, 231);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(91, 38);
            textBox15.TabIndex = 11;
            textBox15.Text = "Enter Quantity:";
            // 
            // button17
            // 
            button17.Location = new Point(8, 228);
            button17.Name = "button17";
            button17.Size = new Size(65, 77);
            button17.TabIndex = 10;
            button17.Text = "Cancel";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(175, 257);
            button16.Name = "button16";
            button16.Size = new Size(137, 48);
            button16.TabIndex = 9;
            button16.Text = "Add to Sale";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // QuantityText
            // 
            QuantityText.Location = new Point(175, 228);
            QuantityText.Name = "QuantityText";
            QuantityText.Size = new Size(137, 23);
            QuantityText.TabIndex = 8;
            // 
            // SaleMenu
            // 
            SaleMenu.Location = new Point(8, 70);
            SaleMenu.MultiSelect = false;
            SaleMenu.Name = "SaleMenu";
            SaleMenu.Size = new Size(304, 152);
            SaleMenu.TabIndex = 7;
            SaleMenu.UseCompatibleStateImageBehavior = false;
            SaleMenu.View = View.Details;
            // 
            // button15
            // 
            button15.Location = new Point(318, 272);
            button15.Name = "button15";
            button15.Size = new Size(258, 33);
            button15.TabIndex = 6;
            button15.Text = "Tender Sale";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // SaleDisplay
            // 
            SaleDisplay.Location = new Point(318, 70);
            SaleDisplay.Name = "SaleDisplay";
            SaleDisplay.Size = new Size(258, 152);
            SaleDisplay.TabIndex = 5;
            SaleDisplay.UseCompatibleStateImageBehavior = false;
            SaleDisplay.View = View.Details;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.White;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(175, 6);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(186, 33);
            textBox6.TabIndex = 4;
            textBox6.Text = "Sale Menu";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(button10);
            tabPage7.Controls.Add(SaleListDetails);
            tabPage7.Controls.Add(SalesList);
            tabPage7.Controls.Add(textBox8);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(584, 313);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(255, 269);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 7;
            button10.Text = "Back";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // SaleListDetails
            // 
            SaleListDetails.Location = new Point(292, 64);
            SaleListDetails.Name = "SaleListDetails";
            SaleListDetails.Size = new Size(284, 199);
            SaleListDetails.TabIndex = 6;
            SaleListDetails.UseCompatibleStateImageBehavior = false;
            SaleListDetails.View = View.Details;
            // 
            // SalesList
            // 
            SalesList.FormattingEnabled = true;
            SalesList.ItemHeight = 15;
            SalesList.Location = new Point(41, 64);
            SalesList.Name = "SalesList";
            SalesList.Size = new Size(236, 199);
            SalesList.TabIndex = 5;
            SalesList.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.White;
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(199, 27);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(186, 28);
            textBox8.TabIndex = 4;
            textBox8.Text = "Sale History";
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(textBox18);
            tabPage8.Controls.Add(StockQuantityFail);
            tabPage8.Controls.Add(textBox20);
            tabPage8.Controls.Add(textBox21);
            tabPage8.Controls.Add(textBox22);
            tabPage8.Controls.Add(button19);
            tabPage8.Controls.Add(button20);
            tabPage8.Controls.Add(OrderStockQuantity);
            tabPage8.Controls.Add(OrderStockList);
            tabPage8.Controls.Add(button21);
            tabPage8.Controls.Add(CurrentOrderList);
            tabPage8.Controls.Add(textBox12);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(584, 313);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            textBox18.BackColor = Color.White;
            textBox18.BorderStyle = BorderStyle.None;
            textBox18.Location = new Point(318, 256);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.Size = new Size(258, 15);
            textBox18.TabIndex = 27;
            textBox18.TextAlign = HorizontalAlignment.Center;
            // 
            // StockQuantityFail
            // 
            StockQuantityFail.BackColor = Color.White;
            StockQuantityFail.BorderStyle = BorderStyle.None;
            StockQuantityFail.Location = new Point(79, 261);
            StockQuantityFail.Multiline = true;
            StockQuantityFail.Name = "StockQuantityFail";
            StockQuantityFail.ReadOnly = true;
            StockQuantityFail.Size = new Size(91, 33);
            StockQuantityFail.TabIndex = 26;
            StockQuantityFail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            textBox20.BackColor = Color.White;
            textBox20.BorderStyle = BorderStyle.None;
            textBox20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox20.Location = new Point(318, 50);
            textBox20.Name = "textBox20";
            textBox20.ReadOnly = true;
            textBox20.Size = new Size(100, 22);
            textBox20.TabIndex = 25;
            textBox20.Text = "Current Order";
            // 
            // textBox21
            // 
            textBox21.BackColor = Color.White;
            textBox21.BorderStyle = BorderStyle.None;
            textBox21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox21.Location = new Point(8, 50);
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.Size = new Size(100, 22);
            textBox21.TabIndex = 24;
            textBox21.Text = "StockList";
            // 
            // textBox22
            // 
            textBox22.BackColor = Color.White;
            textBox22.BorderStyle = BorderStyle.None;
            textBox22.Location = new Point(79, 233);
            textBox22.Multiline = true;
            textBox22.Name = "textBox22";
            textBox22.ReadOnly = true;
            textBox22.Size = new Size(91, 38);
            textBox22.TabIndex = 23;
            textBox22.Text = "Enter Quantity:";
            // 
            // button19
            // 
            button19.Location = new Point(8, 230);
            button19.Name = "button19";
            button19.Size = new Size(65, 77);
            button19.TabIndex = 22;
            button19.Text = "Cancel";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(175, 259);
            button20.Name = "button20";
            button20.Size = new Size(137, 48);
            button20.TabIndex = 21;
            button20.Text = "Add to Order";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button20_Click_1;
            // 
            // OrderStockQuantity
            // 
            OrderStockQuantity.Location = new Point(175, 230);
            OrderStockQuantity.Name = "OrderStockQuantity";
            OrderStockQuantity.Size = new Size(137, 23);
            OrderStockQuantity.TabIndex = 20;
            // 
            // OrderStockList
            // 
            OrderStockList.Location = new Point(8, 72);
            OrderStockList.MultiSelect = false;
            OrderStockList.Name = "OrderStockList";
            OrderStockList.Size = new Size(304, 152);
            OrderStockList.TabIndex = 19;
            OrderStockList.UseCompatibleStateImageBehavior = false;
            OrderStockList.View = View.Details;
            // 
            // button21
            // 
            button21.Location = new Point(318, 274);
            button21.Name = "button21";
            button21.Size = new Size(258, 33);
            button21.TabIndex = 18;
            button21.Text = "Tender Sale";
            button21.UseVisualStyleBackColor = true;
            // 
            // CurrentOrderList
            // 
            CurrentOrderList.Location = new Point(318, 72);
            CurrentOrderList.Name = "CurrentOrderList";
            CurrentOrderList.Size = new Size(258, 152);
            CurrentOrderList.TabIndex = 17;
            CurrentOrderList.UseCompatibleStateImageBehavior = false;
            CurrentOrderList.View = View.Details;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.White;
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox12.Location = new Point(203, 18);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(186, 28);
            textBox12.TabIndex = 4;
            textBox12.Text = "Order Stock";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(button18);
            tabPage9.Controls.Add(StockListBox);
            tabPage9.Controls.Add(textBox13);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(584, 313);
            tabPage9.TabIndex = 8;
            tabPage9.Text = "tabPage9";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(255, 271);
            button18.Name = "button18";
            button18.Size = new Size(75, 23);
            button18.TabIndex = 6;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // StockListBox
            // 
            StockListBox.Location = new Point(88, 51);
            StockListBox.Name = "StockListBox";
            StockListBox.Size = new Size(409, 212);
            StockListBox.TabIndex = 5;
            StockListBox.UseCompatibleStateImageBehavior = false;
            // 
            // textBox13
            // 
            textBox13.BackColor = Color.White;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(196, 17);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(186, 28);
            textBox13.TabIndex = 4;
            textBox13.Text = "Stock List";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // RestaurantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 341);
            Controls.Add(TabController);
            Name = "RestaurantForm";
            Text = "Form2";
            FormClosing += RestaurantForm_FormClosing;
            Load += Form2_Load;
            TabController.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabController;
        private TabPage tabPage1;
        private Button button3;
        private Button button1;
        private TextBox CreateAttendantName;
        private TextBox textBox5;
        private TextBox UsernameTextbox;
        private TextBox textBox2;
        private TextBox LoginTitle;
        private TabPage tabPage2;
        public TextBox PasswordTextbox;
        private TextBox FailTextbox;
        private TabPage tabPage3;
        private Button RestaurantButton;
        private TextBox Subtitle;
        private TextBox Title;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button11;
        private Button button9;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox textBox7;
        private Button button12;
        private TextBox CreateAttendantPassword;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private ListView AttendantList;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button button13;
        private TextBox AttendantFeedback;
        private Button button14;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox15;
        private Button button17;
        private Button button16;
        private TextBox QuantityText;
        private ListView SaleMenu;
        private Button button15;
        private ListView SaleDisplay;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox InvalidQuantityText;
        private TextBox InvalidSaleText;
        private TextBox SaleTotalText;
        private ListBox SalesList;
        private Button button10;
        private ListView SaleListDetails;
        private Button button18;
        private ListView StockListBox;
        private TextBox textBox18;
        private TextBox StockQuantityFail;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private Button button19;
        private Button button20;
        private TextBox OrderStockQuantity;
        private ListView OrderStockList;
        private Button button21;
        private ListView CurrentOrderList;
        private Button button22;
    }
}