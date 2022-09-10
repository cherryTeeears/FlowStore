
namespace FlowStore
{
    partial class User
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
            System.Windows.Forms.Label adIDLabel;
            this.nameLabel = new System.Windows.Forms.Label();
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.flowersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.flowStoreDataSet = new FlowStore.FlowStoreDataSet();
            this.flowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowersTableAdapter = new FlowStore.FlowStoreDataSetTableAdapters.FlowersTableAdapter();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.cartButton = new System.Windows.Forms.Button();
            this.flowersTableDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flowStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            adIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adIDLabel
            // 
            adIDLabel.AutoSize = true;
            adIDLabel.Location = new System.Drawing.Point(174, 456);
            adIDLabel.Name = "adIDLabel";
            adIDLabel.Size = new System.Drawing.Size(25, 17);
            adIDLabel.TabIndex = 33;
            adIDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(181, 17);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 32);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Name:";
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameLabel.Location = new System.Drawing.Point(281, 17);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(0, 32);
            this.enterNameLabel.TabIndex = 29;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 37);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Log off";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowersBindingSource1
            // 
            this.flowersBindingSource1.DataMember = "Flowers";
            this.flowersBindingSource1.DataSource = this.flowStoreDataSet;
            // 
            // flowStoreDataSet
            // 
            this.flowStoreDataSet.DataSetName = "FlowStoreDataSet";
            this.flowStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowersBindingSource
            // 
            this.flowersBindingSource.DataSource = this.flowStoreDataSet;
            this.flowersBindingSource.Position = 0;
            // 
            // flowersTableAdapter
            // 
            this.flowersTableAdapter.ClearBeforeFill = true;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(429, 444);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(137, 37);
            this.addToCartButton.TabIndex = 32;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(270, 451);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 34;
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(784, 19);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(137, 37);
            this.cartButton.TabIndex = 35;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // flowersTableDataGridView
            // 
            this.flowersTableDataGridView.AllowUserToAddRows = false;
            this.flowersTableDataGridView.AutoGenerateColumns = false;
            this.flowersTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flowersTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flowersTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.flowersTableDataGridView.DataSource = this.flowersBindingSource2;
            this.flowersTableDataGridView.Location = new System.Drawing.Point(83, 133);
            this.flowersTableDataGridView.Name = "flowersTableDataGridView";
            this.flowersTableDataGridView.ReadOnly = true;
            this.flowersTableDataGridView.RowHeadersWidth = 51;
            this.flowersTableDataGridView.RowTemplate.Height = 50;
            this.flowersTableDataGridView.Size = new System.Drawing.Size(776, 234);
            this.flowersTableDataGridView.TabIndex = 36;
            this.flowersTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flowersTableDataGridView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "info";
            this.infoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "photo";
            this.photoDataGridViewImageColumn.HeaderText = "photo";
            this.photoDataGridViewImageColumn.MinimumWidth = 6;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.ReadOnly = true;
            // 
            // flowersBindingSource2
            // 
            this.flowersBindingSource2.DataMember = "Flowers";
            this.flowersBindingSource2.DataSource = this.flowStoreDataSet;
            // 
            // flowStoreDataSetBindingSource
            // 
            this.flowStoreDataSetBindingSource.DataSource = this.flowStoreDataSet;
            this.flowStoreDataSetBindingSource.Position = 0;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(943, 501);
            this.Controls.Add(this.flowersTableDataGridView);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(adIDLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.enterNameLabel);
            this.Controls.Add(this.backButton);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label enterNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource flowersBindingSource;
        private FlowStoreDataSet flowStoreDataSet;
        private System.Windows.Forms.BindingSource flowersBindingSource1;
        private FlowStoreDataSetTableAdapters.FlowersTableAdapter flowersTableAdapter;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.DataGridView flowersTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.BindingSource flowersBindingSource2;
        private System.Windows.Forms.BindingSource flowStoreDataSetBindingSource;
    }
}