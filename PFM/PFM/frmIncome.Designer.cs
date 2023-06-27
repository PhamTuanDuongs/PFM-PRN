namespace PFM
{
    partial class frmIncome
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
            dtCreated = new DateTimePicker();
            cbCategory = new ComboBox();
            label6 = new Label();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            label4 = new Label();
            label1 = new Label();
            validate = new ErrorProvider(components);
            lblIncome = new Label();
            label2 = new Label();
            label3 = new Label();
            nmAmount = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)validate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmAmount).BeginInit();
            SuspendLayout();
            // 
            // dtCreated
            // 
            dtCreated.Location = new Point(765, 178);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(261, 27);
            dtCreated.TabIndex = 23;
            dtCreated.Validating += dtCreated_Validating;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(765, 266);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(227, 28);
            cbCategory.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(128, 131);
            label6.Name = "label6";
            label6.Size = new Size(174, 38);
            label6.TabIndex = 21;
            label6.Text = "Total Income";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(437, 369);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(223, 104);
            txtDescription.TabIndex = 20;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(437, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 27);
            txtName.TabIndex = 18;
            txtName.Validating += txtName_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(437, 319);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 17;
            label5.Text = "Description";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(437, 514);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 54);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(765, 138);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 15;
            label4.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(437, 138);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 14;
            label1.Text = "Income Name";
            // 
            // validate
            // 
            validate.ContainerControl = this;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(140, 226);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(50, 20);
            lblIncome.TabIndex = 24;
            lblIncome.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(437, 235);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 25;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(765, 235);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 26;
            label3.Text = "Category";
            // 
            // nmAmount
            // 
            nmAmount.Location = new Point(446, 267);
            nmAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmAmount.Name = "nmAmount";
            nmAmount.Size = new Size(214, 27);
            nmAmount.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(565, 146);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 28;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(813, 145);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 29;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(514, 244);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 30;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(851, 244);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 31;
            label10.Text = "*";
            // 
            // frmIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 621);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(nmAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIncome);
            Controls.Add(dtCreated);
            Controls.Add(cbCategory);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmIncome";
            Text = "frmIncome";
            Load += frmIncome_Load;
            ((System.ComponentModel.ISupportInitialize)validate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtCreated;
        private ComboBox cbCategory;
        private Label label6;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label5;
        private Button btnAdd;
        private Label label4;
        private Label label1;
        private ErrorProvider validate;
        private Label lblIncome;
        private Label label3;
        private Label label2;
        private NumericUpDown nmAmount;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}