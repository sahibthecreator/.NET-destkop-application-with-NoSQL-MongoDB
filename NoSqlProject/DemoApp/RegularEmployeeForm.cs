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

namespace DemoApp
{
    public partial class RegularEmployeeForm : Form
    {
        IncidentService incidentService= new IncidentService();
        public RegularEmployeeForm()
        {
            InitializeComponent();
        }

        private void RegularEmployeeForm_Load(object sender, EventArgs e)
        {
            incidentService.GetAllIncidents();
        }
    }
}
