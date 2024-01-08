namespace TheBookStore
{
    partial class ChangePasswordForm
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
            label1 = new Label();
            label2 = new Label();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSubmitNewPassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 41);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "New Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 82);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Confirm Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(124, 38);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(139, 23);
            txtNewPassword.TabIndex = 2;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(124, 74);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(139, 23);
            txtConfirmPassword.TabIndex = 3;
            // 
            // btnSubmitNewPassword
            // 
            btnSubmitNewPassword.Location = new Point(197, 117);
            btnSubmitNewPassword.Name = "btnSubmitNewPassword";
            btnSubmitNewPassword.Size = new Size(66, 23);
            btnSubmitNewPassword.TabIndex = 4;
            btnSubmitNewPassword.Text = "Submit";
            btnSubmitNewPassword.UseVisualStyleBackColor = true;
            btnSubmitNewPassword.Click += btnSubmitNewPassword_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 172);
            Controls.Add(btnSubmitNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Button btnSubmitNewPassword;
    }
}