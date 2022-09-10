using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowStore
{
    public partial class SignUp : Form
    {
        DBAccess objDBAccess = new DBAccess();
        const int MINLENGTH = 8;
        const int MAXLENGTH = 20;
        public SignUp()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("D:\\Уник\\МТ\\FlowStore\\FlowStore\\Image\\FLOWSTORE.png");

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            SignIn user = new SignIn();
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string repeatPassword = repeatPasswordTB.Text;
            string phoneNumber = phoneNumberMaskedTextBox.Text.ToString();
            if (checkOnSameUsersLogin(login))
            {
                if (checkLoginAndPassword(login, password, repeatPassword))
                {
                    SqlCommand insertCommand = new SqlCommand("insert into Users(login, password, repeatPassword, phoneNumber) values(@login, @password, @repeatPassword, @phoneNumber)");

                    insertCommand.Parameters.AddWithValue("@login", login);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@repeatPassword", repeatPassword);
                    insertCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                    int row = objDBAccess.executeQuery(insertCommand);

                    if (row == 1)
                    {
                        MessageBox.Show("Account created successfully");
                        Hide();
                        user.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error accurated. Please, Try again");
                    }
                }
                
            }
        }

        private bool checkOnSameUsersLogin(string login)
        {
            bool flag = true;
            string query = "SELECT login FROM Users WHERE login='" + login + "'";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("A user with this login already exists!", "Exest User");
                flag = false;
            }
            reader.Close();
            return flag;
        }
        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = true;
                repeatPasswordTB.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = false;
                repeatPasswordTB.UseSystemPasswordChar = false;
            }
        }
        public bool checkLoginAndPassword(string login, string password, string repeatPassword)
        {
            if (Validator.isEmpty(login) || Validator.isEmpty(password))
            {
                MessageBox.Show("Please, enter correct login and password", "Empty string");
                return false;
            }
            else if (!Validator.isValidLength(login, MINLENGTH, MAXLENGTH) || !Validator.isValidLength(password, MINLENGTH, MAXLENGTH))
            {
                MessageBox.Show("Login and password must contain from 8 to 20 symbols!", "Wrong length");
                return false;
            }
            else if (!Validator.isValidLogin(login))
            {
                MessageBox.Show("Login must contain only latin letters", "Incorrect login");
                return false;
            }
            else if (!Validator.isValidPassword(password))
            {
                MessageBox.Show("Password can contain latin letters, digits and '_'", "Incorrect password");
                return false;
            } else if(!Validator.isSamePasswords(password, repeatPassword))
            {
                MessageBox.Show("Password and repeat password can be the same", "Incorrect password");
                return false;
            }
            else
                return true;
        }

        private void backButton_Сlick(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }
    }
}
