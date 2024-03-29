﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;
using System.IO;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace DemoApp
{
    public partial class ServiceDeskEmployeeForm : Form
    {
        List<Incident> incidents;
        UserService userService = new UserService();
        IncidentService incidentService = new IncidentService();
        List<TextBox> textBoxes = new List<TextBox>();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        List<RadioButton> radioButtons = new List<RadioButton>();
        SortByPriority sortByPriority = new SortByPriority();
        TransferTicket transferTicket = new TransferTicket();
        public ServiceDeskEmployeeForm()
        {
            InitializeComponent();
            loadIncidents(string.Empty);
            loadUsers(string.Empty);
            textBoxes.Add(txtFirstName);
            textBoxes.Add(txtLastName);
            textBoxes.Add(txtEmail);
            textBoxes.Add(txtPhoneNumber);

            comboBoxes.Add(comboType);
            comboBoxes.Add(comboLocation);

            radioButtons.Add(radioButtonOpen);
            radioButtons.Add(radioButtonIncident);
            radioButtons.Add(radioButtonClosed);
            radioButtons.Add(radioButtonResolved);
            radioButtons.Add(radioButtonNoFilter);

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Click += new EventHandler(textBox_Click);
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Click += new EventHandler(comboBox_Click);
            }
            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.CheckedChanged += RadioButton_CheckedChanged;
            }
            
            // load unresolved incidents
            LoadPBUnresolved(pbUnresolved, Status.open);
            // load incidents past deadline
            LoadPBPastDeadline(pbPast, DateTime.Now);
        }

        Status? status = null;
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "radioButtonOpen":
                    status = Status.open;
                    break;
                case "radioButtonIncident":
                    status = Status.incident;
                    break;
                case "radioButtonClosed":
                    status = Status.closed;
                    break;
                case "radioButtonResolved":
                    status = Status.resolved;
                    break;
                case "radioButtonNoFilter":
                    status = null;
                    break;
            }
            FilteringList filteringList = new FilteringList();
            incidents = incidentService.GetAllIncidents();
            if (status != null)
                incidents = filteringList.FilterIncidentByStatus(incidents, status);
            loadIncidents(string.Empty);
        }

        private void loadUsers(string str)
        {
            try
            {
                List<User> users = userService.GetAllUsers();
                listViewUsers.Items.Clear();

                foreach (User user in users)
                {
                    ListViewItem item = new ListViewItem(user.Id.ToString());
                    item.SubItems.Add(user.Email);
                    item.SubItems.Add(user.FirstName);
                    item.SubItems.Add(user.LastName);
                    item.SubItems.Add(user.GetNumberOfIncidetsByUser(incidents).ToString());

                    if (user.Email.ToLower().Contains(str.ToLower()))
                        listViewUsers.Items.Add(item);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void textBoxFilterByEmail_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFilterByEmail.Text = string.Empty;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void textBoxFilterBySubject_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFilterBySubject.Text = string.Empty;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loadUsers(textBoxFilterByEmail.Text);
            }
        }

        private void tabPageUserManagement_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxFilterByEmail.Text = "Filter by email";
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelUserManagement.Visible = true;
            panelAddUser.Visible = false;

            clearBoxes();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!validateTextBoxes(textBoxes) || !validateComboBoxes(comboBoxes))
            {
                fillEmptyTextBoxes();
                fillEmptyComboBoxes();

                if (!validateEmail(txtEmail.Text))
                {
                    txtEmail.ForeColor = Color.Red;
                    txtEmail.Text = "Invalid input...";
                }
                if (!validatePhoneNumber(txtPhoneNumber.Text))
                {
                    txtPhoneNumber.ForeColor = Color.Red;
                    txtPhoneNumber.Text = "Invalid input...";
                }
            }
            else
            {    
                User user = new User(txtFirstName.Text, txtLastName.Text, comboLocation.Text, txtPhoneNumber.Text, txtEmail.Text, hashPassword(), comboType.Text);
                UserService userService = new UserService();
                userService.AddUser(user);
                clearBoxes();
                panelUserManagement.Visible = true;
                panelAddUser.Visible = false;
                loadUsers("");
            }
        }

        public string hashPassword()
        {
            Random rand = new Random();
            int passwordLength = rand.Next(6, 12);
            int randValue;
            string password = "";
            char letter;
            for (int i = 0; i < passwordLength; i++)
            {
                randValue = rand.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                password += letter;
            }
            MessageBox.Show("Password generated:" + password);
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return Convert.ToBase64String(hashBytes);
        }

        private void fillEmptyTextBoxes()
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == string.Empty)
                {
                    textBox.ForeColor = Color.Red;
                    textBox.Text = "Invalid input...";
                }
            }
        }

        private void fillEmptyComboBoxes()
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Text == string.Empty)
                {
                    comboBox.ForeColor = Color.Red;
                    comboBox.Text = "Invalid input...";
                }
            }
        }

        private bool validateTextBoxes(List<TextBox> textBoxes)
        {
            int count = 0;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == string.Empty || textBox.Text == "Invalid input...")
                    count++;
            }
            if (count == 0)
                return true;
            return false;
        }

        private bool validateComboBoxes(List<ComboBox> comboBoxes)
        {
            int count = 0;

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Text == string.Empty || comboBox.Text == "Invalid input...")
                    count++;
            }
            if (count == 0)
                return true;
            return false;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "Invalid input...")
                tb.Text = string.Empty;
            tb.ForeColor = Color.Black;
        }

        private void comboBox_Click(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.Text == "Invalid input...")
                cb.Text = string.Empty;
            cb.ForeColor = Color.Black;
        }

        private bool validateEmail(string email)
        {
            if (email.Contains("@gmail.com"))
                return true;
            return false;
        }
        private bool validatePhoneNumber(string number)
        {
            int count = 0;
            if (number.Length == 10)
            {
                foreach (char c in number)
                {
                    if (c <= '9' && c >= '0')
                        count++;
                }
            }
            if (count == number.Length)
                return true;
            return false;
        }

        private void clearBoxes()
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = String.Empty;
            }
            foreach (ComboBox comboBox in comboBoxes)
            {

                comboBox.ForeColor = Color.Black;
                comboBox.Text = String.Empty; ;
            }
        }

        private void loadIncidents(string str)
        {
            try
            {
                if(incidents == null)
                    incidents = incidentService.GetAllIncidents();
                fillListViewIncident(str);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnCancelCreateTicket_Click(object sender, EventArgs e)
        {
            try
            {
                panelCreateTicket.Visible = false;
                panelTicketsOverview.Visible = true;
                lblErrorCreateTicket.Text = "";
                checkBoxTransfer.Checked = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            Incident ticket = (Incident)listViewTickets.SelectedItems[0].Tag;
            if (cmbDeadlineIncident.Text.Length == 0 || cmbPriorityIncident.Text.Length == 0 || cmbTypeIncident.Text.Length == 0)
            {
                lblErrorCreateTicket.Text = "please fill in the required information!";
                return;
            }



            ticket.Date = Convert.ToDateTime(txtDateReported.Text);



            if (cmbDeadlineIncident.SelectedItem.ToString() == "6 months")
                ticket.Deadline = ticket.Date.AddMonths(6);
            else
            {
                string[] splitCmbString = cmbDeadlineIncident.SelectedItem.ToString().Split(' ');
                ticket.Deadline = ticket.Date.AddDays(int.Parse(splitCmbString[0]));
            }
            ticket.Type = (TicketType)cmbTypeIncident.SelectedIndex;
            ticket.Priority = (Priority)cmbPriorityIncident.SelectedIndex;
            ticket.Subject = txtSubjectIncident.Text;
            ticket.Description = txtDescriptionIncident.Text;
            if (label9.Text.Equals("Edit Ticket"))
            {
                if(checkBoxTransfer.Checked == true)
                {
                    // transfer ticket
                    string[] reporter = checkedListBoxTransfer.CheckedItems[0].ToString().Split(':');
                    ticket.Reporter = reporter[1];
                }
                // edit ticket
                incidentService.EditTicket(ticket);
            }
            else if (label9.Text.Equals("Create new ticket"))
            {
                ticket.Status = Status.open;
                incidentService.CreateTicket(ticket);
            }
            txtUserNameIncident.Enabled = true;
            panelTicketsOverview.Visible = true;
            panelCreateTicket.Visible = false;
            lblErrorCreateTicket.Text = "";
            loadIncidents(string.Empty);
            // load unresolved incidents
            LoadPBUnresolved(pbUnresolved, Status.open);
            // load incidents past deadline
            LoadPBPastDeadline(pbPast, DateTime.Now);
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listViewTickets.SelectedItems)
                    {
                        incidentService.DeleteTicket((Incident)item.Tag);
                    }
                }
                loadIncidents(string.Empty);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            checkBoxTransfer.Visible = false;
            checkedListBoxTransfer.Visible = false;
            label13.Visible = false;
            if (listViewTickets.SelectedItems.Count == 1)
            {
                Incident selcetedIncident = (Incident)listViewTickets.SelectedItems[0].Tag;
                if (selcetedIncident.Status == Status.incident)
                {
                    label9.Text = "Create new ticket";
                    User user = userService.GetUserById(selcetedIncident.Reporter);
                    panelTicketsOverview.Visible = false;
                    panelCreateTicket.Visible = true;
                    selcetedIncident = (Incident)listViewTickets.SelectedItems[0].Tag;
                    txtUserNameIncident.Text = user.FirstName;
                    txtDateReported.Text = selcetedIncident.Date.ToString("yyyy MM dd");
                    txtSubjectIncident.Text = selcetedIncident.Subject;
                    txtDescriptionIncident.Text = selcetedIncident.Description;
                }
            }
        }

        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            updateStatus(Status.closed);
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            updateStatus(Status.resolved);
            // load unresolved incidents
            LoadPBUnresolved(pbUnresolved, Status.open);
            // load incidents past deadline
            LoadPBPastDeadline(pbPast, DateTime.Now);
        }

        private void updateStatus(Status status)
        {
            List<Incident> tickets = new List<Incident>();
            if (listViewTickets.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewTickets.SelectedItems)
                {
                    if (((Incident)item.Tag).Status == Status.open)
                    {
                        incidentService.UpdateStatus(((Incident)item.Tag), status);
                    }
                    else 
                    {
                        tickets.Add((Incident)item.Tag);
                    }
                }
                string message = "";
                foreach (Incident item in tickets)
                {
                    if (item.Status == status)
                    {
                        message += $"ticket Id {item.Id} is already {status}\n\n";
                    }
                    else if (item.Status == Status.incident)
                    {
                        message += $"incident Id {item.Id} is an incident, only tickets can be {status}\n\n";
                    }
                    else
                    {
                        if (status == Status.closed)
                        {
                            message += $"ticket Id {item.Id} is already {status}, tickets that is already resolve cannot be {status}\n\n";
                        }
                        else
                            message += $"ticket Id {item.Id} is already {status}, tickets that is already closed cannot be {status}\n\n";
                    }
                }

                if (tickets.Count != 0)
                {
                    MessageBox.Show(message);
                }
            }
            loadIncidents(string.Empty);
        }


        private void fillListViewIncident(string str)
        {
            listViewTickets.Items.Clear();
            foreach (Incident incident in incidents)
            {
                User user = userService.GetUserById(incident.Reporter);

                ListViewItem item = new ListViewItem(incident.Id.ToString());
                item.SubItems.Add(incident.Date.ToString("dd MMMM yyyy"));
                item.SubItems.Add(incident.Subject);
                item.SubItems.Add(incident.Type.ToString());
                item.SubItems.Add(user.FirstName + " " + user.LastName);
                item.SubItems.Add(incident.Deadline.ToString("dd MMMM yyyy"));
                item.SubItems.Add(incident.Description);
                item.SubItems.Add(incident.Status.ToString());
                item.SubItems.Add(incident.Priority.ToString());
                item.Tag = incident;
                if (incident.Subject.ToLower().Contains(str.ToLower()))
                    listViewTickets.Items.Add(item);

            }
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            incidents = sortByPriority.SortByHigh(incidents);
            fillListViewIncident(string.Empty);
        }
        private void btnLow_Click(object sender, EventArgs e)
        {
            incidents = sortByPriority.SortByLow(incidents);
            fillListViewIncident(string.Empty);
        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            FillListTransfer();
            checkBoxTransfer.Visible = true;
            label13.Visible = true;
            checkedListBoxTransfer.Visible = false;
            if (listViewTickets.SelectedItems.Count == 1)
            {
                Incident selectedTicket = (Incident)listViewTickets.SelectedItems[0].Tag;
                if(selectedTicket.Status != Status.incident)
                {
                    panelTicketsOverview.Visible = false;
                    panelCreateTicket.Visible = true;
                    label9.Text = "Edit Ticket";

                    TimeSpan timeSpan = selectedTicket.Deadline - selectedTicket.Date;
                    if (timeSpan.Days >= 5 && timeSpan.Days <= 9)
                        cmbDeadlineIncident.SelectedItem = "7 days";
                    else if (timeSpan.Days >= 12 && timeSpan.Days <= 16)
                        cmbDeadlineIncident.SelectedItem = "14 days";
                    else if (timeSpan.Days >= 26 && timeSpan.Days <= 30)
                        cmbDeadlineIncident.SelectedItem = "28 days";
                    else if (timeSpan.Days >= 150 && timeSpan.Days <= 200)
                        cmbDeadlineIncident.SelectedItem = "6 month";

                    cmbTypeIncident.SelectedItem = selectedTicket.Type;

                    cmbPriorityIncident.SelectedItem = char.ToUpper(selectedTicket.Priority.ToString()[0]) + selectedTicket.Priority.ToString().Substring(1);

                    User user = userService.GetUserById(selectedTicket.Reporter);
                    txtUserNameIncident.Text = user.FirstName;
                    txtUserNameIncident.Enabled = false;
                    txtDateReported.Text = selectedTicket.Date.ToString("yyyy MM dd");
                    txtSubjectIncident.Text = selectedTicket.Subject;
                    txtDescriptionIncident.Text = selectedTicket.Description;
                }
            }
        }

        //search bar for incidents and users
        private void textBoxFilterBySubject_TextChanged(object sender, EventArgs e)
        {
            loadIncidents(textBoxFilterBySubject.Text.ToLower());
            textBoxFilterBySubject.ForeColor = Color.Black;
        }

        private void textBoxFilterByEmail_TextChanged(object sender, EventArgs e)
        {
            loadUsers(textBoxFilterByEmail.Text.ToLower());
            textBoxFilterByEmail.ForeColor = Color.Black;
        }

        //add button in the User Management interface
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                panelUserManagement.Visible = false;
                panelAddUser.Visible = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        // progress bars for dashboard
        public void LoadPBUnresolved(ProgressBar progressBar, Status status)
        {
            List<Incident> unresolvedIncidents = incidentService.GetTicketsWithStatus(status);
            List<Incident> totalIncidents = incidentService.GetAllIncidents();

            progressBar.Value = unresolvedIncidents.Count;
            progressBar.Maximum = totalIncidents.Count;
            progressBar.Text = $"{unresolvedIncidents.Count.ToString()}/{totalIncidents.Count.ToString()}";
            
        }
        public void LoadPBPastDeadline(ProgressBar progressBar, DateTime dateTime)
        {
            List<Incident> pastDeadlineIncidents = incidentService.GetTicketsPastDeadline(dateTime);
            List<Incident> totalIncidents = incidentService.GetAllIncidents();

            progressBar.Value = pastDeadlineIncidents.Count;
            progressBar.Maximum = totalIncidents.Count;
            progressBar.Text = $"{pastDeadlineIncidents.Count.ToString()}/{totalIncidents.Count.ToString()}";
        }
        // transfer ticket 
        public void FillListTransfer()
        {
            List<User> users = userService.GetAllUsers();
            foreach(User user in users)
            {
                checkedListBoxTransfer.Items.Add($"{user.FirstName} {user.LastName} Id:{user.Id}");
            }
        }

        private void checkBoxTransfer_CheckedChanged(object sender, EventArgs e)
        {
            transferTicket.DisplayUsers(checkBoxTransfer, checkedListBoxTransfer);
        }
    }
}