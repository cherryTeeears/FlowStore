using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowStore
{
    public partial class AddNewFlower : Form
    {
        byte[] bArr;
        DBAccess objDBAccess = new DBAccess();
        AdminPage adminPage = new AdminPage();
        
        public AddNewFlower(int id)
        {
            InitializeComponent();
            categoryComboBox.SelectedItem = "Roses";
            flowerIdTextBox.Text = id.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBox = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to leave?\nData is not saved when leaving the form", "Leave message", messageBox);
            if (result == DialogResult.Yes)
            {

                Hide();
                adminPage.ShowDialog();
            }


        }

        private void AddNewFlower_Load(object sender, EventArgs e)
        {
            //flowerBindingSource.AddNew();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            flowerBindingSource.EndEdit();
            flowersTableAdapter.Update(flowStoreDataSet);

            int flowerId = Convert.ToInt32(flowerIdTextBox.Text);
            string flowerName = flowerNameTextBox.Text;
            string info = infoRichTextBox.Text;
            string category = categoryComboBox.Text;
            decimal price = Convert.ToDecimal(priceTextBox.Text);

            if (checkInsertData(flowerId.ToString(), flowerName, info, category, price.ToString()))
            {
                if (checkFlowerName(flowerName))
                {
                    if (Validator.isEmpty(Convert.ToString(bArr)))
                    {
                        MessageBox.Show("Choose the flower photo!", "Error");
                    }

                        string query = "insert into Flowers(Id, name, info, category, price, photo) values(@Id, @name, @info, @category, @price, @photo)";
                        int row = objDBAccess.executeQuery(insertIntoFlowers(query, flowerId, flowerName, info, category, price, bArr));


                        if (row == 1)
                        {
                            MessageBox.Show("Info add successfully!");
                            flowersTableAdapter.Update(flowStoreDataSet);
                            this.Hide();
                            adminPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error. Please, Try again");
                        }
                    
                }
                else
                {
                    MessageBox.Show("This flower name already exists!");
                }
            }
            
            
        }

        private bool checkFlowerName(string flowerName)
        {
            bool flag = true;
            string query = "SELECT name FROM Flowers WHERE name = '" + flowerName + "'";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                flag = false;
            }
            reader.Close();
            return flag;
        }

        public bool checkInsertData(string flowerId, string flowerName, string info, string category, string price)
        {
            if (Validator.isEmpty(flowerName))
            {
                MessageBox.Show("Flower name must be filled!", "Error");
                return false;
            }
            else if (!Validator.isValidLength(flowerName, 4, 30))
            {
                MessageBox.Show("Flower name must contain from 4 to 30 symbols!", "Error");
                return false;
            }
            else if (Validator.isEmpty(info))
            {
                MessageBox.Show("Information field must be filled!", "Error");
                return false;
            }
            else if (!Validator.isValidLength(info, 1, 200))
            {
                MessageBox.Show("Information field must contain from 0 to 200 symbols!", "Error");
                return false;
            }
            else if (Validator.isEmpty(category))
            {
                MessageBox.Show("Category field must be filled!", "Error");
                return false;
            }
            
            else if (Validator.checkForDigits(Convert.ToString(flowerId)))
            {
                MessageBox.Show("", "Error");
                return false;
            }
            else if (!Validator.checkForNumber(Convert.ToString(price)) || Convert.ToDecimal(price) < Convert.ToDecimal(0.01))
            {
                MessageBox.Show("The price of a flower must be a positive number!", "Error");
                return false;
            }
            

            return true;
        }

        public SqlCommand insertIntoFlowers(string query, int flowerId, string flowerName, string info, string category, decimal price, byte[] bArr)
        {
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@Id", flowerId);
            insertCommand.Parameters.AddWithValue("@name", flowerName);
            insertCommand.Parameters.AddWithValue("@info", info);
            insertCommand.Parameters.AddWithValue("@category", category);
            insertCommand.Parameters.AddWithValue("@price", price);
            insertCommand.Parameters.AddWithValue("@photo", bArr);
            

            return insertCommand;
        }

        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла

            open_dialog.Filter = "Image Files(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*"; //формат загружаемого файла

            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    Image image = Image.FromFile(open_dialog.FileName);
                    bArr = imgToByteArray(image);
                    photoPictureBox.Image = new Bitmap(open_dialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Impossible to open this file!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                return mStream.ToArray();
            }
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
