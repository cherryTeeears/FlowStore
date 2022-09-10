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
using Microsoft.VisualBasic;
namespace FlowStore
{
    public partial class Cart : Form
    {
        DBAccess objDBAccess = new DBAccess();
        private int userId;
        private decimal orderTotalPrice;
        private string login;
        private decimal totalPrice;
        private int flowerId;
        public Cart(string userLogin)
        {
            InitializeComponent();
            login = userLogin;
            nameLabel.Text += " " + login;
            userId = getUserId(login);
            orderTableDataGridView.DataSource = flowStoreDataSet.Orders;

            //check count of rows, why 0?????
            if (getRecordingCount()!= 0)
            {
                minusFlowerButton.Enabled = true;
                plusFlowerButton.Enabled = true;
                deleteFlowerButton.Enabled = true;
                checkoutButton.Enabled = true;
                orderTotalPrice = getOrderPrice(userId);

                orderTotalPriceLabel.Text = "Total Price: " + orderTotalPrice.ToString() + "$";
                addInfoInTable(userId);
                getFirstFlowerId();
                
                 
            }
            addInfoInTable(userId);
        }

        public NewPhoneNumber NewPhoneNumber
        {
            get => default;
            set
            {
            }
        }

        private int getRecordingCount()
        {
            int count = 0;
            string query = "SELECT COUNT(Id) FROM Orders WHERE UserId =" + userId;
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
        private void getFirstFlowerId()
        {
            int firstFlowerId;
            int firstFlowerCount;
            string query = "SELECT TOP 1 Id, FlowerId, CountFlowers FROM Orders WHERE UserId =" + userId+ " GROUP BY Id,CountFlowers, FlowerId having MIN(Id)>1";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    firstFlowerId = Convert.ToInt32(reader.GetValue(1).ToString());
                    firstFlowerCount = Convert.ToInt32(reader.GetValue(2).ToString());

                    flowerIdTextBox.Text = firstFlowerId.ToString();
                    countFlowersTextBox.Text = firstFlowerCount.ToString();



                }
            }
            reader.Close();
        }
        
        
        private void addInfoInTable(int userId)
        {
            //добавление данных о заказе userId = по логину в таблицу
            string query = "SELECT Id, FlowerId, FlowerName, " +
                "CountFlowers, TotalPrice, Photo FROM Orders WHERE UserId = " + userId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            adapter.Fill(table);
            orderTableDataGridView.DataSource = table;
        }
        private decimal getTotalPrice(int userId, int flowerId)
        {
            string query = "SELECT TotalPrice FROM Orders WHERE UserId = " + userId + " AND FlowerId=" +flowerId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    totalPrice = Convert.ToDecimal(reader.GetValue(0).ToString());
                }
            }
            reader.Close();
            return totalPrice;
        }
        private decimal getOrderPrice(int userId)
        {
            string query = "SELECT Sum(TotalPrice) FROM Orders WHERE UserId = " + userId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    if (Validator.isEmpty(reader.GetValue(0).ToString()))
                    {
                        orderTotalPrice = 0;
                    }
                    else
                    {
                        orderTotalPrice = Convert.ToDecimal(reader.GetValue(0).ToString());
                    }
                }
            }

            reader.Close();
            return orderTotalPrice;
        }

        private int getUserId(string login)
        {
            int userId = 1;
            string query = "SELECT Id FROM Users WHERE login = '" + login + "'";
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read())
                {
                    userId = Convert.ToInt32(reader.GetValue(0).ToString());
                }
            }

            reader.Close();
            return userId;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowStoreDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.flowStoreDataSet.Orders);

        }

        private void orderTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (getRecordingCount() != 0)
            {
                flowerIdTextBox.Text = orderTableDataGridView.CurrentRow.Cells[1].Value.ToString();
                countFlowersTextBox.Text = orderTableDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            User user = new User(login);
            this.Hide();
            user.ShowDialog();
        }

        private void minusFlowerButton_Click(object sender, EventArgs e)
        {
            flowerId = Convert.ToInt32(flowerIdTextBox.Text);/////Debug!!!
            totalPrice = getTotalPrice(userId, flowerId);

            int count = Convert.ToInt32(countFlowersTextBox.Text);
            if (count == 1)
            {
                deleteAllFlowersOneCategoryFromOrder(userId, flowerId);
                deleteAllFlowersOneCategoryFromCart(userId, flowerId);
                orderTableDataGridView.Rows.RemoveAt(orderTableDataGridView.CurrentRow.Index);
                //make refresh dategridview in this Form!!!!!!!
                orderTableDataGridView.Refresh();
                orderTableDataGridView.Update();
                this.Update();
                orderTotalPrice = getOrderPrice(userId);
                orderTotalPriceLabel.Text = "Total Price: " + orderTotalPrice.ToString() + "$";
                getFirstFlowerId();
            }
            else if (count > 1)
            {
                totalPrice -= totalPrice / count;

                count--;
                countFlowersTextBox.Text = count.ToString();
                updateCountFlowers(userId, flowerId, count);
                deleteFlowerFromCart(userId, flowerId);
                orderTableDataGridView.Update();
                this.Update();
                orderTableDataGridView.CurrentRow.Cells[3].Value = count;
                orderTableDataGridView.CurrentRow.Cells[4].Value = totalPrice;

                orderTotalPrice = getOrderPrice(userId);
                orderTotalPriceLabel.Text = "Total Price: " + orderTotalPrice.ToString() + "$";
            }
            if(getRecordingCount() == 0)
            {
                minusFlowerButton.Enabled = false;
                plusFlowerButton.Enabled = false;
                deleteFlowerButton.Enabled = false;
                checkoutButton.Enabled = false;
            }
        }
        private void deleteFlowerFromCart(int userId, int flowerId)
        {
            string query = "DELETE FROM Cart WHERE UserId=" + userId + " AND FlowerId= " 
                + flowerId + " AND Id = (SELECT MIN(Id) FROM Cart WHERE flowerId=" + flowerId +")";
            SqlCommand command = new SqlCommand(query); 
            objDBAccess.executeQuery(command);

        }
        private void updateCountFlowers(int userId, int flowerId, int count)
        {
            string query = "UPDATE Orders SET CountFlowers=@count, TotalPrice=@totalPrice WHERE UserId=" + userId + " AND FlowerId= " + flowerId;
            int row = objDBAccess.executeQuery(updateCountFlowers(query, count,totalPrice));

            if (row == 1)
            {
                MessageBox.Show("You have reduced the number of colors by 1!");
                ordersTableAdapter.Update(flowStoreDataSet);
            }
            else
            {
                MessageBox.Show("Error. Please, Try again");
            }

        }
        public SqlCommand updateCountFlowers(string query, int count, decimal totalPrice)
        {
            SqlCommand updateCommand = new SqlCommand(query);
            updateCommand.Parameters.Add(new SqlParameter("@count", count));
            updateCommand.Parameters.Add(new SqlParameter("@totalPrice", totalPrice));

            return updateCommand;
        }

      

        private void AddFlowerToCart(int flowerId, int userId)
        {
            
            string insertQuery = "insert into Cart(FlowerId, FlowerName, price, UserId) " +
                "SELECT TOP 1 FlowerId, FlowerName, price, UserId FROM Cart WHERE UserId=" + userId + " AND FlowerId=" + flowerId;

            SqlCommand command = new SqlCommand(insertQuery);

            objDBAccess.executeQuery(command);


        }
        

        private void plusFlowerButton_Click(object sender, EventArgs e)
        {
            flowerId = Convert.ToInt32(flowerIdTextBox.Text);
            totalPrice = getTotalPrice(userId, flowerId);

            int count = Convert.ToInt32(countFlowersTextBox.Text);
            totalPrice += totalPrice / count;

            count++;
            countFlowersTextBox.Text = count.ToString();
            updateCountFlowers(userId, flowerId, count);
            AddFlowerToCart(flowerId, userId);
            orderTableDataGridView.Update();
            this.Update();
            orderTableDataGridView.CurrentRow.Cells[3].Value = count;
            orderTableDataGridView.CurrentRow.Cells[4].Value = totalPrice;
            orderTotalPrice = getOrderPrice(userId);
            orderTotalPriceLabel.Text = "Total Price: " + orderTotalPrice.ToString() + "$";
        }

        private void deleteFlowerButton_Click(object sender, EventArgs e)
        {
            
            flowerId = Convert.ToInt32(flowerIdTextBox.Text);
            deleteAllFlowersOneCategoryFromOrder(userId, flowerId);
            deleteAllFlowersOneCategoryFromCart(userId, flowerId);
            orderTableDataGridView.Rows.RemoveAt(orderTableDataGridView.CurrentRow.Index);
            //make refresh dategridview in this Form!!!!!!!
            orderTableDataGridView.Refresh();
            orderTableDataGridView.Update();
            this.Update();
            orderTotalPrice = getOrderPrice(userId);
            orderTotalPriceLabel.Text = "Total Price: " + orderTotalPrice.ToString() + "$";
            getFirstFlowerId();
            if (getRecordingCount() == 0)
            {
                minusFlowerButton.Enabled = false;
                plusFlowerButton.Enabled = false;
                deleteFlowerButton.Enabled = false;
                checkoutButton.Enabled = false;

            }

        }
        private void deleteAllFlowersOneCategoryFromOrder(int userId, int flowerId)
        {
            string query = "DELETE FROM Orders WHERE UserId=" + userId + " AND FlowerId = " + flowerId;

            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
        }
        private void deleteAllFlowersOneCategoryFromCart(int userId, int flowerId)
        {
            string query = "DELETE FROM Cart WHERE UserId=" + userId + " AND FlowerId = " + flowerId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            string newPhoneNumber = "";
            string phoneNumber;
            phoneNumber = getUsersPhoneNumber();
            MessageBoxButtons messageBox = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Is this your phone number? " + phoneNumber, "Phone number", messageBox);

            if(result == DialogResult.Yes)
            {
                MessageBox.Show("\t\tCongratulations! \nYou bought flowers for " + orderTotalPrice + "$\nTo confirm the order, our operator will contact you", "Ordering");
                deleteOrders();
                deleteAllFlowersOneUserFromCart();
                User user = new User(login);
                this.Hide();
                user.ShowDialog();
            }
            else
            {
                //newPhoneNumber = Interaction.InputBox("Enter your phone nu,ber, please: ", "New phone number", "+375(00)0000000");
                NewPhoneNumber newPhone = new NewPhoneNumber(userId);
                newPhone.ShowDialog();
            }
        }
        private void deleteOrders()
        {
            string query = "DELETE FROM Orders WHERE UserId=" + userId;

            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
        }
        private void deleteAllFlowersOneUserFromCart()
        {
            
            string query = "DELETE FROM Cart WHERE UserId=" + userId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            
        }
        private string getUsersPhoneNumber()
        {
            string phoneNumber = "";
            string query = "SELECT phoneNumber FROM Users WHERE Id = " + userId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    phoneNumber = Convert.ToString(reader.GetValue(0).ToString());
                }
            }

            reader.Close();
            return phoneNumber;
        }
    }
}
