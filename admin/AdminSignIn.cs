using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowStore
{
    public partial class AdminSignIn : Form
    {
        public AdminSignIn()
        {
            InitializeComponent();
        }

        public AdminPage AdminPage
        {
            get => default;
            set
            {
            }
        }

        private void signInAdminButton_Click(object sender, EventArgs e)
        {
            string adminLogin = adminLoginTextBox.Text;
            string adminPassword = adminPasswordTextBox.Text;

            if (Validator.isEmpty(adminLogin))
            {
                MessageBox.Show("Please, enter login");
            }
            else if (Validator.isEmpty(adminPassword))
            {
                MessageBox.Show("Please, enter password");
            }
            else if (adminLogin == "Admin" && adminPassword == "admin123")
            {
                MessageBox.Show("Welcome to administration page!", "Welcome!");
                AdminPage adminPage = new AdminPage();
                Hide();
                adminPage.Show();
            }
            else
            {
                MessageBox.Show("Invalid login or password! Try again!", "Error!");
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            Hide();
            home.Show();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                adminPasswordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                adminPasswordTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
