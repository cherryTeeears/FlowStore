
namespace FlowStore
{
    partial class FlowersForUnautorizeUser
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
            this.flowersTableDataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.flowStoreDataSet = new FlowStore.FlowStoreDataSet();
            this.flowStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowersTableAdapter = new FlowStore.FlowStoreDataSetTableAdapters.FlowersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.signInbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flowersTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.flowersTableDataGridView.DataSource = this.flowersBindingSource;
            this.flowersTableDataGridView.Location = new System.Drawing.Point(45, 118);
            this.flowersTableDataGridView.Name = "flowersTableDataGridView";
            this.flowersTableDataGridView.ReadOnly = true;
            this.flowersTableDataGridView.RowHeadersWidth = 51;
            this.flowersTableDataGridView.RowTemplate.Height = 50;
            this.flowersTableDataGridView.Size = new System.Drawing.Size(827, 302);
            this.flowersTableDataGridView.TabIndex = 44;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(11, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 37);
            this.backButton.TabIndex = 37;
            this.backButton.Text = "Home";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flowStoreDataSet
            // 
            this.flowStoreDataSet.DataSetName = "FlowStoreDataSet";
            this.flowStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowStoreDataSetBindingSource
            // 
            this.flowStoreDataSetBindingSource.DataSource = this.flowStoreDataSet;
            this.flowStoreDataSetBindingSource.Position = 0;
            // 
            // flowersBindingSource
            // 
            this.flowersBindingSource.DataMember = "Flowers";
            this.flowersBindingSource.DataSource = this.flowStoreDataSet;
            // 
            // flowersTableAdapter
            // 
            this.flowersTableAdapter.ClearBeforeFill = true;
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
            // signInbutton
            // 
            this.signInbutton.Location = new System.Drawing.Point(753, 443);
            this.signInbutton.Name = "signInbutton";
            this.signInbutton.Size = new System.Drawing.Size(137, 37);
            this.signInbutton.TabIndex = 45;
            this.signInbutton.Text = "Sign In";
            this.signInbutton.UseVisualStyleBackColor = true;
            this.signInbutton.Click += new System.EventHandler(this.signInbutton_Click);
            // 
            // FlowersForUnautorizeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(969, 521);
            this.Controls.Add(this.signInbutton);
            this.Controls.Add(this.flowersTableDataGridView);
            this.Controls.Add(this.backButton);
            this.Name = "FlowersForUnautorizeUser";
            this.Text = "FlowersForUnautorizeUser";
            this.Load += new System.EventHandler(this.FlowersForUnautorizeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowersTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView flowersTableDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource flowStoreDataSetBindingSource;
        private FlowStoreDataSet flowStoreDataSet;
        private System.Windows.Forms.BindingSource flowersBindingSource;
        private FlowStoreDataSetTableAdapters.FlowersTableAdapter flowersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
        private System.Windows.Forms.Button signInbutton;
    }
}