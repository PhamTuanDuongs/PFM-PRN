namespace PFM
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            panel1 = new Panel();
            label7 = new Label();
            lblTransactionsIncomeToday = new Label();
            lblTransactionIncome = new Label();
            lblRs = new Label();
            lblITotalncome = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            lblTransactionsExpenseToday = new Label();
            lblTransactionExpense = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            lblTotalExpense = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            label6 = new Label();
            lblMaxIncome = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblLastIncome = new Label();
            label9 = new Label();
            panel5 = new Panel();
            lblMaxExpense = new Label();
            label11 = new Label();
            label12 = new Label();
            panel6 = new Panel();
            lblLastExpense = new Label();
            label15 = new Label();
            panel7 = new Panel();
            lblMinimumIncome = new Label();
            label17 = new Label();
            label18 = new Label();
            panel9 = new Panel();
            lblMinimumExpense = new Label();
            label23 = new Label();
            label24 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblTransactionsIncomeToday);
            panel1.Controls.Add(lblTransactionIncome);
            panel1.Controls.Add(lblRs);
            panel1.Controls.Add(lblITotalncome);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(244, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 270);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 232);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 7;
            label7.Text = "Today:";
            // 
            // lblTransactionsIncomeToday
            // 
            lblTransactionsIncomeToday.AutoSize = true;
            lblTransactionsIncomeToday.Location = new Point(72, 232);
            lblTransactionsIncomeToday.Name = "lblTransactionsIncomeToday";
            lblTransactionsIncomeToday.Size = new Size(50, 20);
            lblTransactionsIncomeToday.TabIndex = 6;
            lblTransactionsIncomeToday.Text = "label7";
            // 
            // lblTransactionIncome
            // 
            lblTransactionIncome.AutoSize = true;
            lblTransactionIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransactionIncome.Location = new Point(14, 135);
            lblTransactionIncome.Name = "lblTransactionIncome";
            lblTransactionIncome.Size = new Size(127, 28);
            lblTransactionIncome.TabIndex = 5;
            lblTransactionIncome.Text = "Transactions :";
            // 
            // lblRs
            // 
            lblRs.AutoSize = true;
            lblRs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRs.Location = new Point(14, 60);
            lblRs.Name = "lblRs";
            lblRs.Size = new Size(32, 28);
            lblRs.TabIndex = 4;
            lblRs.Text = "Rs";
            // 
            // lblITotalncome
            // 
            lblITotalncome.AutoSize = true;
            lblITotalncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblITotalncome.Location = new Point(58, 60);
            lblITotalncome.Name = "lblITotalncome";
            lblITotalncome.Size = new Size(67, 28);
            lblITotalncome.TabIndex = 1;
            lblITotalncome.Text = "10000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 11);
            label1.Name = "label1";
            label1.Size = new Size(152, 31);
            label1.TabIndex = 0;
            label1.Text = "Total Income";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(244, 18);
            label2.Name = "label2";
            label2.Size = new Size(391, 41);
            label2.TabIndex = 1;
            label2.Text = "Personal Finance DashBoard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumAquamarine;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblTransactionsExpenseToday);
            panel2.Controls.Add(lblTransactionExpense);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblTotalExpense);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(244, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 273);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 215);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 8;
            label8.Text = "Today:";
            // 
            // lblTransactionsExpenseToday
            // 
            lblTransactionsExpenseToday.AutoSize = true;
            lblTransactionsExpenseToday.Location = new Point(72, 215);
            lblTransactionsExpenseToday.Name = "lblTransactionsExpenseToday";
            lblTransactionsExpenseToday.Size = new Size(50, 20);
            lblTransactionsExpenseToday.TabIndex = 7;
            lblTransactionsExpenseToday.Text = "label7";
            // 
            // lblTransactionExpense
            // 
            lblTransactionExpense.AutoSize = true;
            lblTransactionExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransactionExpense.Location = new Point(14, 120);
            lblTransactionExpense.Name = "lblTransactionExpense";
            lblTransactionExpense.Size = new Size(127, 28);
            lblTransactionExpense.TabIndex = 6;
            lblTransactionExpense.Text = "Transactions :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 64);
            label5.Name = "label5";
            label5.Size = new Size(32, 28);
            label5.TabIndex = 5;
            label5.Text = "Rs";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(256, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(239, 273);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalExpense.Location = new Point(67, 64);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(67, 28);
            lblTotalExpense.TabIndex = 1;
            lblTotalExpense.Text = "10000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 11);
            label4.Name = "label4";
            label4.Size = new Size(160, 31);
            label4.TabIndex = 0;
            label4.Text = "Total Expense";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 14);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 8;
            label3.Text = "Maximum Income";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 60);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 9;
            label6.Text = "Rs: ";
            // 
            // lblMaxIncome
            // 
            lblMaxIncome.AutoSize = true;
            lblMaxIncome.Location = new Point(82, 60);
            lblMaxIncome.Name = "lblMaxIncome";
            lblMaxIncome.Size = new Size(41, 20);
            lblMaxIncome.TabIndex = 10;
            lblMaxIncome.Text = "1000";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.Controls.Add(lblMaxIncome);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(897, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 112);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(lblLastIncome);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(1209, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 112);
            panel4.TabIndex = 11;
            // 
            // lblLastIncome
            // 
            lblLastIncome.AutoSize = true;
            lblLastIncome.Location = new Point(51, 68);
            lblLastIncome.Name = "lblLastIncome";
            lblLastIncome.Size = new Size(41, 20);
            lblLastIncome.TabIndex = 10;
            lblLastIncome.Text = "1000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(82, 11);
            label9.Name = "label9";
            label9.Size = new Size(115, 28);
            label9.TabIndex = 8;
            label9.Text = "Last Income";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lavender;
            panel5.Controls.Add(lblMaxExpense);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(897, 244);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 105);
            panel5.TabIndex = 12;
            // 
            // lblMaxExpense
            // 
            lblMaxExpense.AutoSize = true;
            lblMaxExpense.Location = new Point(82, 60);
            lblMaxExpense.Name = "lblMaxExpense";
            lblMaxExpense.Size = new Size(41, 20);
            lblMaxExpense.TabIndex = 10;
            lblMaxExpense.Text = "1000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 60);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 9;
            label11.Text = "Rs: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(46, 18);
            label12.Name = "label12";
            label12.Size = new Size(174, 28);
            label12.TabIndex = 8;
            label12.Text = "Maximum Expense";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightBlue;
            panel6.Controls.Add(lblLastExpense);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(1209, 244);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 102);
            panel6.TabIndex = 12;
            // 
            // lblLastExpense
            // 
            lblLastExpense.AutoSize = true;
            lblLastExpense.Location = new Point(51, 60);
            lblLastExpense.Name = "lblLastExpense";
            lblLastExpense.Size = new Size(41, 20);
            lblLastExpense.TabIndex = 10;
            lblLastExpense.Text = "1000";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(76, 18);
            label15.Name = "label15";
            label15.Size = new Size(121, 28);
            label15.TabIndex = 8;
            label15.Text = "Last Expense";
            // 
            // panel7
            // 
            panel7.BackColor = Color.NavajoWhite;
            panel7.Controls.Add(lblMinimumIncome);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label18);
            panel7.Location = new Point(897, 453);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 125);
            panel7.TabIndex = 13;
            // 
            // lblMinimumIncome
            // 
            lblMinimumIncome.AutoSize = true;
            lblMinimumIncome.Location = new Point(82, 48);
            lblMinimumIncome.Name = "lblMinimumIncome";
            lblMinimumIncome.Size = new Size(41, 20);
            lblMinimumIncome.TabIndex = 10;
            lblMinimumIncome.Text = "1000";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 48);
            label17.Name = "label17";
            label17.Size = new Size(31, 20);
            label17.TabIndex = 9;
            label17.Text = "Rs: ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(55, 11);
            label18.Name = "label18";
            label18.Size = new Size(165, 28);
            label18.TabIndex = 8;
            label18.Text = "Minimum Income";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightBlue;
            panel9.Controls.Add(lblMinimumExpense);
            panel9.Controls.Add(label23);
            panel9.Controls.Add(label24);
            panel9.Location = new Point(1209, 453);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 125);
            panel9.TabIndex = 12;
            // 
            // lblMinimumExpense
            // 
            lblMinimumExpense.AutoSize = true;
            lblMinimumExpense.Location = new Point(82, 48);
            lblMinimumExpense.Name = "lblMinimumExpense";
            lblMinimumExpense.Size = new Size(41, 20);
            lblMinimumExpense.TabIndex = 10;
            lblMinimumExpense.Text = "1000";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(32, 48);
            label23.Name = "label23";
            label23.Size = new Size(31, 20);
            label23.TabIndex = 9;
            label23.Text = "Rs: ";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(43, 18);
            label24.Name = "label24";
            label24.Size = new Size(171, 28);
            label24.TabIndex = 8;
            label24.Text = "Minimum Expense";
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 759);
            Controls.Add(panel9);
            Controls.Add(pictureBox1);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmDashboard";
            Text = "frmDashboard";
            Load += frmDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblITotalncome;
        private Panel panel2;
        private Label lblTotalExpense;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblRs;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label lblMaxIncome;
        private Panel panel3;
        private Panel panel4;
        private Label lblLastIncome;
        private Label label9;
        private Panel panel5;
        private Label lblMaxExpense;
        private Label label11;
        private Label label12;
        private Panel panel6;
        private Label lblLastExpense;
        private Label label15;
        private Panel panel7;
        private Label lblMinimumIncome;
        private Label label17;
        private Label label18;
        private Panel panel9;
        private Label lblMinimumExpense;
        private Label label23;
        private Label label24;
        private Label lblTransactionIncome;
        private Label lblTransactionExpense;
        private Label lblTransactionsIncomeToday;
        private Label lblTransactionsExpenseToday;
        private Label label7;
        private Label label8;
    }
}