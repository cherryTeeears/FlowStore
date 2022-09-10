
namespace FlowStore
{
    partial class AddNewFlower
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
            System.Windows.Forms.Label flowerIdLabel;
            System.Windows.Forms.Label flowerNameLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label infoLabel;
            System.Windows.Forms.Label addNewFlowerLabel;
            this.backButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowStoreDataSet = new FlowStore.FlowStoreDataSet();
            this.flowerIdTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.flowerNameTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.flowersTableAdapter = new FlowStore.FlowStoreDataSetTableAdapters.FlowersTableAdapter();
            this.tableAdapterManager = new FlowStore.FlowStoreDataSetTableAdapters.TableAdapterManager();
            flowerIdLabel = new System.Windows.Forms.Label();
            flowerNameLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            addNewFlowerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowerIdLabel
            // 
            flowerIdLabel.AutoSize = true;
            flowerIdLabel.Location = new System.Drawing.Point(155, 88);
            flowerIdLabel.Name = "flowerIdLabel";
            flowerIdLabel.Size = new System.Drawing.Size(68, 17);
            flowerIdLabel.TabIndex = 42;
            flowerIdLabel.Text = "Flower id:";
            // 
            // flowerNameLabel
            // 
            flowerNameLabel.AutoSize = true;
            flowerNameLabel.Location = new System.Drawing.Point(155, 113);
            flowerNameLabel.Name = "flowerNameLabel";
            flowerNameLabel.Size = new System.Drawing.Size(92, 17);
            flowerNameLabel.TabIndex = 32;
            flowerNameLabel.Text = "Flower name:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(155, 369);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(48, 17);
            photoLabel.TabIndex = 34;
            photoLabel.Text = "photo:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(155, 273);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 36;
            priceLabel.Text = "price:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(155, 239);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 37;
            categoryLabel.Text = "Category:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(155, 175);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(35, 17);
            infoLabel.TabIndex = 39;
            infoLabel.Text = "info:";
            // 
            // addNewFlowerLabel
            // 
            addNewFlowerLabel.AutoSize = true;
            addNewFlowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addNewFlowerLabel.Location = new System.Drawing.Point(261, 34);
            addNewFlowerLabel.Name = "addNewFlowerLabel";
            addNewFlowerLabel.Size = new System.Drawing.Size(207, 29);
            addNewFlowerLabel.TabIndex = 44;
            addNewFlowerLabel.Text = "Add New Flower";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(61, 34);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 27);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(617, 387);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 46);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // flowerBindingSource
            // 
            this.flowerBindingSource.DataSource = this.flowStoreDataSet;
            this.flowerBindingSource.Position = 0;
            // 
            // flowStoreDataSet
            // 
            this.flowStoreDataSet.DataSetName = "FlowStoreDataSet";
            this.flowStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowerIdTextBox
            // 
            this.flowerIdTextBox.Location = new System.Drawing.Point(253, 85);
            this.flowerIdTextBox.Name = "flowerIdTextBox";
            this.flowerIdTextBox.ReadOnly = true;
            this.flowerIdTextBox.Size = new System.Drawing.Size(215, 22);
            this.flowerIdTextBox.TabIndex = 43;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(253, 273);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(215, 22);
            this.priceTextBox.TabIndex = 41;
            this.priceTextBox.Text = "0,01";
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(253, 141);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(215, 89);
            this.infoRichTextBox.TabIndex = 40;
            this.infoRichTextBox.Text = "";
            // 
            // flowerNameTextBox
            // 
            this.flowerNameTextBox.Location = new System.Drawing.Point(253, 113);
            this.flowerNameTextBox.Name = "flowerNameTextBox";
            this.flowerNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.flowerNameTextBox.TabIndex = 33;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.photoPictureBox.Location = new System.Drawing.Point(286, 318);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(142, 115);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 35;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Roses",
            "Tulips",
            "Dahlies",
            "Peonies"});
            this.categoryComboBox.Location = new System.Drawing.Point(253, 236);
            this.categoryComboBox.MaxDropDownItems = 4;
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(215, 24);
            this.categoryComboBox.TabIndex = 38;
            // 
            // flowersTableAdapter
            // 
            this.flowersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = null;
            this.tableAdapterManager.FlowersTableAdapter = this.flowersTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FlowStore.FlowStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // AddNewFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(addNewFlowerLabel);
            this.Controls.Add(flowerIdLabel);
            this.Controls.Add(this.flowerIdTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(flowerNameLabel);
            this.Controls.Add(this.flowerNameTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Name = "AddNewFlower";
            this.Text = "AddNewFlower";
            this.Load += new System.EventHandler(this.AddNewFlower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox flowerIdTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.TextBox flowerNameTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource flowerBindingSource;
        private FlowStoreDataSet flowStoreDataSet;
        private FlowStoreDataSetTableAdapters.FlowersTableAdapter flowersTableAdapter;
        private FlowStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}