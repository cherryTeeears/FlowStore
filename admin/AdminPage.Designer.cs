
namespace FlowStore
{
    partial class AdminPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.flowersTableDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.flowersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.flowStoreDataSet = new FlowStore.FlowStoreDataSet();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.flowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowersTableAdapter = new FlowStore.FlowStoreDataSetTableAdapters.FlowersTableAdapter();
            this.flowersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            adIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flowersTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // adIDLabel
            // 
            adIDLabel.AutoSize = true;
            adIDLabel.Location = new System.Drawing.Point(302, 343);
            adIDLabel.Name = "adIDLabel";
            adIDLabel.Size = new System.Drawing.Size(25, 17);
            adIDLabel.TabIndex = 30;
            adIDLabel.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Page";
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(48, 389);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(169, 49);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(111, 43);
            this.homeButton.TabIndex = 26;
            this.homeButton.Text = "Back to home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(305, 389);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(169, 49);
            this.changeButton.TabIndex = 25;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(619, 389);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(169, 49);
            this.addButton.TabIndex = 28;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.flowersTableDataGridView.Location = new System.Drawing.Point(12, 64);
            this.flowersTableDataGridView.Name = "flowersTableDataGridView";
            this.flowersTableDataGridView.ReadOnly = true;
            this.flowersTableDataGridView.RowHeadersWidth = 51;
            this.flowersTableDataGridView.RowTemplate.Height = 50;
            this.flowersTableDataGridView.Size = new System.Drawing.Size(776, 234);
            this.flowersTableDataGridView.TabIndex = 29;
            this.flowersTableDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flowersTableDataGridView_CellClick);
            this.flowersTableDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.flowersTableDataGridView_DataError);
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
            // flowStoreDataSet
            // 
            this.flowStoreDataSet.DataSetName = "FlowStoreDataSet";
            this.flowStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(398, 338);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 31;
            // 
            // flowersTableAdapter
            // 
            this.flowersTableAdapter.ClearBeforeFill = true;
            // 
            // flowersBindingSource1
            // 
            this.flowersBindingSource1.DataMember = "Flowers";
            this.flowersBindingSource1.DataSource = this.flowStoreDataSet;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(adIDLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.flowersTableDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.label1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowersTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView flowersTableDataGridView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource flowersBindingSource;
        private FlowStoreDataSetTableAdapters.FlowersTableAdapter flowersTableAdapter;
        private FlowStoreDataSet flowStoreDataSet;
        private System.Windows.Forms.BindingSource flowersBindingSource1;
        private System.Windows.Forms.BindingSource flowersBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
    }
}