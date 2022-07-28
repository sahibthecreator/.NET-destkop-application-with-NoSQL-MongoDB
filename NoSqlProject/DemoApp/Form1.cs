using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using System.Runtime.InteropServices;

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
            //foreach (var db in dbList)
            //{
            //    listBox1.Items.Add(db.name);
            //}
            //AllocConsole(); // Open Console
        }
        //------Console---------------------
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();
        //------Console---------------------

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userService.getMatchedUser(emailInput.Text, passwordInput.Text).Count > 0)
            {
                Console.WriteLine("Success");
                user = userService.getMatchedUser(emailInput.Text, passwordInput.Text)[0];
                if(user.Type==UserType.basic)
                {
                    RegularEmployeeForm newForm = new RegularEmployeeForm(user);
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();
                }
                else if(user.Type.Equals(UserType.admin))
                {
                    ServiceDeskEmployeeForm newForm = new ServiceDeskEmployeeForm();
                    this.Hide();
                    newForm.ShowDialog();
                    this.Close();
                }
                
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
