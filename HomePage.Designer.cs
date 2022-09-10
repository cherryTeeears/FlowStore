
namespace FlowStore
{
    partial class HomePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowersListButton = new System.Windows.Forms.Button();
            this.adminSignInButton = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Electronic FlowerStore";
            // 
            // flowersListButton
            // 
            this.flowersListButton.Location = new System.Drawing.Point(289, 337);
            this.flowersListButton.Name = "flowersListButton";
            this.flowersListButton.Size = new System.Drawing.Size(201, 56);
            this.flowersListButton.TabIndex = 6;
            this.flowersListButton.Text = "Flowers";
            this.flowersListButton.UseVisualStyleBackColor = true;
            this.flowersListButton.Click += new System.EventHandler(this.flowersListButton_Click);
            // 
            // adminSignInButton
            // 
            this.adminSignInButton.Location = new System.Drawing.Point(289, 242);
            this.adminSignInButton.Name = "adminSignInButton";
            this.adminSignInButton.Size = new System.Drawing.Size(201, 56);
            this.adminSignInButton.TabIndex = 5;
            this.adminSignInButton.Text = "Admin";
            this.adminSignInButton.UseVisualStyleBackColor = true;
            this.adminSignInButton.Click += new System.EventHandler(this.adminSignInButton_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(289, 152);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(201, 56);
            this.signInBtn.TabIndex = 4;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowersListButton);
            this.Controls.Add(this.adminSignInButton);
            this.Controls.Add(this.signInBtn);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button flowersListButton;
        private System.Windows.Forms.Button adminSignInButton;
        private System.Windows.Forms.Button signInBtn;
    }
}