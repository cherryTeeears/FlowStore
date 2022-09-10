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
    public partial class FlowersForUnautorizeUser : Form
    {
        public FlowersForUnautorizeUser()
        {
            InitializeComponent();
        }

        private void FlowersForUnautorizeUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "flowStoreDataSet.Flowers". При необходимости она может быть перемещена или удалена.
            this.flowersTableAdapter.Fill(this.flowStoreDataSet.Flowers);

        }

        private void signInbutton_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }
    }
}
