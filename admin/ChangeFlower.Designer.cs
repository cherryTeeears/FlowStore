
namespace FlowStore
{
    partial class ChangeFlower
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
            System.Windows.Forms.Label flowerNameLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label infoLabel;
            System.Windows.Forms.Label flowerIdLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.flowerNameTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.flowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowStoreDataSet = new FlowStore.FlowStoreDataSet();
            this.flowersTableAdapter = new FlowStore.FlowStoreDataSetTableAdapters.FlowersTableAdapter();
            this.tableAdapterManager = new FlowStore.FlowStoreDataSetTableAdapters.TableAdapterManager();
            this.flowerIdTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            flowerNameLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            infoLabel = new System.Windows.Forms.Label();
            flowerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // flowerNameLabel
            // 
            flowerNameLabel.AutoSize = true;
            flowerNameLabel.Location = new System.Drawing.Point(226, 118);
            flowerNameLabel.Name = "flowerNameLabel";
            flowerNameLabel.Size = new System.Drawing.Size(92, 17);
            flowerNameLabel.TabIndex = 15;
            flowerNameLabel.Text = "Flower name:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(226, 374);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(48, 17);
            photoLabel.TabIndex = 17;
            photoLabel.Text = "photo:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(226, 278);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 19;
            priceLabel.Text = "price:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(226, 244);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(69, 17);
            categoryLabel.TabIndex = 23;
            categoryLabel.Text = "Category:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new System.Drawing.Point(226, 180);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new System.Drawing.Size(35, 17);
            infoLabel.TabIndex = 25;
            infoLabel.Text = "info:";
            // 
            // flowerIdLabel
            // 
            flowerIdLabel.AutoSize = true;
            flowerIdLabel.Location = new System.Drawing.Point(226, 93);
            flowerIdLabel.Name = "flowerIdLabel";
            flowerIdLabel.Size = new System.Drawing.Size(68, 17);
            flowerIdLabel.TabIndex = 30;
            flowerIdLabel.Text = "Flower id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Flower";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(607, 374);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(121, 64);
            this.changeButton.TabIndex = 27;
            this.changeButton.Text = "change info";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // flowerNameTextBox
            // 
            this.flowerNameTextBox.Location = new System.Drawing.Point(324, 118);
            this.flowerNameTextBox.Name = "flowerNameTextBox";
            this.flowerNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.flowerNameTextBox.TabIndex = 16;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.photoPictureBox.Location = new System.Drawing.Point(357, 323);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(142, 115);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 18;
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
            this.categoryComboBox.Location = new System.Drawing.Point(324, 241);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(215, 24);
            this.categoryComboBox.TabIndex = 24;
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.Location = new System.Drawing.Point(324, 146);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.Size = new System.Drawing.Size(215, 89);
            this.infoRichTextBox.TabIndex = 28;
            this.infoRichTextBox.Text = "";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(324, 278);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(215, 22);
            this.priceTextBox.TabIndex = 29;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // flowersBindingSource
            // 
            this.flowersBindingSource.DataSource = this.flowStoreDataSet;
            this.flowersBindingSource.Position = 0;
            this.flowersBindingSource.CurrentChanged += new System.EventHandler(this.flowersBindingSource_CurrentChanged);
            // 
            // flowStoreDataSet
            // 
            this.flowStoreDataSet.DataSetName = "FlowStoreDataSet";
            this.flowStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // flowerIdTextBox
            // 
            this.flowerIdTextBox.Location = new System.Drawing.Point(324, 90);
            this.flowerIdTextBox.Name = "flowerIdTextBox";
            this.flowerIdTextBox.ReadOnly = true;
            this.flowerIdTextBox.Size = new System.Drawing.Size(215, 22);
            this.flowerIdTextBox.TabIndex = 31;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(22, 32);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 64);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChangeFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(flowerIdLabel);
            this.Controls.Add(this.flowerIdTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(flowerNameLabel);
            this.Controls.Add(this.flowerNameTextBox);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(infoLabel);
            this.Controls.Add(this.label1);
            this.Name = "ChangeFlower";
            this.Text = "ChangeFlower";
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowStoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox flowerNameTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.BindingSource flowersBindingSource;
        private FlowStoreDataSet flowStoreDataSet;
        private FlowStoreDataSetTableAdapters.FlowersTableAdapter flowersTableAdapter;
        private FlowStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox flowerIdTextBox;
        private System.Windows.Forms.Button backButton;
    }
}