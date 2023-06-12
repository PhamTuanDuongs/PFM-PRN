namespace PFM
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnExpense = new Button();
            btnCategory = new Button();
            btnViewIncome = new Button();
            btnDashboard = new Button();
            btnviewExpense = new Button();
            btnIncome = new Button();
            btnUser = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExpense
            // 
            btnExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExpense.Image = (Image)resources.GetObject("btnExpense.Image");
            btnExpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnExpense.Location = new Point(32, 189);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(178, 46);
            btnExpense.TabIndex = 3;
            btnExpense.Text = "      Expense";
            btnExpense.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(32, 478);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(178, 46);
            btnCategory.TabIndex = 6;
            btnCategory.Text = "      Category";
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnViewIncome
            // 
            btnViewIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewIncome.Image = (Image)resources.GetObject("btnViewIncome.Image");
            btnViewIncome.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewIncome.Location = new Point(32, 280);
            btnViewIncome.Name = "btnViewIncome";
            btnViewIncome.Size = new Size(178, 46);
            btnViewIncome.TabIndex = 4;
            btnViewIncome.Text = "       View Income";
            btnViewIncome.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(30, 23);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(178, 46);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "         Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnviewExpense
            // 
            btnviewExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnviewExpense.Image = (Image)resources.GetObject("btnviewExpense.Image");
            btnviewExpense.ImageAlign = ContentAlignment.MiddleLeft;
            btnviewExpense.Location = new Point(32, 379);
            btnviewExpense.Name = "btnviewExpense";
            btnviewExpense.Size = new Size(178, 46);
            btnviewExpense.TabIndex = 5;
            btnviewExpense.Text = "      View Expense";
            btnviewExpense.UseVisualStyleBackColor = true;
            // 
            // btnIncome
            // 
            btnIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIncome.Image = (Image)resources.GetObject("btnIncome.Image");
            btnIncome.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncome.Location = new Point(32, 104);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(178, 46);
            btnIncome.TabIndex = 2;
            btnIncome.Text = "       Income";
            btnIncome.UseVisualStyleBackColor = true;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = SystemColors.ControlText;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(32, 568);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(178, 46);
            btnUser.TabIndex = 8;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(btnExpense);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnViewIncome);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnviewExpense);
            panel1.Controls.Add(btnIncome);
            panel1.Controls.Add(btnUser);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 816);
            panel1.TabIndex = 12;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(34, 758);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(176, 46);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "   Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            panelChildForm.Location = new Point(256, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1391, 813);
            panelChildForm.TabIndex = 13;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 816);
            Controls.Add(panel1);
            Controls.Add(panelChildForm);
            Name = "frmMain";
            Text = "frmMain";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnExpense;
        private Button btnCategory;
        private Button btnViewIncome;
        private Button btnDashboard;
        private Button btnviewExpense;
        private Button btnIncome;
        private Button btnUser;
        private Panel panel1;
        private Button btnLogout;
        private Panel panelChildForm;
    }
}