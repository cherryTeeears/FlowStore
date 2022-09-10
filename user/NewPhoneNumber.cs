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
    public partial class NewPhoneNumber : Form
    {
        private int userId;
        DBAccess objDBAccess = new DBAccess();

        public NewPhoneNumber(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            
            string newPhoneNumber = newPhoneNumberMaskedTextBox.Text.ToString();
            if (newPhoneNumber != "+375(  )")
            {
                string query = "update Users set phoneNumber=@phoneNumber where Id = " + userId;

                //SqlCommand command = new SqlCommand(query);

                int row = objDBAccess.executeQuery(updatePhoneNumber(query, newPhoneNumber));


                if (row == 1)
                {
                    MessageBox.Show("Phone number successfully changed!");

                }
                else
                {
                    MessageBox.Show("Error. Please, Try again");
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error. Please, enter phone number!", "Error");
            }
        }
        public SqlCommand updatePhoneNumber(string query, string phoneNumber)
        {
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.Add(new SqlParameter("@phoneNumber", phoneNumber));

            return updateCommand;
        }
    }
}
