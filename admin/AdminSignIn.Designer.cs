
namespace FlowStore
{
    partial class AdminSignIn
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
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.signInAdminButton = new System.Windows.Forms.Button();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminLoginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(109, 46);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(94, 32);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 66);
            this.label3.TabIndex = 23;
            this.label3.Text = "Admin Verification";
            // 
            // signInAdminButton
            // 
            this.signInAdminButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.signInAdminButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInAdminButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signInAdminButton.Location = new System.Drawing.Point(515, 337);
            this.signInAdminButton.Name = "signInAdminButton";
            this.signInAdminButton.Size = new System.Drawing.Size(105, 42);
            this.signInAdminButton.TabIndex = 22;
            this.signInAdminButton.Text = "SignIn";
            this.signInAdminButton.UseVisualStyleBackColor = false;
            this.signInAdminButton.Click += new System.EventHandler(this.signInAdminButton_Click);
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordTextBox.Location = new System.Drawing.Point(391, 290);
            this.adminPasswordTextBox.Multiline = true;
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.PasswordChar = '*';
            this.adminPasswordTextBox.Size = new System.Drawing.Size(229, 32);
            this.adminPasswordTextBox.TabIndex = 21;
            // 
            // adminLoginTextBox
            // 
            this.adminLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginTextBox.Location = new System.Drawing.Point(391, 229);
            this.adminLoginTextBox.Multiline = true;
            this.adminLoginTextBox.Name = "adminLoginTextBox";
            this.adminLoginTextBox.Size = new System.Drawing.Size(229, 32);
            this.adminLoginTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login:";
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Location = new System.Drawing.Point(637, 301);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(129, 21);
            this.showPasswordCheckBox.TabIndex = 25;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // AdminSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signInAdminButton);
            this.Controls.Add(this.adminPasswordTextBox);
            this.Controls.Add(this.adminLoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminSignIn";
            this.Text = "AdminSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signInAdminButton;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.TextBox adminLoginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
    }
}