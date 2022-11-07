using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class ServiceDeskEmployeeFormNew : Form
    {
        IncidentService incidentService = new IncidentService();
        UserService userService = new UserService();
        public ServiceDeskEmployeeFormNew()
        {
            InitializeComponent();
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayTickets()
        {
            try
            {
                List<Incident> incidents = incidentService.GetAllIncidents();
                lvTicketsOrUsers.Items.Clear();

                foreach (Incident incident in incidents)
                {
                    User user = userService.getUserById(incident.Reporter);

                    if (incident.Status != TicketStatus.notOpen)
                    {
                        ListViewItem item = new ListViewItem(incident.Id.ToString());
                        item.SubItems.Add(incident.Subject);
                        item.SubItems.Add(user.FirstName);
                        item.SubItems.Add(incident.Date.ToString("dd MMMM yyyy"));
                        item.SubItems.Add(incident.Status.ToString());
                        lvTicketsOrUsers.Items.Add(item);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
