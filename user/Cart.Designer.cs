
namespace FlowStore
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.flowStoreDataSet = new FlowStore.FlowStoreDataSet();
            this.ordersTableAdapter = new FlowStore.FlowStoreDataSetTableAdapters.OrdersTableAdapter();
            this.orderTableDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFlowersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTotalPriceLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.flowerIdTextBox = new System.Windows.Forms.TextBox();
            this.flowerIdLabel = new System.Windows.Forms.Label();
            this.plusFlowerButton = new System.Windows.Forms.Button();
            this.minusFlowerButton = new System.Windows.Forms.Button();
            this.countFlowersTextBox = new System.Windows.Forms.TextBox();
            this.deleteFlowerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkoutButton
            // 
            this.checkoutButton.Enabled = false;
            this.checkoutButton.Location = new System.Drawing.Point(725, 415);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(123, 42);
            this.checkoutButton.TabIndex = 0;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // flowStoreDataSet
            // 
            this.flowStoreDataSet.DataSetName = "FlowStoreDataSet";
            this.flowStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableDataGridView
            // 
            this.orderTableDataGridView.AllowUserToAddRows = false;
            this.orderTableDataGridView.AutoGenerateColumns = false;
            this.orderTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.flowerIdDataGridViewTextBoxColumn,
            this.flowerNameDataGridViewTextBoxColumn,
            this.countFlowersDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.orderTableDataGridView.DataSource = this.ordersBindingSource;
            this.orderTableDataGridView.Location = new System.Drawing.Point(43, 106);
            this.orderTableDataGridView.Name = "orderTableDataGridView";
            this.orderTableDataGridView.ReadOnly = true;
            this.orderTableDataGridView.RowHeadersWidth = 51;
            this.orderTableDataGridView.RowTemplate.Height = 50;
            this.orderTableDataGridView.Size = new System.Drawing.Size(776, 234);
            this.orderTableDataGridView.TabIndex = 37;
            this.orderTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderTableDataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowerIdDataGridViewTextBoxColumn
            // 
            this.flowerIdDataGridViewTextBoxColumn.DataPropertyName = "FlowerId";
            this.flowerIdDataGridViewTextBoxColumn.HeaderText = "FlowerId";
            this.flowerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flowerIdDataGridViewTextBoxColumn.Name = "flowerIdDataGridViewTextBoxColumn";
            this.flowerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flowerNameDataGridViewTextBoxColumn
            // 
            this.flowerNameDataGridViewTextBoxColumn.DataPropertyName = "FlowerName";
            this.flowerNameDataGridViewTextBoxColumn.HeaderText = "FlowerName";
            this.flowerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flowerNameDataGridViewTextBoxColumn.Name = "flowerNameDataGridViewTextBoxColumn";
            this.flowerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countFlowersDataGridViewTextBoxColumn
            // 
            this.countFlowersDataGridViewTextBoxColumn.DataPropertyName = "CountFlowers";
            this.countFlowersDataGridViewTextBoxColumn.HeaderText = "CountFlowers";
            this.countFlowersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countFlowersDataGridViewTextBoxColumn.Name = "countFlowersDataGridViewTextBoxColumn";
            this.countFlowersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.MinimumWidth = 6;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.flowStoreDataSet;
            // 
            // orderTotalPriceLabel
            // 
            this.orderTotalPriceLabel.AutoSize = true;
            this.orderTotalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderTotalPriceLabel.Location = new System.Drawing.Point(403, 415);
            this.orderTotalPriceLabel.Name = "orderTotalPriceLabel";
            this.orderTotalPriceLabel.Size = new System.Drawing.Size(183, 29);
            this.orderTotalPriceLabel.TabIndex = 38;
            this.orderTotalPriceLabel.Text = "Total Price: 0$";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(29, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(123, 42);
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(224, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 32);
            this.nameLabel.TabIndex = 40;
            this.nameLabel.Text = "Name:";
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLabel.Location = new System.Drawing.Point(324, 24);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(0, 32);
            this.enterNameLabel.TabIndex = 41;
            // 
            // flowerIdTextBox
            // 
            this.flowerIdTextBox.Location = new System.Drawing.Point(144, 400);
            this.flowerIdTextBox.Name = "flowerIdTextBox";
            this.flowerIdTextBox.ReadOnly = true;
            this.flowerIdTextBox.Size = new System.Drawing.Size(44, 22);
            this.flowerIdTextBox.TabIndex = 42;
            // 
            // flowerIdLabel
            // 
            this.flowerIdLabel.AutoSize = true;
            this.flowerIdLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowerIdLabel.Location = new System.Drawing.Point(12, 391);
            this.flowerIdLabel.Name = "flowerIdLabel";
            this.flowerIdLabel.Size = new System.Drawing.Size(117, 32);
            this.flowerIdLabel.TabIndex = 43;
            this.flowerIdLabel.Text = "Flower Id:";
            // 
            // plusFlowerButton
            // 
            this.plusFlowerButton.Enabled = false;
            this.plusFlowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusFlowerButton.Location = new System.Drawing.Point(784, 34);
            this.plusFlowerButton.Name = "plusFlowerButton";
            this.plusFlowerButton.Size = new System.Drawing.Size(35, 31);
            this.plusFlowerButton.TabIndex = 44;
            this.plusFlowerButton.Text = "+";
            this.plusFlowerButton.UseVisualStyleBackColor = true;
            this.plusFlowerButton.Click += new System.EventHandler(this.plusFlowerButton_Click);
            // 
            // minusFlowerButton
            // 
            this.minusFlowerButton.Enabled = false;
            this.minusFlowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusFlowerButton.Location = new System.Drawing.Point(661, 34);
            this.minusFlowerButton.Name = "minusFlowerButton";
            this.minusFlowerButton.Size = new System.Drawing.Size(35, 31);
            this.minusFlowerButton.TabIndex = 45;
            this.minusFlowerButton.Text = "-";
            this.minusFlowerButton.UseVisualStyleBackColor = true;
            this.minusFlowerButton.Click += new System.EventHandler(this.minusFlowerButton_Click);
            // 
            // countFlowersTextBox
            // 
            this.countFlowersTextBox.Location = new System.Drawing.Point(716, 43);
            this.countFlowersTextBox.Name = "countFlowersTextBox";
            this.countFlowersTextBox.ReadOnly = true;
            this.countFlowersTextBox.Size = new System.Drawing.Size(44, 22);
            this.countFlowersTextBox.TabIndex = 46;
            // 
            // deleteFlowerButton
            // 
            this.deleteFlowerButton.Enabled = false;
            this.deleteFlowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFlowerButton.Location = new System.Drawing.Point(202, 426);
            this.deleteFlowerButton.Name = "deleteFlowerButton";
            this.deleteFlowerButton.Size = new System.Drawing.Size(84, 44);
            this.deleteFlowerButton.TabIndex = 47;
            this.deleteFlowerButton.Text = "Delete";
            this.deleteFlowerButton.UseVisualStyleBackColor = true;
            this.deleteFlowerButton.Click += new System.EventHandler(this.deleteFlowerButton_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(919, 482);
            this.Controls.Add(this.deleteFlowerButton);
            this.Controls.Add(this.countFlowersTextBox);
            this.Controls.Add(this.minusFlowerButton);
            this.Controls.Add(this.plusFlowerButton);
            this.Controls.Add(this.flowerIdLabel);
            this.Controls.Add(this.flowerIdTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.orderTotalPriceLabel);
            this.Controls.Add(this.orderTableDataGridView);
            this.Controls.Add(this.checkoutButton);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkoutButton;
        private FlowStoreDataSet flowStoreDataSet;
        private FlowStoreDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView orderTableDataGridView;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.Label orderTotalPriceLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFlowersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.TextBox flowerIdTextBox;
        private System.Windows.Forms.Label flowerIdLabel;
        private System.Windows.Forms.Button plusFlowerButton;
        private System.Windows.Forms.Button minusFlowerButton;
        private System.Windows.Forms.TextBox countFlowersTextBox;
        private System.Windows.Forms.Button deleteFlowerButton;
    }
}