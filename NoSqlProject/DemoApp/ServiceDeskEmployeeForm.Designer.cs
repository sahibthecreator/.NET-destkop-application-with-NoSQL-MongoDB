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
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.tabPageIncidentManagement = new System.Windows.Forms.TabPage();
            this.tabPageUserManagement = new System.Windows.Forms.TabPage();
            this.textBoxFilterByEmail = new System.Windows.Forms.TextBox();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageUserManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDashboard);
            this.tabControl1.Controls.Add(this.tabPageIncidentManagement);
            this.tabControl1.Controls.Add(this.tabPageUserManagement);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 692);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl1_KeyPress);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 38);
            this.tabPageDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageDashboard.Size = new System.Drawing.Size(1192, 650);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabPageIncidentManagement
            // 
            this.tabPageIncidentManagement.Location = new System.Drawing.Point(4, 38);
            this.tabPageIncidentManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageIncidentManagement.Name = "tabPageIncidentManagement";
            this.tabPageIncidentManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageIncidentManagement.Size = new System.Drawing.Size(1192, 650);
            this.tabPageIncidentManagement.TabIndex = 1;
            this.tabPageIncidentManagement.Text = "Incident Management";
            this.tabPageIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // tabPageUserManagement
            // 
            this.tabPageUserManagement.Controls.Add(this.textBoxFilterByEmail);
            this.tabPageUserManagement.Controls.Add(this.buttonAddNewUser);
            this.tabPageUserManagement.Controls.Add(this.listViewUsers);
            this.tabPageUserManagement.Controls.Add(this.label2);
            this.tabPageUserManagement.Location = new System.Drawing.Point(4, 38);
            this.tabPageUserManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUserManagement.Name = "tabPageUserManagement";
            this.tabPageUserManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUserManagement.Size = new System.Drawing.Size(1192, 650);
            this.tabPageUserManagement.TabIndex = 2;
            this.tabPageUserManagement.Text = "User Management";
            this.tabPageUserManagement.UseVisualStyleBackColor = true;
            this.tabPageUserManagement.Click += new System.EventHandler(this.tabPageUserManagement_Click);
            // 
            // textBoxFilterByEmail
            // 
            this.textBoxFilterByEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterByEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFilterByEmail.Location = new System.Drawing.Point(30, 103);
            this.textBoxFilterByEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFilterByEmail.Name = "textBoxFilterByEmail";
            this.textBoxFilterByEmail.Size = new System.Drawing.Size(319, 33);
            this.textBoxFilterByEmail.TabIndex = 7;
            this.textBoxFilterByEmail.Text = "Filter by email";
            this.textBoxFilterByEmail.Click += new System.EventHandler(this.textBoxFilterByEmail_Click);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUser.Location = new System.Drawing.Point(830, 98);
            this.buttonAddNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(164, 51);
            this.buttonAddNewUser.TabIndex = 6;
            this.buttonAddNewUser.Text = "+ ADD NEW USER";
            this.buttonAddNewUser.UseVisualStyleBackColor = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
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
            this.listViewUsers.Location = new System.Drawing.Point(30, 180);
            this.listViewUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(961, 433);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "User management";
            // 
            // ServiceDeskEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceDeskEmployeeForm";
            this.Text = "ServiceDeskEmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageUserManagement.ResumeLayout(false);
            this.tabPageUserManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageIncidentManagement;
        private System.Windows.Forms.TabPage tabPageUserManagement;
        private System.Windows.Forms.TextBox textBoxFilterByEmail;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Label label2;
    }
}