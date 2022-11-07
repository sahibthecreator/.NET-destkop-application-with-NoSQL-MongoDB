using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logic;
using Model;
namespace DemoApp
{
    public partial class RegularEmployeeForm : Form
    {
        IncidentService incidentService= new IncidentService();
        List<TextBox> txtBoxes = new List<TextBox>();
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
        }

        private void RegularEmployeeForm_Load(object sender, EventArgs e)
        {
            incidentService.GetAllIncidents();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!validateTextBoxes(txtBoxes) || comboBoxType.Text == string.Empty)
            {
                //...
            }
            else
            {
                Incident incident = new Incident(DateTime.Now, txtSubject.Text, comboBoxType.Text, user.Id, datePicker.Value, txtDescription.Text, 0);
                incidentService = new IncidentService();
                incidentService.addIncident(incident);
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

