using System;
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

namespace DemoApp
{
    public partial class ServiceDeskEmployeeForm : Form
    {
        List<Incident> incidents;
        UserService userService = new UserService();
        IncidentService incidentService = new IncidentService();
        List<TextBox> textBoxes = new List<TextBox>();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        public ServiceDeskEmployeeForm()
        {
            InitializeComponent();
            loadIncidents();
            loadUsers(string.Empty);
            textBoxes.Add(txtFirstName);
            textBoxes.Add(txtLastName);
            textBoxes.Add(txtEmail);
            textBoxes.Add(txtPhoneNumber);

            comboBoxes.Add(comboType);
            comboBoxes.Add(comboLocation);

            foreach (TextBox textBox in textBoxes)
            {
                textBox.Click += new EventHandler(textBox_Click);
            }

            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Click += new EventHandler(comboBox_Click);
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
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

        private void loadUsers(string str)
        {
            try
            {
                List<User> users = userService.getAllUsers();
                listViewUsers.Items.Clear();

                foreach (User user in users)
                {
                    ListViewItem item = new ListViewItem(user.Id.ToString());
                    item.SubItems.Add(user.Email);
                    item.SubItems.Add(user.FirstName);
                    item.SubItems.Add(user.LastName);

                    if (user.Email.Contains(str))
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
                string savedPasswordHash = Convert.ToBase64String(hashBytes);

                User user = new User(txtFirstName.Text, txtLastName.Text, comboLocation.Text, txtPhoneNumber.Text, txtEmail.Text, savedPasswordHash, comboType.Text);
                UserService userService = new UserService();
                userService.addUser(user);
                clearBoxes();
                panelUserManagement.Visible = true;
                panelAddUser.Visible = false;
                loadUsers("");
            }
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

        private void loadIncidents()
        {
            try
            {
                incidents = incidentService.GetAllIncidents();
                listViewTickets.Items.Clear();

                foreach (Incident incident in incidents)
                {
                    //User user = userService.getUserById(incident.Reporter);

                    ListViewItem item = new ListViewItem(incident.Id.ToString());
                    item.SubItems.Add(incident.Subject);
                    item.SubItems.Add("");
                    item.SubItems.Add(incident.Date.ToString("dd MMMM yyyy"));
                    item.SubItems.Add(incident.Status.ToString());
                    item.Tag = incident;
                    listViewTickets.Items.Add(item);

                }
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
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(txtDateReported.Text);
            string[] splitCmbString = cmbDeadlineIncident.SelectedItem.ToString().Split(' ');

            Incident ticket = (Incident)listViewTickets.SelectedItems[0].Tag;
            if (cmbDeadlineIncident.SelectedItem.ToString() == "6 months")
            {
                ticket.Deadline = date.AddMonths(6);
            }
            else
            {
                ticket.Deadline = date.AddDays(int.Parse(splitCmbString[0]));
            }
            ticket.Type = cmbTypeIncident.Text;
            ticket.Status = Status.open;
            //ticket.Priority=Enum.TryParse( cmbPriorityIncident.Text,out Priority priority);
            incidentService.CreateTicket(ticket);
            panelTicketsOverview.Visible = true;
            panelCreateTicket.Visible = false;
            loadIncidents();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTickets.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem item in listViewTickets.SelectedItems)
                    {
                        incidentService.deleteTicket((Incident)item.Tag);
                    }
                }
                loadIncidents();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            Incident selcetedIncident = (Incident)listViewTickets.SelectedItems[0].Tag;
            if (listViewTickets.SelectedItems.Count == 1 && selcetedIncident.Status == Status.incident)
            {
                panelTicketsOverview.Visible = false;
                panelCreateTicket.Visible = true;
                selcetedIncident = (Incident)listViewTickets.SelectedItems[0].Tag;
                txtUserNameIncident.Text = selcetedIncident.Reporter;
                txtDateReported.Text = selcetedIncident.Date.ToString("yyyy MM dd");
                txtSubjectIncident.Text = selcetedIncident.Subject;
                txtDescriptionIncident.Text = selcetedIncident.Description;
            }
        }

        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            updateStatus(Status.closed);
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            updateStatus(Status.resolved);
        }

        private void updateStatus(Status status)
        {
            List<Incident> tickets = new List<Incident>();
            if (listViewTickets.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewTickets.SelectedItems)
                {
                    if (((Incident)item.Tag).Status == status)
                    {
                        tickets.Add((Incident)item.Tag);
                    }
                    else
                    {
                        incidentService.updateStatus(((Incident)item.Tag), status);
                    }
                }
                string message = "";
                foreach (var item in tickets)
                {
                    message += $"ticket {item.Id} already {status} \n";
                }

                if (tickets.Count != 0)
                {
                    MessageBox.Show(message);
                }
            }
            loadIncidents();
        }

        private void btnFilterByPriority_Click(object sender, EventArgs e)
        {
            //incidents = incidents.OrderBy(i => i.).ToList();
        }
    }
}
