using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Bson;

namespace DemoApp
{
    public partial class RegularEmployeeForm : Form
    {
        IncidentService incidentService= new IncidentService();
        List<TextBox> txtBoxes = new List<TextBox>();
        List<Incident> allTickets;
        // the employee submitting the incident
        User user;
        public RegularEmployeeForm(User user)
        {
            InitializeComponent();
            // pass the data for the user object
            this.user = user;
            txtBoxes.Add(txtSubject);
            txtBoxes.Add(txtDescription);
            lblUser.Text = user.FirstName;

            allTickets = incidentService.GetAllUserTickets(user);

            LoadCPB(cpbOpenTickets, Status.open);
            LoadCPB(cpbClosedTickets, Status.closed);
            //LoadCPB(cpbResolvedTickets,Status.resolved);

            DisplayTickets();
        }

        private void DisplayTickets()
        {
            listViewMyTickets.Clear();
            listViewMyTickets.Columns.Add("Id", 100, HorizontalAlignment.Left);
            listViewMyTickets.Columns.Add("Date", 100, HorizontalAlignment.Left);
            listViewMyTickets.Columns.Add("Subject", 100, HorizontalAlignment.Left);
            listViewMyTickets.Columns.Add("Description", 100, HorizontalAlignment.Left);
            listViewMyTickets.Columns.Add("Type", 100, HorizontalAlignment.Left);
            listViewMyTickets.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listViewMyTickets.Columns.Add("Deadline", 100, HorizontalAlignment.Left);
            listViewMyTickets.View = View.Details;
            foreach (var item in allTickets)
            {
                ListViewItem li = new ListViewItem(item.Id);
                li.SubItems.Add(item.Date.ToString("yyyy/MM/dd"));
                li.SubItems.Add(item.Subject);
                li.SubItems.Add(item.Description);
                li.SubItems.Add(item.Type.ToString());
                li.SubItems.Add(item.Status.ToString());
                li.SubItems.Add(item.Deadline.ToString("yyyy/MM/dd"));
                listViewMyTickets.Items.Add(li);
            }
        }

        private void LoadCPB(ProgressBar cpb, Status status)
        {  
            List<Incident> tickets = incidentService.GetTickets(user, status);
            cpb.Maximum = allTickets.Count;
            cpb.Value = tickets.Count;
            cpb.Text = tickets.Count.ToString();
        }

        private void RegularEmployeeForm_Load(object sender, EventArgs e)
        {
            incidentService.GetAllIncidents();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!validateTextBoxes(txtBoxes))
            {
                //...
            }
            else
            {
                Incident incident = new Incident(DateTime.Now, txtSubject.Text, TicketType.none, user.Id, DateTime.Now, txtDescription.Text, Status.incident);
                incidentService.AddIncident(incident);
            }
            emptyTextBoxes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            emptyTextBoxes();
        }
        private bool validateTextBoxes(List<TextBox> txtBoxes)
        {
            foreach (TextBox txtBox in txtBoxes)
            {
                if (txtBox.Text == string.Empty)
                    return false;
            }
            return true;
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            try
            {
                txtDescription.Text = string.Empty;
                txtDescription.ForeColor = Color.Black;

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void emptyTextBoxes()
        {
            foreach (TextBox txtBox in txtBoxes)
            {
                txtBox.Text = string.Empty;
            }
        }
    }
}

