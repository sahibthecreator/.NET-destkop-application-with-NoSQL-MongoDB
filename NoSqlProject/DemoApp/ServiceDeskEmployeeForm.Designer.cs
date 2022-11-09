namespace DemoApp
{
    partial class ServiceDeskEmployeeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageIncidentManagement = new System.Windows.Forms.TabPage();
            this.panelTicketsOverview = new System.Windows.Forms.Panel();
            this.btnLow = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHigh = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.textBoxFilterBySubject = new System.Windows.Forms.TextBox();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelCreateTicket = new System.Windows.Forms.Panel();
            this.lblErroroCreateTicket = new System.Windows.Forms.Label();
            this.lblErrorCreateTicket = new System.Windows.Forms.Label();
            this.cmbPriorityIncident = new System.Windows.Forms.ComboBox();
            this.txtDescriptionIncident = new System.Windows.Forms.RichTextBox();
            this.cmbDeadlineIncident = new System.Windows.Forms.ComboBox();
            this.cmbTypeIncident = new System.Windows.Forms.ComboBox();
            this.txtUserNameIncident = new System.Windows.Forms.TextBox();
            this.txtSubjectIncident = new System.Windows.Forms.TextBox();
            this.txtDateReported = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelCreateTicket = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageUserManagement = new System.Windows.Forms.TabPage();
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.textBoxFilterByEmail = new System.Windows.Forms.TextBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAddUser = new System.Windows.Forms.Panel();
            this.comboLocation = new System.Windows.Forms.ComboBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.pbPast = new CircularProgressBar.CircularProgressBar();
            this.pbUnresolved = new CircularProgressBar.CircularProgressBar();
            this.lblPast1 = new System.Windows.Forms.Label();
            this.lblPast2 = new System.Windows.Forms.Label();
            this.lblUnresolved1 = new System.Windows.Forms.Label();
            this.lblUnresolved2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageIncidentManagement.SuspendLayout();
            this.panelTicketsOverview.SuspendLayout();
            this.panelCreateTicket.SuspendLayout();
            this.tabPageUserManagement.SuspendLayout();
            this.panelUserManagement.SuspendLayout();
            this.panelAddUser.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageIncidentManagement);
            this.tabControl1.Controls.Add(this.tabPageUserManagement);
            this.tabControl1.Controls.Add(this.tabPageDashboard);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 550);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPageIncidentManagement
            // 
            this.tabPageIncidentManagement.Controls.Add(this.panelTicketsOverview);
            this.tabPageIncidentManagement.Controls.Add(this.panelCreateTicket);
            this.tabPageIncidentManagement.Location = new System.Drawing.Point(4, 34);
            this.tabPageIncidentManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageIncidentManagement.Name = "tabPageIncidentManagement";
            this.tabPageIncidentManagement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageIncidentManagement.Size = new System.Drawing.Size(1059, 512);
            this.tabPageIncidentManagement.TabIndex = 1;
            this.tabPageIncidentManagement.Text = "Incident Management";
            this.tabPageIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // panelTicketsOverview
            // 
            this.panelTicketsOverview.Controls.Add(this.btnLow);
            this.panelTicketsOverview.Controls.Add(this.label10);
            this.panelTicketsOverview.Controls.Add(this.btnHigh);
            this.panelTicketsOverview.Controls.Add(this.btnResolve);
            this.panelTicketsOverview.Controls.Add(this.btnCloseTicket);
            this.panelTicketsOverview.Controls.Add(this.btnDeleteTicket);
            this.panelTicketsOverview.Controls.Add(this.btnEditTicket);
            this.panelTicketsOverview.Controls.Add(this.label1);
            this.panelTicketsOverview.Controls.Add(this.btnCreateTicket);
            this.panelTicketsOverview.Controls.Add(this.textBoxFilterBySubject);
            this.panelTicketsOverview.Controls.Add(this.listViewTickets);
            this.panelTicketsOverview.Location = new System.Drawing.Point(0, 0);
            this.panelTicketsOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTicketsOverview.Name = "panelTicketsOverview";
            this.panelTicketsOverview.Size = new System.Drawing.Size(1056, 510);
            this.panelTicketsOverview.TabIndex = 0;
            // 
            // btnLow
            // 
            this.btnLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLow.Location = new System.Drawing.Point(573, 26);
            this.btnLow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(53, 28);
            this.btnLow.TabIndex = 18;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = true;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(516, 6);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Filter by priority";
            // 
            // btnHigh
            // 
            this.btnHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHigh.Location = new System.Drawing.Point(504, 25);
            this.btnHigh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(53, 30);
            this.btnHigh.TabIndex = 16;
            this.btnHigh.Text = "High";
            this.btnHigh.UseVisualStyleBackColor = true;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.BackColor = System.Drawing.Color.Yellow;
            this.btnResolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolve.Location = new System.Drawing.Point(947, 85);
            this.btnResolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(100, 41);
            this.btnResolve.TabIndex = 15;
            this.btnResolve.Text = "RESOLVE";
            this.btnResolve.UseVisualStyleBackColor = false;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCloseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTicket.Location = new System.Drawing.Point(819, 85);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(100, 41);
            this.btnCloseTicket.TabIndex = 14;
            this.btnCloseTicket.Text = "CLOSE";
            this.btnCloseTicket.UseVisualStyleBackColor = false;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.Location = new System.Drawing.Point(696, 85);
            this.btnDeleteTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(100, 41);
            this.btnDeleteTicket.TabIndex = 13;
            this.btnDeleteTicket.Text = "DELETE";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.Color.Gray;
            this.btnEditTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.Location = new System.Drawing.Point(573, 85);
            this.btnEditTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(100, 41);
            this.btnEditTicket.TabIndex = 12;
            this.btnEditTicket.Text = "EDIT";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tickets overview";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicket.Location = new System.Drawing.Point(405, 85);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(149, 41);
            this.btnCreateTicket.TabIndex = 10;
            this.btnCreateTicket.Text = "CREATE TICKET";
            this.btnCreateTicket.UseVisualStyleBackColor = false;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // textBoxFilterBySubject
            // 
            this.textBoxFilterBySubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterBySubject.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterBySubject.Location = new System.Drawing.Point(61, 96);
            this.textBoxFilterBySubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterBySubject.Name = "textBoxFilterBySubject";
            this.textBoxFilterBySubject.Size = new System.Drawing.Size(284, 29);
            this.textBoxFilterBySubject.TabIndex = 11;
            this.textBoxFilterBySubject.Text = "Filter by email";
            this.textBoxFilterBySubject.Click += new System.EventHandler(this.textBoxFilterBySubject_Click);
            this.textBoxFilterBySubject.TextChanged += new System.EventHandler(this.textBoxFilterBySubject_TextChanged);
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader11,
            this.columnHeader2,
            this.columnHeader12,
            this.columnHeader3,
            this.columnHeader14,
            this.columnHeader13,
            this.columnHeader5,
            this.columnHeader15});
            this.listViewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(61, 151);
            this.listViewTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(983, 347);
            this.listViewTickets.TabIndex = 9;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "date";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Type";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "deadline";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Description";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "priority";
            // 
            // panelCreateTicket
            // 
            this.panelCreateTicket.Controls.Add(this.lblErroroCreateTicket);
            this.panelCreateTicket.Controls.Add(this.lblErrorCreateTicket);
            this.panelCreateTicket.Controls.Add(this.cmbPriorityIncident);
            this.panelCreateTicket.Controls.Add(this.txtDescriptionIncident);
            this.panelCreateTicket.Controls.Add(this.cmbDeadlineIncident);
            this.panelCreateTicket.Controls.Add(this.cmbTypeIncident);
            this.panelCreateTicket.Controls.Add(this.txtUserNameIncident);
            this.panelCreateTicket.Controls.Add(this.txtSubjectIncident);
            this.panelCreateTicket.Controls.Add(this.txtDateReported);
            this.panelCreateTicket.Controls.Add(this.label2);
            this.panelCreateTicket.Controls.Add(this.label3);
            this.panelCreateTicket.Controls.Add(this.label4);
            this.panelCreateTicket.Controls.Add(this.label5);
            this.panelCreateTicket.Controls.Add(this.label6);
            this.panelCreateTicket.Controls.Add(this.label7);
            this.panelCreateTicket.Controls.Add(this.label8);
            this.panelCreateTicket.Controls.Add(this.btnCancelCreateTicket);
            this.panelCreateTicket.Controls.Add(this.btnSubmitTicket);
            this.panelCreateTicket.Controls.Add(this.label9);
            this.panelCreateTicket.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCreateTicket.Name = "panelCreateTicket";
            this.panelCreateTicket.Size = new System.Drawing.Size(1056, 510);
            this.panelCreateTicket.TabIndex = 12;
            this.panelCreateTicket.Visible = false;
            // 
            // lblErroroCreateTicket
            // 
            this.lblErroroCreateTicket.ForeColor = System.Drawing.Color.Red;
            this.lblErroroCreateTicket.Location = new System.Drawing.Point(125, 425);
            this.lblErroroCreateTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErroroCreateTicket.Name = "lblErroroCreateTicket";
            this.lblErroroCreateTicket.Size = new System.Drawing.Size(71, 31);
            this.lblErroroCreateTicket.TabIndex = 26;
            // 
            // lblErrorCreateTicket
            // 
            this.lblErrorCreateTicket.AutoSize = true;
            this.lblErrorCreateTicket.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCreateTicket.Location = new System.Drawing.Point(196, 425);
            this.lblErrorCreateTicket.Name = "lblErrorCreateTicket";
            this.lblErrorCreateTicket.Size = new System.Drawing.Size(0, 25);
            this.lblErrorCreateTicket.TabIndex = 25;
            // 
            // cmbPriorityIncident
            // 
            this.cmbPriorityIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPriorityIncident.FormattingEnabled = true;
            this.cmbPriorityIncident.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.cmbPriorityIncident.Location = new System.Drawing.Point(300, 276);
            this.cmbPriorityIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPriorityIncident.Name = "cmbPriorityIncident";
            this.cmbPriorityIncident.Size = new System.Drawing.Size(316, 28);
            this.cmbPriorityIncident.TabIndex = 24;
            // 
            // txtDescriptionIncident
            // 
            this.txtDescriptionIncident.Location = new System.Drawing.Point(715, 146);
            this.txtDescriptionIncident.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescriptionIncident.Name = "txtDescriptionIncident";
            this.txtDescriptionIncident.Size = new System.Drawing.Size(289, 212);
            this.txtDescriptionIncident.TabIndex = 23;
            this.txtDescriptionIncident.Text = "";
            // 
            // cmbDeadlineIncident
            // 
            this.cmbDeadlineIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeadlineIncident.FormattingEnabled = true;
            this.cmbDeadlineIncident.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.cmbDeadlineIncident.Location = new System.Drawing.Point(300, 314);
            this.cmbDeadlineIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDeadlineIncident.Name = "cmbDeadlineIncident";
            this.cmbDeadlineIncident.Size = new System.Drawing.Size(316, 28);
            this.cmbDeadlineIncident.TabIndex = 22;
            // 
            // cmbTypeIncident
            // 
            this.cmbTypeIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeIncident.FormattingEnabled = true;
            this.cmbTypeIncident.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.cmbTypeIncident.Location = new System.Drawing.Point(300, 194);
            this.cmbTypeIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTypeIncident.Name = "cmbTypeIncident";
            this.cmbTypeIncident.Size = new System.Drawing.Size(316, 28);
            this.cmbTypeIncident.TabIndex = 21;
            // 
            // txtUserNameIncident
            // 
            this.txtUserNameIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameIncident.Location = new System.Drawing.Point(300, 236);
            this.txtUserNameIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNameIncident.Name = "txtUserNameIncident";
            this.txtUserNameIncident.Size = new System.Drawing.Size(316, 26);
            this.txtUserNameIncident.TabIndex = 18;
            // 
            // txtSubjectIncident
            // 
            this.txtSubjectIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectIncident.Location = new System.Drawing.Point(300, 151);
            this.txtSubjectIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubjectIncident.Name = "txtSubjectIncident";
            this.txtSubjectIncident.Size = new System.Drawing.Size(316, 26);
            this.txtSubjectIncident.TabIndex = 17;
            // 
            // txtDateReported
            // 
            this.txtDateReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateReported.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDateReported.Location = new System.Drawing.Point(300, 116);
            this.txtDateReported.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDateReported.Name = "txtDateReported";
            this.txtDateReported.Size = new System.Drawing.Size(316, 26);
            this.txtDateReported.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Deadline/follow up:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Priority:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reported by user:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type of incident:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subject of incident:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date/time reported:";
            // 
            // btnCancelCreateTicket
            // 
            this.btnCancelCreateTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCreateTicket.Location = new System.Drawing.Point(560, 418);
            this.btnCancelCreateTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelCreateTicket.Name = "btnCancelCreateTicket";
            this.btnCancelCreateTicket.Size = new System.Drawing.Size(124, 39);
            this.btnCancelCreateTicket.TabIndex = 8;
            this.btnCancelCreateTicket.Text = "CANCEL";
            this.btnCancelCreateTicket.UseVisualStyleBackColor = false;
            this.btnCancelCreateTicket.Click += new System.EventHandler(this.btnCancelCreateTicket_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmitTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTicket.Location = new System.Drawing.Point(692, 418);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(131, 39);
            this.btnSubmitTicket.TabIndex = 7;
            this.btnSubmitTicket.Text = "SUBMIT TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 39);
            this.label9.TabIndex = 5;
            this.label9.Text = "Create new ticket";
            // 
            // tabPageUserManagement
            // 
            this.tabPageUserManagement.Controls.Add(this.panelUserManagement);
            this.tabPageUserManagement.Controls.Add(this.panelAddUser);
            this.tabPageUserManagement.Location = new System.Drawing.Point(4, 34);
            this.tabPageUserManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUserManagement.Name = "tabPageUserManagement";
            this.tabPageUserManagement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUserManagement.Size = new System.Drawing.Size(1059, 512);
            this.tabPageUserManagement.TabIndex = 2;
            this.tabPageUserManagement.Text = "User Management";
            this.tabPageUserManagement.UseVisualStyleBackColor = true;
            this.tabPageUserManagement.Click += new System.EventHandler(this.tabPageUserManagement_Click);
            // 
            // panelUserManagement
            // 
            this.panelUserManagement.Controls.Add(this.btnAdd);
            this.panelUserManagement.Controls.Add(this.lblUserManagement);
            this.panelUserManagement.Controls.Add(this.textBoxFilterByEmail);
            this.panelUserManagement.Controls.Add(this.listViewUsers);
            this.panelUserManagement.Location = new System.Drawing.Point(0, 0);
            this.panelUserManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(1589, 798);
            this.panelUserManagement.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(892, 86);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add User";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUserManagement
            // 
            this.lblUserManagement.AutoSize = true;
            this.lblUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManagement.Location = new System.Drawing.Point(61, 32);
            this.lblUserManagement.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserManagement.Name = "lblUserManagement";
            this.lblUserManagement.Size = new System.Drawing.Size(311, 39);
            this.lblUserManagement.TabIndex = 4;
            this.lblUserManagement.Text = "User management";
            // 
            // textBoxFilterByEmail
            // 
            this.textBoxFilterByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterByEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterByEmail.Location = new System.Drawing.Point(61, 96);
            this.textBoxFilterByEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxFilterByEmail.Name = "textBoxFilterByEmail";
            this.textBoxFilterByEmail.Size = new System.Drawing.Size(284, 29);
            this.textBoxFilterByEmail.TabIndex = 7;
            this.textBoxFilterByEmail.Text = "Filter by email";
            this.textBoxFilterByEmail.Click += new System.EventHandler(this.textBoxFilterByEmail_Click);
            this.textBoxFilterByEmail.TextChanged += new System.EventHandler(this.textBoxFilterByEmail_TextChanged);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(61, 151);
            this.listViewUsers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(983, 347);
            this.listViewUsers.TabIndex = 5;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "First Name";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Last Name";
            this.columnHeader9.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "# tickets";
            this.columnHeader10.Width = 80;
            // 
            // panelAddUser
            // 
            this.panelAddUser.Controls.Add(this.comboLocation);
            this.panelAddUser.Controls.Add(this.comboType);
            this.panelAddUser.Controls.Add(this.txtPhoneNumber);
            this.panelAddUser.Controls.Add(this.txtEmail);
            this.panelAddUser.Controls.Add(this.txtLastName);
            this.panelAddUser.Controls.Add(this.txtFirstName);
            this.panelAddUser.Controls.Add(this.lblLocation);
            this.panelAddUser.Controls.Add(this.lblPhoneNumber);
            this.panelAddUser.Controls.Add(this.lblEmail);
            this.panelAddUser.Controls.Add(this.lblType);
            this.panelAddUser.Controls.Add(this.lblLastName);
            this.panelAddUser.Controls.Add(this.lblFirstName);
            this.panelAddUser.Controls.Add(this.btnCancel);
            this.panelAddUser.Controls.Add(this.btnAddUser);
            this.panelAddUser.Controls.Add(this.lblAddUser);
            this.panelAddUser.Location = new System.Drawing.Point(0, 0);
            this.panelAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAddUser.Name = "panelAddUser";
            this.panelAddUser.Size = new System.Drawing.Size(1060, 519);
            this.panelAddUser.TabIndex = 8;
            this.panelAddUser.Visible = false;
            // 
            // comboLocation
            // 
            this.comboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocation.FormattingEnabled = true;
            this.comboLocation.Items.AddRange(new object[] {
            "Haarlem",
            "Amterdam",
            "Utrecht"});
            this.comboLocation.Location = new System.Drawing.Point(300, 314);
            this.comboLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboLocation.Name = "comboLocation";
            this.comboLocation.Size = new System.Drawing.Size(316, 28);
            this.comboLocation.TabIndex = 22;
            // 
            // comboType
            // 
            this.comboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "Employee",
            "Service Desk Employee"});
            this.comboType.Location = new System.Drawing.Point(300, 194);
            this.comboType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(316, 28);
            this.comboType.TabIndex = 21;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(300, 276);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(316, 26);
            this.txtPhoneNumber.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(300, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(316, 26);
            this.txtEmail.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(300, 151);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(316, 26);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirstName.Location = new System.Drawing.Point(300, 116);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(316, 26);
            this.txtFirstName.TabIndex = 16;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(61, 320);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(134, 20);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location/branch:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(61, 279);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(122, 20);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(61, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(127, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "E-mail address:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(61, 199);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(107, 20);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type of user:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(61, 160);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 20);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(61, 121);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 20);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(300, 394);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 39);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(491, 394);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(124, 39);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "ADD USER";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(61, 32);
            this.lblAddUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(281, 39);
            this.lblAddUser.TabIndex = 5;
            this.lblAddUser.Text = "Create new user";
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Controls.Add(this.lblUnresolved2);
            this.tabPageDashboard.Controls.Add(this.lblUnresolved1);
            this.tabPageDashboard.Controls.Add(this.lblPast2);
            this.tabPageDashboard.Controls.Add(this.lblPast1);
            this.tabPageDashboard.Controls.Add(this.pbUnresolved);
            this.tabPageDashboard.Controls.Add(this.pbPast);
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 34);
            this.tabPageDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageDashboard.Size = new System.Drawing.Size(1059, 512);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // pbPast
            // 
            this.pbPast.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbPast.AnimationSpeed = 500;
            this.pbPast.BackColor = System.Drawing.Color.Transparent;
            this.pbPast.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbPast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbPast.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbPast.InnerMargin = 2;
            this.pbPast.InnerWidth = -1;
            this.pbPast.Location = new System.Drawing.Point(627, 161);
            this.pbPast.MarqueeAnimationSpeed = 2000;
            this.pbPast.Name = "pbPast";
            this.pbPast.OuterColor = System.Drawing.Color.Gray;
            this.pbPast.OuterMargin = -25;
            this.pbPast.OuterWidth = 26;
            this.pbPast.ProgressColor = System.Drawing.Color.Red;
            this.pbPast.ProgressWidth = 25;
            this.pbPast.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbPast.Size = new System.Drawing.Size(320, 320);
            this.pbPast.StartAngle = 270;
            this.pbPast.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbPast.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbPast.SubscriptText = "";
            this.pbPast.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbPast.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbPast.SuperscriptText = "";
            this.pbPast.TabIndex = 0;
            this.pbPast.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbPast.Value = 68;
            // 
            // pbUnresolved
            // 
            this.pbUnresolved.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pbUnresolved.AnimationSpeed = 500;
            this.pbUnresolved.BackColor = System.Drawing.Color.Transparent;
            this.pbUnresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.pbUnresolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbUnresolved.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbUnresolved.InnerMargin = 2;
            this.pbUnresolved.InnerWidth = -1;
            this.pbUnresolved.Location = new System.Drawing.Point(83, 161);
            this.pbUnresolved.MarqueeAnimationSpeed = 2000;
            this.pbUnresolved.Name = "pbUnresolved";
            this.pbUnresolved.OuterColor = System.Drawing.Color.Gray;
            this.pbUnresolved.OuterMargin = -25;
            this.pbUnresolved.OuterWidth = 26;
            this.pbUnresolved.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbUnresolved.ProgressWidth = 25;
            this.pbUnresolved.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pbUnresolved.Size = new System.Drawing.Size(320, 320);
            this.pbUnresolved.StartAngle = 270;
            this.pbUnresolved.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbUnresolved.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pbUnresolved.SubscriptText = ".";
            this.pbUnresolved.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pbUnresolved.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pbUnresolved.SuperscriptText = "";
            this.pbUnresolved.TabIndex = 1;
            this.pbUnresolved.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pbUnresolved.Value = 68;
            // 
            // lblPast1
            // 
            this.lblPast1.AutoSize = true;
            this.lblPast1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPast1.Location = new System.Drawing.Point(639, 37);
            this.lblPast1.Name = "lblPast1";
            this.lblPast1.Size = new System.Drawing.Size(343, 36);
            this.lblPast1.TabIndex = 2;
            this.lblPast1.Text = "Incidents past deadline";
            // 
            // lblPast2
            // 
            this.lblPast2.AutoSize = true;
            this.lblPast2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPast2.Location = new System.Drawing.Point(614, 100);
            this.lblPast2.Name = "lblPast2";
            this.lblPast2.Size = new System.Drawing.Size(378, 24);
            this.lblPast2.TabIndex = 3;
            this.lblPast2.Text = "These tickets need your immediate attention";
            // 
            // lblUnresolved1
            // 
            this.lblUnresolved1.AutoSize = true;
            this.lblUnresolved1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolved1.Location = new System.Drawing.Point(89, 37);
            this.lblUnresolved1.Name = "lblUnresolved1";
            this.lblUnresolved1.Size = new System.Drawing.Size(314, 36);
            this.lblUnresolved1.TabIndex = 4;
            this.lblUnresolved1.Text = "Unresolved incidents";
            // 
            // lblUnresolved2
            // 
            this.lblUnresolved2.AutoSize = true;
            this.lblUnresolved2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolved2.Location = new System.Drawing.Point(132, 100);
            this.lblUnresolved2.Name = "lblUnresolved2";
            this.lblUnresolved2.Size = new System.Drawing.Size(213, 24);
            this.lblUnresolved2.TabIndex = 5;
            this.lblUnresolved2.Text = "All tickets currently open";
            // 
            // ServiceDeskEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ServiceDeskEmployeeForm";
            this.Text = "ServiceDeskEmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageIncidentManagement.ResumeLayout(false);
            this.panelTicketsOverview.ResumeLayout(false);
            this.panelTicketsOverview.PerformLayout();
            this.panelCreateTicket.ResumeLayout(false);
            this.panelCreateTicket.PerformLayout();
            this.tabPageUserManagement.ResumeLayout(false);
            this.panelUserManagement.ResumeLayout(false);
            this.panelUserManagement.PerformLayout();
            this.panelAddUser.ResumeLayout(false);
            this.panelAddUser.PerformLayout();
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageIncidentManagement;
        private System.Windows.Forms.TabPage tabPageUserManagement;
        private System.Windows.Forms.TextBox textBoxFilterByEmail;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label lblUserManagement;
        private System.Windows.Forms.Panel panelUserManagement;
        private System.Windows.Forms.Panel panelAddUser;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox comboLocation;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Panel panelTicketsOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.TextBox textBoxFilterBySubject;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panelCreateTicket;
        private System.Windows.Forms.ComboBox cmbDeadlineIncident;
        private System.Windows.Forms.ComboBox cmbTypeIncident;
        private System.Windows.Forms.TextBox txtUserNameIncident;
        private System.Windows.Forms.TextBox txtSubjectIncident;
        private System.Windows.Forms.TextBox txtDateReported;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelCreateTicket;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtDescriptionIncident;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnHigh;

        private System.Windows.Forms.ComboBox cmbPriorityIncident;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblErrorCreateTicket;
        private System.Windows.Forms.Label lblErroroCreateTicket;
        private System.Windows.Forms.Label lblUnresolved2;
        private System.Windows.Forms.Label lblUnresolved1;
        private System.Windows.Forms.Label lblPast2;
        private System.Windows.Forms.Label lblPast1;
        private CircularProgressBar.CircularProgressBar pbUnresolved;
        private CircularProgressBar.CircularProgressBar pbPast;
    }
}