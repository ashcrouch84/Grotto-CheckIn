namespace Grotto_CheckIn
{
    partial class Form1
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
            this.txtRef = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.cmdControl = new System.Windows.Forms.Button();
            this.txtControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSaveFTP = new System.Windows.Forms.Button();
            this.cmdPlace = new System.Windows.Forms.Button();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstDetails = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSofas = new System.Windows.Forms.ListBox();
            this.cmdS1 = new System.Windows.Forms.Button();
            this.cmdS2 = new System.Windows.Forms.Button();
            this.cmdS4 = new System.Windows.Forms.Button();
            this.cmdS3 = new System.Windows.Forms.Button();
            this.cmdS8 = new System.Windows.Forms.Button();
            this.cmdS7 = new System.Windows.Forms.Button();
            this.cmdS6 = new System.Windows.Forms.Button();
            this.cmdS5 = new System.Windows.Forms.Button();
            this.cmdS16 = new System.Windows.Forms.Button();
            this.cmdS15 = new System.Windows.Forms.Button();
            this.cmdS14 = new System.Windows.Forms.Button();
            this.cmdS13 = new System.Windows.Forms.Button();
            this.cmdS12 = new System.Windows.Forms.Button();
            this.cmdS11 = new System.Windows.Forms.Button();
            this.cmdS10 = new System.Windows.Forms.Button();
            this.cmdS9 = new System.Windows.Forms.Button();
            this.lstBook = new System.Windows.Forms.ListBox();
            this.lstRef = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstTime = new System.Windows.Forms.ListBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.chkSofa = new System.Windows.Forms.CheckBox();
            this.lstQty = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lstWait = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cmdRemove = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(190, 29);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(330, 35);
            this.txtRef.TabIndex = 0;
            this.txtRef.TextChanged += new System.EventHandler(this.txtRef_TextChanged);
            this.txtRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRef_KeyDown);
            this.txtRef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRef_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1792, 772);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmdRemove);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.lstWait);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lstQty);
            this.tabPage1.Controls.Add(this.cmdFind);
            this.tabPage1.Controls.Add(this.lstTime);
            this.tabPage1.Controls.Add(this.lstRef);
            this.tabPage1.Controls.Add(this.lstBook);
            this.tabPage1.Controls.Add(this.lstSofas);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lstDetails);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtRef);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1784, 739);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Check In";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkSofa);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtInterval);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmdPlace);
            this.tabPage2.Controls.Add(this.txtPlace);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmdSaveFTP);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtUsername);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPort);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtHost);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmdControl);
            this.tabPage2.Controls.Add(this.txtControl);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmdBrowse);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1784, 739);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Save Location";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(189, 61);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(365, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(603, 64);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(105, 32);
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // cmdControl
            // 
            this.cmdControl.Location = new System.Drawing.Point(603, 137);
            this.cmdControl.Name = "cmdControl";
            this.cmdControl.Size = new System.Drawing.Size(105, 32);
            this.cmdControl.TabIndex = 5;
            this.cmdControl.Text = "Browse";
            this.cmdControl.UseVisualStyleBackColor = true;
            this.cmdControl.Click += new System.EventHandler(this.cmdControl_Click);
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(189, 134);
            this.txtControl.Name = "txtControl";
            this.txtControl.Size = new System.Drawing.Size(365, 26);
            this.txtControl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Control Location";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(189, 251);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(184, 26);
            this.txtHost.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Host";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(189, 293);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(184, 26);
            this.txtPort.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(562, 254);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 26);
            this.txtUsername.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(562, 296);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 26);
            this.txtPassword.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password";
            // 
            // cmdSaveFTP
            // 
            this.cmdSaveFTP.Location = new System.Drawing.Point(789, 270);
            this.cmdSaveFTP.Name = "cmdSaveFTP";
            this.cmdSaveFTP.Size = new System.Drawing.Size(105, 32);
            this.cmdSaveFTP.TabIndex = 14;
            this.cmdSaveFTP.Text = "Save FTP";
            this.cmdSaveFTP.UseVisualStyleBackColor = true;
            // 
            // cmdPlace
            // 
            this.cmdPlace.Location = new System.Drawing.Point(603, 192);
            this.cmdPlace.Name = "cmdPlace";
            this.cmdPlace.Size = new System.Drawing.Size(105, 32);
            this.cmdPlace.TabIndex = 17;
            this.cmdPlace.Text = "Browse";
            this.cmdPlace.UseVisualStyleBackColor = true;
            this.cmdPlace.Click += new System.EventHandler(this.cmdPlace_Click);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(189, 189);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(365, 26);
            this.txtPlace.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Save Location";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Reference";
            // 
            // lstDetails
            // 
            this.lstDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDetails.FormattingEnabled = true;
            this.lstDetails.ItemHeight = 29;
            this.lstDetails.Location = new System.Drawing.Point(21, 92);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(709, 323);
            this.lstDetails.TabIndex = 3;
            this.lstDetails.SelectedIndexChanged += new System.EventHandler(this.lstDetails_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdS16);
            this.groupBox1.Controls.Add(this.cmdS15);
            this.groupBox1.Controls.Add(this.cmdS14);
            this.groupBox1.Controls.Add(this.cmdS13);
            this.groupBox1.Controls.Add(this.cmdS12);
            this.groupBox1.Controls.Add(this.cmdS11);
            this.groupBox1.Controls.Add(this.cmdS10);
            this.groupBox1.Controls.Add(this.cmdS9);
            this.groupBox1.Controls.Add(this.cmdS8);
            this.groupBox1.Controls.Add(this.cmdS7);
            this.groupBox1.Controls.Add(this.cmdS6);
            this.groupBox1.Controls.Add(this.cmdS5);
            this.groupBox1.Controls.Add(this.cmdS4);
            this.groupBox1.Controls.Add(this.cmdS3);
            this.groupBox1.Controls.Add(this.cmdS2);
            this.groupBox1.Controls.Add(this.cmdS1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(22, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 303);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sofa Allocation";
            // 
            // lstSofas
            // 
            this.lstSofas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSofas.FormattingEnabled = true;
            this.lstSofas.ItemHeight = 29;
            this.lstSofas.Location = new System.Drawing.Point(749, 81);
            this.lstSofas.Name = "lstSofas";
            this.lstSofas.Size = new System.Drawing.Size(55, 642);
            this.lstSofas.TabIndex = 5;
            this.lstSofas.Click += new System.EventHandler(this.lstSofas_Click);
            // 
            // cmdS1
            // 
            this.cmdS1.Location = new System.Drawing.Point(21, 42);
            this.cmdS1.Name = "cmdS1";
            this.cmdS1.Size = new System.Drawing.Size(119, 54);
            this.cmdS1.TabIndex = 0;
            this.cmdS1.Text = "Sofa 1";
            this.cmdS1.UseVisualStyleBackColor = true;
            this.cmdS1.Click += new System.EventHandler(this.cmdS1_Click);
            // 
            // cmdS2
            // 
            this.cmdS2.Location = new System.Drawing.Point(21, 102);
            this.cmdS2.Name = "cmdS2";
            this.cmdS2.Size = new System.Drawing.Size(119, 54);
            this.cmdS2.TabIndex = 1;
            this.cmdS2.Text = "Sofa 2";
            this.cmdS2.UseVisualStyleBackColor = true;
            this.cmdS2.Click += new System.EventHandler(this.cmdS2_Click);
            // 
            // cmdS4
            // 
            this.cmdS4.Location = new System.Drawing.Point(21, 222);
            this.cmdS4.Name = "cmdS4";
            this.cmdS4.Size = new System.Drawing.Size(119, 54);
            this.cmdS4.TabIndex = 3;
            this.cmdS4.Text = "Sofa 4";
            this.cmdS4.UseVisualStyleBackColor = true;
            this.cmdS4.Click += new System.EventHandler(this.cmdS4_Click);
            // 
            // cmdS3
            // 
            this.cmdS3.Location = new System.Drawing.Point(21, 162);
            this.cmdS3.Name = "cmdS3";
            this.cmdS3.Size = new System.Drawing.Size(119, 54);
            this.cmdS3.TabIndex = 2;
            this.cmdS3.Text = "Sofa 3";
            this.cmdS3.UseVisualStyleBackColor = true;
            this.cmdS3.Click += new System.EventHandler(this.cmdS3_Click);
            // 
            // cmdS8
            // 
            this.cmdS8.Location = new System.Drawing.Point(157, 222);
            this.cmdS8.Name = "cmdS8";
            this.cmdS8.Size = new System.Drawing.Size(119, 54);
            this.cmdS8.TabIndex = 7;
            this.cmdS8.Text = "Sofa 8";
            this.cmdS8.UseVisualStyleBackColor = true;
            this.cmdS8.Click += new System.EventHandler(this.cmdS8_Click);
            // 
            // cmdS7
            // 
            this.cmdS7.Location = new System.Drawing.Point(157, 162);
            this.cmdS7.Name = "cmdS7";
            this.cmdS7.Size = new System.Drawing.Size(119, 54);
            this.cmdS7.TabIndex = 6;
            this.cmdS7.Text = "Sofa 7";
            this.cmdS7.UseVisualStyleBackColor = true;
            this.cmdS7.Click += new System.EventHandler(this.cmdS7_Click);
            // 
            // cmdS6
            // 
            this.cmdS6.Location = new System.Drawing.Point(157, 102);
            this.cmdS6.Name = "cmdS6";
            this.cmdS6.Size = new System.Drawing.Size(119, 54);
            this.cmdS6.TabIndex = 5;
            this.cmdS6.Text = "Sofa 6";
            this.cmdS6.UseVisualStyleBackColor = true;
            this.cmdS6.Click += new System.EventHandler(this.cmdS6_Click);
            // 
            // cmdS5
            // 
            this.cmdS5.Location = new System.Drawing.Point(157, 42);
            this.cmdS5.Name = "cmdS5";
            this.cmdS5.Size = new System.Drawing.Size(119, 54);
            this.cmdS5.TabIndex = 4;
            this.cmdS5.Text = "Sofa 5";
            this.cmdS5.UseVisualStyleBackColor = true;
            this.cmdS5.Click += new System.EventHandler(this.cmdS5_Click);
            // 
            // cmdS16
            // 
            this.cmdS16.Location = new System.Drawing.Point(435, 222);
            this.cmdS16.Name = "cmdS16";
            this.cmdS16.Size = new System.Drawing.Size(119, 54);
            this.cmdS16.TabIndex = 15;
            this.cmdS16.Text = "Sofa 16";
            this.cmdS16.UseVisualStyleBackColor = true;
            this.cmdS16.Click += new System.EventHandler(this.cmdS16_Click);
            // 
            // cmdS15
            // 
            this.cmdS15.Location = new System.Drawing.Point(435, 162);
            this.cmdS15.Name = "cmdS15";
            this.cmdS15.Size = new System.Drawing.Size(119, 54);
            this.cmdS15.TabIndex = 14;
            this.cmdS15.Text = "Sofa 15";
            this.cmdS15.UseVisualStyleBackColor = true;
            this.cmdS15.Click += new System.EventHandler(this.cmdS15_Click);
            // 
            // cmdS14
            // 
            this.cmdS14.Location = new System.Drawing.Point(435, 102);
            this.cmdS14.Name = "cmdS14";
            this.cmdS14.Size = new System.Drawing.Size(119, 54);
            this.cmdS14.TabIndex = 13;
            this.cmdS14.Text = "Sofa 14";
            this.cmdS14.UseVisualStyleBackColor = true;
            this.cmdS14.Click += new System.EventHandler(this.cmdS14_Click);
            // 
            // cmdS13
            // 
            this.cmdS13.Location = new System.Drawing.Point(435, 42);
            this.cmdS13.Name = "cmdS13";
            this.cmdS13.Size = new System.Drawing.Size(119, 54);
            this.cmdS13.TabIndex = 12;
            this.cmdS13.Text = "Sofa 13";
            this.cmdS13.UseVisualStyleBackColor = true;
            this.cmdS13.Click += new System.EventHandler(this.cmdS13_Click);
            // 
            // cmdS12
            // 
            this.cmdS12.Location = new System.Drawing.Point(298, 222);
            this.cmdS12.Name = "cmdS12";
            this.cmdS12.Size = new System.Drawing.Size(119, 54);
            this.cmdS12.TabIndex = 11;
            this.cmdS12.Text = "Sofa 12";
            this.cmdS12.UseVisualStyleBackColor = true;
            this.cmdS12.Click += new System.EventHandler(this.cmdS12_Click);
            // 
            // cmdS11
            // 
            this.cmdS11.Location = new System.Drawing.Point(298, 162);
            this.cmdS11.Name = "cmdS11";
            this.cmdS11.Size = new System.Drawing.Size(119, 54);
            this.cmdS11.TabIndex = 10;
            this.cmdS11.Text = "Sofa 11";
            this.cmdS11.UseVisualStyleBackColor = true;
            this.cmdS11.Click += new System.EventHandler(this.cmdS11_Click);
            // 
            // cmdS10
            // 
            this.cmdS10.Location = new System.Drawing.Point(298, 102);
            this.cmdS10.Name = "cmdS10";
            this.cmdS10.Size = new System.Drawing.Size(119, 54);
            this.cmdS10.TabIndex = 9;
            this.cmdS10.Text = "Sofa 10";
            this.cmdS10.UseVisualStyleBackColor = true;
            this.cmdS10.Click += new System.EventHandler(this.cmdS10_Click);
            // 
            // cmdS9
            // 
            this.cmdS9.Location = new System.Drawing.Point(298, 42);
            this.cmdS9.Name = "cmdS9";
            this.cmdS9.Size = new System.Drawing.Size(119, 54);
            this.cmdS9.TabIndex = 8;
            this.cmdS9.Text = "Sofa 9";
            this.cmdS9.UseVisualStyleBackColor = true;
            this.cmdS9.Click += new System.EventHandler(this.cmdS9_Click);
            // 
            // lstBook
            // 
            this.lstBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBook.FormattingEnabled = true;
            this.lstBook.ItemHeight = 29;
            this.lstBook.Location = new System.Drawing.Point(819, 81);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(93, 642);
            this.lstBook.TabIndex = 6;
            this.lstBook.Click += new System.EventHandler(this.lstBook_Click);
            // 
            // lstRef
            // 
            this.lstRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRef.FormattingEnabled = true;
            this.lstRef.HorizontalScrollbar = true;
            this.lstRef.ItemHeight = 29;
            this.lstRef.Location = new System.Drawing.Point(979, 81);
            this.lstRef.Name = "lstRef";
            this.lstRef.Size = new System.Drawing.Size(557, 642);
            this.lstRef.TabIndex = 7;
            this.lstRef.SelectedIndexChanged += new System.EventHandler(this.lstRef_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save Interval";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(189, 20);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(129, 26);
            this.txtInterval.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Timer Interval";
            // 
            // lstTime
            // 
            this.lstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTime.FormattingEnabled = true;
            this.lstTime.ItemHeight = 29;
            this.lstTime.Location = new System.Drawing.Point(1542, 81);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(124, 642);
            this.lstTime.TabIndex = 8;
            this.lstTime.SelectedIndexChanged += new System.EventHandler(this.lstTime_SelectedIndexChanged);
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(551, 33);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(152, 33);
            this.cmdFind.TabIndex = 13;
            this.cmdFind.Text = "Add Reference";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // chkSofa
            // 
            this.chkSofa.AutoSize = true;
            this.chkSofa.Location = new System.Drawing.Point(1024, 61);
            this.chkSofa.Name = "chkSofa";
            this.chkSofa.Size = new System.Drawing.Size(122, 24);
            this.chkSofa.TabIndex = 21;
            this.chkSofa.Text = "Using Sofas";
            this.chkSofa.UseVisualStyleBackColor = true;
            this.chkSofa.CheckedChanged += new System.EventHandler(this.chkSofa_CheckedChanged);
            // 
            // lstQty
            // 
            this.lstQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQty.FormattingEnabled = true;
            this.lstQty.ItemHeight = 29;
            this.lstQty.Location = new System.Drawing.Point(927, 81);
            this.lstQty.Name = "lstQty";
            this.lstQty.Size = new System.Drawing.Size(46, 642);
            this.lstQty.TabIndex = 14;
            this.lstQty.Click += new System.EventHandler(this.lstQty_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(744, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sofa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(837, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ref";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(922, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "Qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(998, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 29);
            this.label13.TabIndex = 18;
            this.label13.Text = "Details";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1537, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "Checked In";
            // 
            // lstWait
            // 
            this.lstWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWait.FormattingEnabled = true;
            this.lstWait.ItemHeight = 29;
            this.lstWait.Location = new System.Drawing.Point(1672, 81);
            this.lstWait.Name = "lstWait";
            this.lstWait.Size = new System.Drawing.Size(97, 642);
            this.lstWait.TabIndex = 20;
            this.lstWait.SelectedIndexChanged += new System.EventHandler(this.lstWait_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1681, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "Waited";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(1274, 33);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(130, 33);
            this.cmdRemove.TabIndex = 22;
            this.cmdRemove.Text = "Remove Family";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 810);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Grotto Check In";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button cmdControl;
        private System.Windows.Forms.TextBox txtControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdSaveFTP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdPlace;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstSofas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdS16;
        private System.Windows.Forms.Button cmdS15;
        private System.Windows.Forms.Button cmdS14;
        private System.Windows.Forms.Button cmdS13;
        private System.Windows.Forms.Button cmdS12;
        private System.Windows.Forms.Button cmdS11;
        private System.Windows.Forms.Button cmdS10;
        private System.Windows.Forms.Button cmdS9;
        private System.Windows.Forms.Button cmdS8;
        private System.Windows.Forms.Button cmdS7;
        private System.Windows.Forms.Button cmdS6;
        private System.Windows.Forms.Button cmdS5;
        private System.Windows.Forms.Button cmdS4;
        private System.Windows.Forms.Button cmdS3;
        private System.Windows.Forms.Button cmdS2;
        private System.Windows.Forms.Button cmdS1;
        private System.Windows.Forms.ListBox lstRef;
        private System.Windows.Forms.ListBox lstBook;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.CheckBox chkSofa;
        private System.Windows.Forms.ListBox lstQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lstWait;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button cmdRemove;
    }
}

