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
    public partial class User : Form
    {
        DBAccess objDBAccess = new DBAccess();

        public User(string login)
        {
            InitializeComponent();
            enterNameLabel.Text = login;
            if (getFlowersCount() != 0)
            {
                setFirstFlowerId();
            }

        }

        public Cart Cart
        {
            get => default;
            set
            {
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowStoreDataSet.Flowers". При необходимости она может быть перемещена или удалена.
            this.flowersTableAdapter.Fill(this.flowStoreDataSet.Flowers);

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
        private void setFirstFlowerId()
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
        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.Show();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            bool haveRows = false;
            
            int flowerId = Convert.ToInt32(idTextBox.Text);
            byte[] photoArray = new byte[10];
            flowersBindingSource.EndEdit();
            flowersTableAdapter.Update(flowStoreDataSet);
            decimal price = 0;
            int userId = getUserId();

            string flowerName = "";
            string query = "SELECT name,price, photo FROM Flowers WHERE Id=" + flowerId;
            SqlCommand insertCommand = new SqlCommand(query);
            objDBAccess.executeQuery(insertCommand);
            SqlDataReader reader = insertCommand.ExecuteReader();
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    flowerName = reader.GetValue(0).ToString();
                    price = Convert.ToDecimal(reader.GetValue(1).ToString());
                    object rrr = reader.GetValue(2);
                    photoArray = (byte[])rrr;
                }

            }
            reader.Close();
            insertCommand.Dispose();
            AddFlowerToCart(flowerId, flowerName, price, userId);

            int cartId = getCartId();
            string newQuery = "SELECT COUNT(*) FROM Cart";
            SqlCommand command = new SqlCommand(newQuery);
            objDBAccess.executeQuery(command);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                haveRows = true;
                
            }
            
            sqlDataReader.Close();
            if (haveRows)
            {
                
                int count = getCount(flowerName, userId);
                decimal totalPrice = count * price;

                placeOrder(cartId, flowerId, flowerName, count, totalPrice, photoArray, userId);
                
            }
            deleteRepeatedOrder(flowerId, userId);
            if (!isFlowerWithThisIdInOrder(flowerId, userId))
            {
                deleteRepeatedCart(flowerId, userId);
            }
        }

        private void deleteRepeatedCart(int flowerId, int userId)
        {
            string deleteQuery = "DELETE FROM Cart WHERE UserId =" + userId + " AND FlowerId = " + flowerId +
                " AND Id NOT IN( SELECT MAX(Id) FROM Cart where FlowerId=" + flowerId + ")";
            SqlCommand command = new SqlCommand(deleteQuery);
            objDBAccess.executeQuery(command);
        }
        private void deleteRepeatedOrder(int flowerId, int userId)
        {
            string deleteQuery = "DELETE FROM Orders WHERE UserId =" + userId +" AND FlowerId = " + flowerId + 
                " AND CountFlowers NOT IN( SELECT MAX(CountFlowers) FROM Orders where FlowerId=" + flowerId +")";
            SqlCommand command = new SqlCommand(deleteQuery);
            objDBAccess.executeQuery(command);
        }

        private bool isFlowerWithThisIdInOrder(int flowerId, int userId)
        {
            bool flag = false;
            string query = "SELECT * FROM Orders WHERE UserId =" + userId + " AND FlowerId = " + flowerId;
            SqlCommand command = new SqlCommand(query);
            objDBAccess.executeQuery(command);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                flag = true;
            }
            reader.Close();
            return flag;
        }
        private int getCartId()
        {
            int cartId = 1;
            string selectCartIdQuery = "SELECT Max(Id) FROM Cart";
            SqlCommand giveCarIdInsertCommand = new SqlCommand(selectCartIdQuery);
            objDBAccess.executeQuery(giveCarIdInsertCommand);
            SqlDataReader reader = giveCarIdInsertCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cartId = Convert.ToInt32(reader.GetValue(0).ToString());
                }

            }
            reader.Close();
            

            return cartId;
        }
        public bool checkInsertInCartData(int flowerId, string flowerName, decimal price,int userId)
        {
            if (Validator.isEmpty(flowerName))
            {
                return false;
            }
            else if (Validator.checkForDigits(Convert.ToString(price)) && Validator.checkForDigits(Convert.ToString(flowerId)) && Validator.checkForDigits(Convert.ToString(userId)))
            {
                return false;
            }

            return true;
        }

        private int getUserId()
        {
            int userId=1;
            string selectUserIdQuery = "SELECT Id FROM Users WHERE login='" + enterNameLabel.Text + "'";
            SqlCommand secondInsertCommand = new SqlCommand(selectUserIdQuery);
            objDBAccess.executeQuery(secondInsertCommand);
            SqlDataReader secondReader = secondInsertCommand.ExecuteReader();
            if (secondReader.HasRows)
            {
                while (secondReader.Read())
                {
                    userId = Convert.ToInt32(secondReader.GetValue(0).ToString());
                }

            }
            secondReader.Close();
            return userId;
        }

        private int getCount(string flowerName, int userId)
        {
            int count = 1;
            string selectCountFlowQuery = "SELECT Count(*) FROM Cart WHERE FlowerName = '" + flowerName + "' AND UserId = " + userId;
            SqlCommand selectCountFlowInsertCommand = new SqlCommand(selectCountFlowQuery);
            objDBAccess.executeQuery(selectCountFlowInsertCommand);
            SqlDataReader reader = selectCountFlowInsertCommand.ExecuteReader();
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
        /*private int getCartId(int userId, int flowerId)
        {
            int cartId = 1;
            string selectCartIdQuery = "SELECT Id FROM Cart WHERE UserId=" + userId + "AND FlowerId=" + flowerId;
            SqlCommand insertCommand = new SqlCommand(selectCartIdQuery);
            objDBAccess.executeQuery(insertCommand);
            SqlDataReader reader = insertCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    userId = Convert.ToInt32(reader.GetValue(0).ToString());
                }

            }
            reader.Close();
            return cartId;
        }
        */
        public SqlCommand insertIntoCart(string query, int flowerId, string flowerName, decimal price, int userId)
        {
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@FlowerId", flowerId);
            insertCommand.Parameters.AddWithValue("@FlowerName", flowerName);
            insertCommand.Parameters.AddWithValue("@price", price);
            insertCommand.Parameters.AddWithValue("@UserId", userId);


            return insertCommand;
        }

        private void AddFlowerToCart(int flowerId, string flowerName, decimal price, int userId)
        {
            
                string insertQuery = "insert into Cart(FlowerId, FlowerName, price, UserId) values(@flowerId, @flowerName, @price, @userId)";
                int row = objDBAccess.executeQuery(insertIntoCart(insertQuery, flowerId, flowerName, price, userId));


                if (row == 1)
                {
                    MessageBox.Show("Flower add successfully!");
                    flowersTableAdapter.Update(flowStoreDataSet);
                }
                else
                {
                    MessageBox.Show("Error. Please, Try again");
                }
            
             
        }
        private void placeOrder(int cartId, int flowerId, string flowerName, int count, decimal totalPrice, byte[] photoArray, int userId) 
        {
            //функция оформления заказа
            
            string insertOrderQuery = "Insert into Orders (CartId, FlowerId, FlowerName, CountFlowers, TotalPrice, Photo, UserId) " +
                " values(@cartId, @flowerId, @flowerName, @count, @totalPrice, @photoArray, @userId)";
            int row = objDBAccess.executeQuery(insertIntoOrder(insertOrderQuery, cartId, flowerId, flowerName, count, totalPrice, photoArray, userId));
                
            if (row == 1)
            {
                
                flowersTableAdapter.Update(flowStoreDataSet);
            }
            else
            {
                MessageBox.Show("Error. Please, Try again");
            }
            
        }

       
        public SqlCommand insertIntoOrder(string query, int cartId, int flowerId, string flowerName, int count, decimal totalPrice, byte[] photoArray, int userId)
        {
            SqlCommand insertCommand = new SqlCommand(query);
            insertCommand.Parameters.AddWithValue("@cartId", cartId);
            insertCommand.Parameters.AddWithValue("@flowerId", flowerId);
            insertCommand.Parameters.AddWithValue("@flowerName", flowerName);
            insertCommand.Parameters.AddWithValue("@count", count);
            insertCommand.Parameters.AddWithValue("@totalPrice", totalPrice);
            insertCommand.Parameters.AddWithValue("@photoArray", photoArray);
            insertCommand.Parameters.AddWithValue("@userId", userId);


            return insertCommand;
        }
        private void flowersTableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTextBox.Text = flowersTableDataGridView.CurrentRow.Cells[0].Value.ToString();

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(enterNameLabel.Text);
            this.Hide();
            cart.ShowDialog();
        }
    }
}
