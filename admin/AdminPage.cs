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
    public partial class AdminPage : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public AdminPage()
        {
            InitializeComponent();
            flowersTableDataGridView.Refresh();
            if (getFlowersCount() != 0)
            {
                deleteButton.Enabled = true;
                changeButton.Enabled = true;
                getFirstFlowerId();
            }
        }

        public ChangeFlower ChangeFlower
        {
            get => default;
            set
            {
            }
        }

        public AddNewFlower AddNewFlower
        {
            get => default;
            set
            {
            }
        }

        private int getFlowersCount()
        {
            int count = 0;
            string query = "SELECT COUNT(Id) FROM Flowers";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    count = Convert.ToInt32(reader.GetValue(0).ToString());
                }
            }
            reader.Close();
            return count;
        }

        private int getNewFlowerId()
        {
            int newFlowerId = 1;

            string query = "SELECT TOP 1 MAX(Id) FROM Flowers";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newFlowerId = Convert.ToInt32(reader.GetValue(0).ToString());

                }
            }
            reader.Close();
            return newFlowerId + 1;
        }

        private void getFirstFlowerId()
        {
            int firstFlowerId;
            
            string query = "SELECT TOP 1 MIN(Id) FROM Flowers";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    firstFlowerId = Convert.ToInt32(reader.GetValue(0).ToString());

                    idTextBox.Text = firstFlowerId.ToString();

                }
            }
            reader.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowStoreDataSet.Flowers". При необходимости она может быть перемещена или удалена.
            this.flowersTableAdapter.Fill(this.flowStoreDataSet.Flowers);
            flowersTableDataGridView.Refresh();


        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            Hide();
            home.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteFlowerFromOrder();
            deleteFlowerFromCart();
            string query = "DELETE from Flowers where Id = " + idTextBox.Text;

            SqlCommand deleteCommand = new SqlCommand(query);

            int row = objDBAccess.executeQuery(deleteCommand);
            
            if (row == 1)
            {
                MessageBox.Show("Flower successfully deleted!");
                flowersTableAdapter.Update(flowStoreDataSet);
                this.flowersTableAdapter.Fill(this.flowStoreDataSet.Flowers);
            }
            else
            {
                MessageBox.Show("Error. Please, Try again");
            }
            objDBAccess.closeConn();
        }
        private void deleteFlowerFromCart()
        {
            string query = "DELETE from Cart where FlowerId = " + idTextBox.Text;

            SqlCommand deleteCommand = new SqlCommand(query);

            int row = objDBAccess.executeQuery(deleteCommand);

            if (row == 1)
            {
                
                flowersTableAdapter.Update(flowStoreDataSet);
                this.flowersTableAdapter.Fill(this.flowStoreDataSet.Flowers);
            }
            
            objDBAccess.closeConn();
        }
        private void deleteFlowerFromOrder()
        {
            string query = "DELETE from Orders where FlowerId = " + idTextBox.Text;

            SqlCommand deleteCommand = new SqlCommand(query);

            int row = objDBAccess.executeQuery(deleteCommand);

            if (row == 1)
            {

                flowersTableAdapter.Update(flowStoreDataSet);
                this.flowersTableAdapter.Fill(this.flowStoreDataSet.Flowers);
            }

            objDBAccess.closeConn();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT Id FROM Flowers WHERE Id=" + idTextBox.Text;
            SqlCommand insertCommand = new SqlCommand(query);
            objDBAccess.executeQuery(insertCommand);
            SqlDataReader reader = insertCommand.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Error. Please, Try again");
                
            }
            else
            {
                reader.Close();

                ChangeFlower changeFlower = new ChangeFlower(Convert.ToInt32(idTextBox.Text));
                this.Hide();
                changeFlower.ShowDialog();
            }
            reader.Close();


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewFlower addNewFlower = new AddNewFlower(getNewFlowerId());
            this.Hide();
            addNewFlower.ShowDialog();

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void flowersTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Enter error!");
            e.ThrowException = false;
        }

        private void flowersTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = flowersTableDataGridView.CurrentRow.Cells[0].Value.ToString();

        }
    }
}


