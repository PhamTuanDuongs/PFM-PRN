namespace PFM
{
    partial class frmExpense
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
            nmAmount = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            lbltotalExpense = new Label();
            dtCreated = new DateTimePicker();
            cbCategory = new ComboBox();
            lblExpense = new Label();
            txtDescription = new TextBox();
            txtExpense = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            txtDate = new Label();
            label1 = new Label();
            label4 = new Label();
            validate = new ErrorProvider(components);
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validate).BeginInit();
            SuspendLayout();
            // 
            // nmAmount
            // 
            nmAmount.Location = new Point(570, 315);
            nmAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmAmount.Name = "nmAmount";
            nmAmount.Size = new Size(214, 27);
            nmAmount.TabIndex = 40;
            nmAmount.ThousandsSeparator = true;
            nmAmount.Validating += nmAmount_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(889, 283);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 39;
            label3.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(561, 283);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 38;
            label2.Text = "Amount";
            // 
            // lbltotalExpense
            // 
            lbltotalExpense.AutoSize = true;
            lbltotalExpense.Location = new Point(305, 283);
            lbltotalExpense.Name = "lbltotalExpense";
            lbltotalExpense.Size = new Size(50, 20);
            lbltotalExpense.TabIndex = 37;
            lbltotalExpense.Text = "label2";
            // 
            // dtCreated
            // 
            dtCreated.Location = new Point(889, 226);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(261, 27);
            dtCreated.TabIndex = 36;
            dtCreated.Validating += dtCreated_Validating;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(889, 314);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(227, 28);
            cbCategory.TabIndex = 35;
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpense.ForeColor = Color.CornflowerBlue;
            lblExpense.Location = new Point(252, 179);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(184, 38);
            lblExpense.TabIndex = 34;
            lblExpense.Text = "Total Expense";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(561, 417);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 104);
            txtDescription.TabIndex = 33;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // txtExpense
            // 
            txtExpense.Location = new Point(561, 226);
            txtExpense.Name = "txtExpense";
            txtExpense.Size = new Size(223, 27);
            txtExpense.TabIndex = 32;
            txtExpense.Validating += txtExpense_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(561, 367);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 31;
            label5.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(561, 562);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 54);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDate
            // 
            txtDate.AutoSize = true;
            txtDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(889, 186);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(53, 28);
            txtDate.TabIndex = 29;
            txtDate.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(561, 186);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 28;
            label1.Text = "Expense Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(609, 59);
            label4.Name = "label4";
            label4.Size = new Size(196, 41);
            label4.TabIndex = 41;
            label4.Text = "Add Expense";
            // 
            // validate
            // 
            validate.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(696, 197);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 42;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(638, 291);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 43;
            label6.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(936, 197);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 44;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(975, 291);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 45;
            label9.Text = "*";
            // 
            // frmExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 705);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(nmAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbltotalExpense);
            Controls.Add(dtCreated);
            Controls.Add(cbCategory);
            Controls.Add(lblExpense);
            Controls.Add(txtDescription);
            Controls.Add(txtExpense);
            Controls.Add(label5);
            Controls.Add(btnAdd);
            Controls.Add(txtDate);
            Controls.Add(label1);
            Name = "frmExpense";
            Text = "frmExpense";
            Load += frmExpense_Load;
            ((System.ComponentModel.ISupportInitialize)nmAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nmAmount;
        private Label label3;
        private Label label2;
        private Label lbltotalExpense;
        private DateTimePicker dtCreated;
        private ComboBox cbCategory;
        private Label lblExpense;
        private TextBox txtDescription;
        private TextBox txtExpense;
        private Label label5;
        private Button btnAdd;
        private Label txtDate;
        private Label label1;
        private Label label4;
        private ErrorProvider validate;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label7;
    }
}