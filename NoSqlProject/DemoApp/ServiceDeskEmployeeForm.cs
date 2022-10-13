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

namespace DemoApp
{
    public partial class ServiceDeskEmployeeForm : Form
    {
        List<TextBox> textBoxes = new List<TextBox>();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        public ServiceDeskEmployeeForm()
        {
            InitializeComponent();
            loadUsers("");
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
                UserService userService = new UserService();
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
                textBoxFilterByEmail.Text = "";

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
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!checkTextBoxes(textBoxes) && !checkComboBoxes(comboBoxes))
            {
                foreach (TextBox textBox in textBoxes)
                {
                    if (textBox.Text == "")
                    {
                        textBox.ForeColor = Color.Red;
                        textBox.Text = "Invalid input...";
                    }
                }
                foreach (ComboBox comboBox in comboBoxes)
                {
                    if (comboBox.Text == "")
                    {
                        comboBox.ForeColor = Color.Red;
                        comboBox.Text = "Invalid input...";
                    }
                }
            }
            else
            {
                //add user...
            }
        }

        private bool checkTextBoxes(List<TextBox> textBoxes)
        {
            int count = 0;

            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text == "" || textBox.Text == "Invalid input")
                    count++;
            }
            if (count == 0)
                return true;
            return false;
        }

        private bool checkComboBoxes(List<ComboBox> comboBoxes)
        {
            int count = 0;

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.Text == "" || comboBox.Text == "Invalid input")
                    count++;
            }
            if (count == 0)
                return true;
            return false;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }
    }
}
