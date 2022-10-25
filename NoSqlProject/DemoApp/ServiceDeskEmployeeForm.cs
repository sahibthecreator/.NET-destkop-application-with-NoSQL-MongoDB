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
                User user = new User(txtFirstName.Text, txtLastName.Text, comboLocation.Text, txtPhoneNumber.Text, txtEmail.Text, comboType.Text);
                UserService userService = new UserService();
                userService.addUser(user);
                clearBoxes();
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
    }
}
