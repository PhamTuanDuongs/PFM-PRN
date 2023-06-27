namespace PFM
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            btnClearFields = new Button();
            btnSignIn = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(485, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(67, 24);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(64, 64, 64);
            linkLabel1.Location = new Point(205, 340);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(226, 20);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don’t have any account? Sign Up";
            linkLabel1.Click += linkLabel1_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new Point(378, 212);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(101, 25);
            btnClearFields.TabIndex = 23;
            btnClearFields.Text = "Clear fields";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignIn.Location = new Point(260, 269);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(142, 47);
            btnSignIn.TabIndex = 22;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 165);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 21;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 104);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 20;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 166);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(291, 27);
            txtPassword.TabIndex = 19;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(188, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 27);
            txtUsername.TabIndex = 18;
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
            label7.Location = new Point(127, 112);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 29;
            label7.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(127, 170);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 30;
            label3.Text = "*";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 464);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(linkLabel1);
            Controls.Add(btnClearFields);
            Controls.Add(btnSignIn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button btnClearFields;
        private Button btnSignIn;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private ErrorProvider errorProvider1;
        private Label label3;
        private Label label7;
    }
}