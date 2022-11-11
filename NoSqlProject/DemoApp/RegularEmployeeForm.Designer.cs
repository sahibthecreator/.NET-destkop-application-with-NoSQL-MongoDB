namespace DemoApp
{
    partial class RegularEmployeeForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblReported = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblCreatNewIncident = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblClosedTicketsText = new System.Windows.Forms.Label();
            this.lblOpenTicketsText = new System.Windows.Forms.Label();
            this.cpbClosedTickets = new CircularProgressBar.CircularProgressBar();
            this.cpbOpenTickets = new CircularProgressBar.CircularProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewMyTickets = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTicketsHead = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-4, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Controls.Add(this.lblReported);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.lblDescription);
            this.tabPage1.Controls.Add(this.lblSubject);
            this.tabPage1.Controls.Add(this.lblCreatNewIncident);
            this.tabPage1.Controls.Add(this.txtSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1051, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Report Incident";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.LightGray;
            this.txtDescription.Location = new System.Drawing.Point(387, 210);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 190);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Text = "Briefly explain  the problem you\'re facing...";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblUser.Location = new System.Drawing.Point(380, 105);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 36);
            this.lblUser.TabIndex = 13;
            // 
            // lblReported
            // 
            this.lblReported.AutoSize = true;
            this.lblReported.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReported.Location = new System.Drawing.Point(163, 116);
            this.lblReported.Name = "lblReported";
            this.lblReported.Size = new System.Drawing.Size(166, 25);
            this.lblReported.TabIndex = 12;
            this.lblReported.Text = "Reported by user:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSubmit.FlatAppearance.BorderSize = 4;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(771, 196);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 50);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.BorderSize = 4;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(771, 132);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(163, 210);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(115, 25);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(163, 165);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(177, 25);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject of incident:";
            // 
            // lblCreatNewIncident
            // 
            this.lblCreatNewIncident.AutoSize = true;
            this.lblCreatNewIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatNewIncident.Location = new System.Drawing.Point(160, 37);
            this.lblCreatNewIncident.Name = "lblCreatNewIncident";
            this.lblCreatNewIncident.Size = new System.Drawing.Size(391, 38);
            this.lblCreatNewIncident.TabIndex = 4;
            this.lblCreatNewIncident.Text = "Create new incident ticket";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(387, 162);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(292, 27);
            this.txtSubject.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblClosedTicketsText);
            this.tabPage2.Controls.Add(this.lblOpenTicketsText);
            this.tabPage2.Controls.Add(this.cpbClosedTickets);
            this.tabPage2.Controls.Add(this.cpbOpenTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1051, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dashbord";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblClosedTicketsText
            // 
            this.lblClosedTicketsText.AutoSize = true;
            this.lblClosedTicketsText.Location = new System.Drawing.Point(700, 39);
            this.lblClosedTicketsText.Name = "lblClosedTicketsText";
            this.lblClosedTicketsText.Size = new System.Drawing.Size(142, 25);
            this.lblClosedTicketsText.TabIndex = 2;
            this.lblClosedTicketsText.Text = "Closed Tickets";
            // 
            // lblOpenTicketsText
            // 
            this.lblOpenTicketsText.AutoSize = true;
            this.lblOpenTicketsText.Location = new System.Drawing.Point(209, 39);
            this.lblOpenTicketsText.Name = "lblOpenTicketsText";
            this.lblOpenTicketsText.Size = new System.Drawing.Size(129, 25);
            this.lblOpenTicketsText.TabIndex = 1;
            this.lblOpenTicketsText.Text = "Open Tickets";
            // 
            // cpbClosedTickets
            // 
            this.cpbClosedTickets.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbClosedTickets.AnimationSpeed = 500;
            this.cpbClosedTickets.BackColor = System.Drawing.Color.Transparent;
            this.cpbClosedTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbClosedTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbClosedTickets.InnerColor = System.Drawing.Color.White;
            this.cpbClosedTickets.InnerMargin = 2;
            this.cpbClosedTickets.InnerWidth = -1;
            this.cpbClosedTickets.Location = new System.Drawing.Point(635, 90);
            this.cpbClosedTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpbClosedTickets.MarqueeAnimationSpeed = 2000;
            this.cpbClosedTickets.Name = "cpbClosedTickets";
            this.cpbClosedTickets.OuterColor = System.Drawing.Color.Gray;
            this.cpbClosedTickets.OuterMargin = -25;
            this.cpbClosedTickets.OuterWidth = 26;
            this.cpbClosedTickets.ProgressColor = System.Drawing.Color.Red;
            this.cpbClosedTickets.ProgressWidth = 25;
            this.cpbClosedTickets.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbClosedTickets.Size = new System.Drawing.Size(280, 277);
            this.cpbClosedTickets.StartAngle = 270;
            this.cpbClosedTickets.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbClosedTickets.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbClosedTickets.SubscriptText = "";
            this.cpbClosedTickets.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbClosedTickets.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbClosedTickets.SuperscriptText = "";
            this.cpbClosedTickets.TabIndex = 0;
            this.cpbClosedTickets.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbClosedTickets.Value = 68;
            // 
            // cpbOpenTickets
            // 
            this.cpbOpenTickets.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbOpenTickets.AnimationSpeed = 500;
            this.cpbOpenTickets.BackColor = System.Drawing.Color.Transparent;
            this.cpbOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cpbOpenTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbOpenTickets.InnerColor = System.Drawing.Color.White;
            this.cpbOpenTickets.InnerMargin = 2;
            this.cpbOpenTickets.InnerWidth = -1;
            this.cpbOpenTickets.Location = new System.Drawing.Point(135, 90);
            this.cpbOpenTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpbOpenTickets.MarqueeAnimationSpeed = 2000;
            this.cpbOpenTickets.Name = "cpbOpenTickets";
            this.cpbOpenTickets.OuterColor = System.Drawing.Color.Gray;
            this.cpbOpenTickets.OuterMargin = -25;
            this.cpbOpenTickets.OuterWidth = 26;
            this.cpbOpenTickets.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbOpenTickets.ProgressWidth = 25;
            this.cpbOpenTickets.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbOpenTickets.Size = new System.Drawing.Size(280, 277);
            this.cpbOpenTickets.StartAngle = 270;
            this.cpbOpenTickets.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbOpenTickets.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbOpenTickets.SubscriptText = "";
            this.cpbOpenTickets.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbOpenTickets.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbOpenTickets.SuperscriptText = "";
            this.cpbOpenTickets.TabIndex = 0;
            this.cpbOpenTickets.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbOpenTickets.Value = 68;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewMyTickets);
            this.tabPage3.Controls.Add(this.lblTicketsHead);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1051, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My tickets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewMyTickets
            // 
            this.listViewMyTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id});
            this.listViewMyTickets.HideSelection = false;
            this.listViewMyTickets.Location = new System.Drawing.Point(25, 89);
            this.listViewMyTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewMyTickets.Name = "listViewMyTickets";
            this.listViewMyTickets.Size = new System.Drawing.Size(1005, 277);
            this.listViewMyTickets.TabIndex = 1;
            this.listViewMyTickets.UseCompatibleStateImageBehavior = false;
            // 
            // lblTicketsHead
            // 
            this.lblTicketsHead.AutoSize = true;
            this.lblTicketsHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTicketsHead.Location = new System.Drawing.Point(27, 26);
            this.lblTicketsHead.Name = "lblTicketsHead";
            this.lblTicketsHead.Size = new System.Drawing.Size(132, 39);
            this.lblTicketsHead.TabIndex = 0;
            this.lblTicketsHead.Text = "Tickets";
            // 
            // RegularEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegularEmployeeForm";
            this.Text = "RegularEmployee";
            this.Load += new System.EventHandler(this.RegularEmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblCreatNewIncident;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblReported;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtDescription;
        private CircularProgressBar.CircularProgressBar cpbOpenTickets;
        private CircularProgressBar.CircularProgressBar cpbClosedTickets;
        private System.Windows.Forms.Label lblClosedTicketsText;
        private System.Windows.Forms.Label lblOpenTicketsText;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewMyTickets;
        private System.Windows.Forms.Label lblTicketsHead;
        private System.Windows.Forms.ColumnHeader Id;
    }
}