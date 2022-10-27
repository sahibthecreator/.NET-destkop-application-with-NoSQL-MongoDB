using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            UserService userService = new UserService();
            Incident incident = new Incident(DateTime.Now, txtSubject.Text, comboBoxType.Text, user.Id , datePicker.Value, txtDescription.Text, 0);
            incidentService = new IncidentService();
            incidentService.addIncident(incident);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach(TextBox tb in txtBoxes)
            {
                tb.Text = string.Empty;
            }
        }
    }
}

