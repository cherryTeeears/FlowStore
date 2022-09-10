using System;
using System.Windows.Forms;

namespace FlowStore
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            Hide();
            signIn.Show();
        }

        private void adminSignInButton_Click(object sender, EventArgs e)
        {
            AdminSignIn adminSignIn = new AdminSignIn();
            Hide();
            adminSignIn.Show();
        }

        private void flowersListButton_Click(object sender, EventArgs e)
        {
            FlowersForUnautorizeUser unautorizeUser = new FlowersForUnautorizeUser();
            this.Hide();
            unautorizeUser.Show();
        }
    }
}
