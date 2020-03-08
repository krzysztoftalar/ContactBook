namespace CBDesktopUI
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.NavBar = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.flowLayoutMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.AddNewAddress = new System.Windows.Forms.Button();
            this.AddNewPhone = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.country = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.homeNumber = new System.Windows.Forms.TextBox();
            this.addressesTypes = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.phoneTypes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.PersonsList = new System.Windows.Forms.ListView();
            this.NavBar.SuspendLayout();
            this.flowLayoutMainPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavBar.AutoSize = true;
            this.NavBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NavBar.Controls.Add(this.DeleteButton);
            this.NavBar.Controls.Add(this.EditButton);
            this.NavBar.Controls.Add(this.AddButton);
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1035, 80);
            this.NavBar.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton.BackgroundImage = global::CBDesktopUI.Properties.Resources.deleteIcon;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.Location = new System.Drawing.Point(950, 12);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(70, 50);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            this.EditButton.AutoSize = true;
            this.EditButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditButton.BackgroundImage = global::CBDesktopUI.Properties.Resources.createIcon;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditButton.Location = new System.Drawing.Point(874, 12);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(70, 50);
            this.EditButton.TabIndex = 2;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton.BackgroundImage = global::CBDesktopUI.Properties.Resources.addIcon;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddButton.Location = new System.Drawing.Point(798, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(70, 50);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "\r\n";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // flowLayoutMainPanel
            // 
            this.flowLayoutMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutMainPanel.AutoScroll = true;
            this.flowLayoutMainPanel.Controls.Add(this.mainPanel);
            this.flowLayoutMainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutMainPanel.Location = new System.Drawing.Point(300, 80);
            this.flowLayoutMainPanel.Name = "flowLayoutMainPanel";
            this.flowLayoutMainPanel.Size = new System.Drawing.Size(730, 761);
            this.flowLayoutMainPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainPanel.Controls.Add(this.AddNewAddress);
            this.mainPanel.Controls.Add(this.AddNewPhone);
            this.mainPanel.Controls.Add(this.SaveButton);
            this.mainPanel.Controls.Add(this.tableLayoutPanel3);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.tableLayoutPanel2);
            this.mainPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainPanel.Enabled = false;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(717, 761);
            this.mainPanel.TabIndex = 0;
            // 
            // AddNewAddress
            // 
            this.AddNewAddress.AutoSize = true;
            this.AddNewAddress.BackColor = System.Drawing.Color.Green;
            this.AddNewAddress.BackgroundImage = global::CBDesktopUI.Properties.Resources.saveIcon;
            this.AddNewAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewAddress.Location = new System.Drawing.Point(190, 445);
            this.AddNewAddress.Name = "AddNewAddress";
            this.AddNewAddress.Size = new System.Drawing.Size(46, 47);
            this.AddNewAddress.TabIndex = 8;
            this.AddNewAddress.Text = "\r\n";
            this.AddNewAddress.UseVisualStyleBackColor = false;
            this.AddNewAddress.Click += new System.EventHandler(this.AddNewAddress_Click);
            // 
            // AddNewPhone
            // 
            this.AddNewPhone.AutoSize = true;
            this.AddNewPhone.BackColor = System.Drawing.Color.Green;
            this.AddNewPhone.BackgroundImage = global::CBDesktopUI.Properties.Resources.saveIcon;
            this.AddNewPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddNewPhone.Location = new System.Drawing.Point(190, 290);
            this.AddNewPhone.Name = "AddNewPhone";
            this.AddNewPhone.Size = new System.Drawing.Size(46, 47);
            this.AddNewPhone.TabIndex = 7;
            this.AddNewPhone.Text = "\r\n";
            this.AddNewPhone.UseVisualStyleBackColor = false;
            this.AddNewPhone.Click += new System.EventHandler(this.AddNewPhone_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.BackColor = System.Drawing.Color.Green;
            this.SaveButton.BackgroundImage = global::CBDesktopUI.Properties.Resources.saveIcon;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveButton.Location = new System.Drawing.Point(623, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 50);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "\r\n";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.country, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.city, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.street, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.homeNumber, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.addressesTypes, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 504);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(671, 200);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // country
            // 
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.country.Location = new System.Drawing.Point(168, 163);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(500, 30);
            this.country.TabIndex = 12;
            // 
            // city
            // 
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.city.Location = new System.Drawing.Point(168, 123);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(500, 30);
            this.city.TabIndex = 11;
            // 
            // street
            // 
            this.street.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.street.Location = new System.Drawing.Point(168, 83);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(500, 30);
            this.street.TabIndex = 10;
            // 
            // homeNumber
            // 
            this.homeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeNumber.Location = new System.Drawing.Point(168, 43);
            this.homeNumber.Name = "homeNumber";
            this.homeNumber.Size = new System.Drawing.Size(500, 30);
            this.homeNumber.TabIndex = 9;
            // 
            // addressesTypes
            // 
            this.addressesTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressesTypes.FormattingEnabled = true;
            this.addressesTypes.Location = new System.Drawing.Point(168, 3);
            this.addressesTypes.Name = "addressesTypes";
            this.addressesTypes.Size = new System.Drawing.Size(244, 33);
            this.addressesTypes.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(3, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Home number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(3, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(3, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(3, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Street";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(26, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(26, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.phoneNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.phoneTypes, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 350);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(671, 82);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phone number";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneNumber.Location = new System.Drawing.Point(168, 44);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(500, 30);
            this.phoneNumber.TabIndex = 6;
            // 
            // phoneTypes
            // 
            this.phoneTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneTypes.FormattingEnabled = true;
            this.phoneTypes.Location = new System.Drawing.Point(168, 3);
            this.phoneTypes.Name = "phoneTypes";
            this.phoneTypes.Size = new System.Drawing.Size(244, 33);
            this.phoneTypes.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.emailAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.description, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.firstName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // emailAddress
            // 
            this.emailAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "EmailAddress", true));
            this.emailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailAddress.Location = new System.Drawing.Point(168, 81);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(500, 30);
            this.emailAddress.TabIndex = 7;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(CBDesktopUI.Library.Models.PersonDbModel);
            // 
            // lastName
            // 
            this.lastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "LastName", true));
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastName.Location = new System.Drawing.Point(168, 42);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(500, 30);
            this.lastName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "First name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email address";
            // 
            // description
            // 
            this.description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "Description", true));
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.description.Location = new System.Drawing.Point(168, 120);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(500, 76);
            this.description.TabIndex = 4;
            this.description.Text = "";
            // 
            // firstName
            // 
            this.firstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "FirstName", true));
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstName.Location = new System.Drawing.Point(168, 3);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(500, 30);
            this.firstName.TabIndex = 5;
            // 
            // PersonsList
            // 
            this.PersonsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PersonsList.HideSelection = false;
            this.PersonsList.Location = new System.Drawing.Point(0, 80);
            this.PersonsList.Name = "PersonsList";
            this.PersonsList.Size = new System.Drawing.Size(300, 778);
            this.PersonsList.TabIndex = 1;
            this.PersonsList.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 853);
            this.Controls.Add(this.flowLayoutMainPanel);
            this.Controls.Add(this.PersonsList);
            this.Controls.Add(this.NavBar);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "Contact Book";
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.flowLayoutMainPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMainPanel;
        private System.Windows.Forms.ListView PersonsList;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.ComboBox phoneTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox homeNumber;
        private System.Windows.Forms.ComboBox addressesTypes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button AddNewPhone;
        private System.Windows.Forms.Button AddNewAddress;
    }
}