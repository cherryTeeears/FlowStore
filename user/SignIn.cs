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
    public partial class SignIn : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public static string name;
        public static string number;
        public static int id;
        public SignIn()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\Уник\\МТ\\FlowStore\\FlowStore\\Image\\FLOWSTORE.png");
        }

        public SignUp SignUp
        {
            get => default;
            set
            {
            }
        }

        public User User
        {
            get => default;
            set
            {
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {

            string login = loginSignInTextBox.Text;
            string password = passwordSignInTextBox.Text;
            User user = new User(login);
            if (Validator.isEmpty(login))
            {
                MessageBox.Show("Please, enter login");
            }
            else if (Validator.isEmpty(password))
            {
                MessageBox.Show("Please, enter password");
            }
            else
            {
                string query = "SELECT * FROM Users WHERE login = '" + login + "' AND password = '" + password + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    MessageBox.Show("Hello, " + login + ". Nice to meet you!", "Welcome!");
                    objDBAccess.closeConn();
                    id = Convert.ToInt32(dtUsers.Rows[0]["id"].ToString());
                    name = dtUsers.Rows[0]["login"].ToString();
                    password = dtUsers.Rows[0]["password"].ToString();
                    Hide();
                    user.Show();
                }
                else
                {
                    MessageBox.Show("There is no user with this login and password!", "Sign In error");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            Hide();
            signUp.Show();
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
                passwordSignInTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                passwordSignInTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
