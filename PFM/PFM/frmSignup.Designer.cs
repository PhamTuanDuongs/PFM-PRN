namespace PFM
{
    partial class frmSignup
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
            components = new System.ComponentModel.Container();
            btnSignup = new Button();
            txtDisplayName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUsername = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.Location = new Point(399, 313);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(138, 39);
            btnSignup.TabIndex = 14;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(334, 243);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(287, 27);
            txtDisplayName.TabIndex = 13;
            txtDisplayName.Validating += txtDisplayName_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(184, 243);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 12;
            label4.Text = "DisplayName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 170);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(334, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(289, 27);
            txtPassword.TabIndex = 10;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(178, 97);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(334, 97);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(287, 27);
            txtUsername.TabIndex = 8;
            txtUsername.Validating += txtUsername_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(272, 105);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 29;
            label7.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(272, 178);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 30;
            label1.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(313, 251);
            label5.Name = "label5";
            label5.Size = new Size(15, 20);
            label5.TabIndex = 31;
            label5.Text = "*";
            // 
            // frmSignup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(btnSignup);
            Controls.Add(txtDisplayName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Name = "frmSignup";
            Text = "frmSignUp";
            Load += frmSignup_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignup;
        private TextBox txtDisplayName;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUsername;
        private ErrorProvider errorProvider1;
        private Label label5;
        private Label label1;
        private Label label7;
    }
}