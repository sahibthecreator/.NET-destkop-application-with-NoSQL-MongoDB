using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        private Databases databases;
        private UserService userService;
        public static User user;
        public Form1()
        {
            InitializeComponent();
            databases = new Databases();
            userService = new UserService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dbList = databases.Get_All_Databases();
            
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userService.GetUserByEmail(emailInput.Text).Count > 0)
            {
                user = userService.GetUserByEmail(emailInput.Text)[0];
                if(VerifyHashedPassword(passwordInput.Text, user.Password))
                {
                    if (user.Type == UserType.basic)
                    {
                        RegularEmployeeForm newForm = new RegularEmployeeForm(user);
                        this.Hide();
                        newForm.ShowDialog();
                        this.Close();
                    }
                    else if (user.Type.Equals(UserType.admin))
                    {
                        ServiceDeskEmployeeForm newForm = new ServiceDeskEmployeeForm();
                        this.Hide();
                        newForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    errorMessage.Text = "Password is not correct";
                }
            }
            else
            {
                errorMessage.Text = "User with this email was not found";
            }
        }

        private Boolean VerifyHashedPassword(string password, string hashedPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }
            return true;
        }

    }
}
