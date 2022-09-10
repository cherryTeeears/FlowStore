using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowStore
{
    public partial class ChangeFlower : Form
    {
        DBAccess objDBAccess = new DBAccess();
        Bitmap image;
        byte[] arrBytes;
        bool flag = false;

        public ChangeFlower(int flowerId)
        {

            InitializeComponent();
            flowerIdTextBox.Text = flowerId.ToString();


            string query = "SELECT name,info,category,price,photo FROM Flowers WHERE Id="+ flowerId;
            SqlCommand insertCommand = new SqlCommand(query);
            objDBAccess.executeQuery(insertCommand);
            SqlDataReader reader = insertCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    flowerNameTextBox.Text = reader.GetValue(0).ToString();
                    infoRichTextBox.Text = reader.GetValue(1).ToString();
                    categoryComboBox.Text = reader.GetValue(2).ToString();
                    priceTextBox.Text = reader.GetValue(3).ToString();
                    object rrr = reader.GetValue(4);
                    MemoryStream ms = new MemoryStream();
                    byte[] bArr = (byte[])rrr;
                    ms.Write(bArr, 0, Convert.ToInt32(bArr.Length));
                    Bitmap bm = new Bitmap(ms, false);
                    ms.Dispose();
                    photoPictureBox.Image = bm;
                    arrBytes = bArr;
                    
                }

            }
            reader.Close();

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            flowersBindingSource.EndEdit();
            flowersTableAdapter.Update(flowStoreDataSet);

            int flowerId = Convert.ToInt32(flowerIdTextBox.Text);
            string flowerName = flowerNameTextBox.Text;
            string info = infoRichTextBox.Text;
            string category = categoryComboBox.Text;
            decimal price = Convert.ToDecimal(priceTextBox.Text);
            string query;


            if (checkInsertData(flowerId.ToString(), flowerName, info, category, price.ToString(), arrBytes))
            {
                if (checkFlowerName(flowerName, flowerId))
                {

                    query = "update Flowers set name = @flowerName, info = @info, category = @category, price = @price, photo = @arrBytes where Id = @flowerId";



                    int row = objDBAccess.executeQuery(updateFlowers(query, flowerId, flowerName, info, category, price, arrBytes));


                    if (row == 1)
                    {
                        MessageBox.Show("Info successfully changed!");
                        flowersTableAdapter.Update(flowStoreDataSet);
                        AdminPage admin = new AdminPage();
                        Hide();
                        admin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error. Please, Try again");
                    }
                }
                else
                {
                    MessageBox.Show("Error, this flower name already exist!", "Flower Name Error");
                }
                
            }
            else if (Validator.isEmpty(Convert.ToString(arrBytes)))
            {
                MessageBox.Show("Choose the flower photo!", "Error");
            }


        }

        private bool checkFlowerName(string flowerName, int flowerId)
        {
            bool flag = true;
            string query = "SELECT name FROM Flowers WHERE name = '" + flowerName + "' AND Id NOT IN (" + flowerId + ")";
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

        public bool checkInsertData(string flowerId, string flowerName, string info, string category, string price, byte[] photo)
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
            else if (!Validator.isValidLength(info, 0, 200))
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

        public SqlCommand updateFlowers(string query, int flowerId, string flowerName, string info, string category, decimal price, byte[] bArr)
        {
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.Add(new SqlParameter("@flowerName", flowerName));
            updateCommand.Parameters.Add(new SqlParameter("@info", info));
            updateCommand.Parameters.Add(new SqlParameter("@category", category));
            updateCommand.Parameters.Add(new SqlParameter("@price", price));
            updateCommand.Parameters.Add(new SqlParameter("@arrBytes", bArr));
            updateCommand.Parameters.Add(new SqlParameter("@flowerId", flowerId));


            return updateCommand;
        }
        private void flowersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        
        private void photoPictureBox_Click(object sender, EventArgs e)
        {
            flag = true;
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла

            open_dialog.Filter = "Image Files(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*"; //формат загружаемого файла

            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    Image image = Image.FromFile(open_dialog.FileName);
                    arrBytes = imgToByteArray(image);
                    photoPictureBox.Image = new Bitmap(open_dialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Impossible to open this file!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminPage adminPage = new AdminPage();

            MessageBoxButtons messageBox = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to leave?\nData is not saved when leaving the form", "Leave message", messageBox);
            if (result == DialogResult.Yes)
            {

                Hide();
                adminPage.ShowDialog();
            }
            
        }

        public byte[] imgToByteArray(Image img)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                img.Save(mStream, img.RawFormat);
                //mStream.Read(arrBytes, 0, Convert.ToInt32(mStream.Length));
                return mStream.ToArray();
                //return arrBytes;
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
