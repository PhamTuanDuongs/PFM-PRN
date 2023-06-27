namespace PFM
{
    partial class frmViewExpense
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
            btnViewall = new Button();
            cbCategories = new ComboBox();
            txtExpenseName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtgExpense = new DataGridView();
            txtID = new TextBox();
            lblId = new Label();
            btnDelete = new Button();
            btnReset = new Button();
            nmAmount = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            dtCreated = new DateTimePicker();
            cbCategoryUpdate = new ComboBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            label7 = new Label();
            label3 = new Label();
            validate = new ErrorProvider(components);
            label8 = new Label();
            cbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgExpense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validate).BeginInit();
            SuspendLayout();
            // 
            // btnViewall
            // 
            btnViewall.Location = new Point(1050, 127);
            btnViewall.Name = "btnViewall";
            btnViewall.Size = new Size(98, 37);
            btnViewall.TabIndex = 12;
            btnViewall.Text = "View all income";
            btnViewall.UseVisualStyleBackColor = true;
            btnViewall.Click += btnViewall_Click;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Items.AddRange(new object[] { "All" });
            cbCategories.Location = new Point(751, 132);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(220, 28);
            cbCategories.TabIndex = 11;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            cbCategories.Click += cbCategories_Click;
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(373, 133);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(223, 27);
            txtExpenseName.TabIndex = 10;
            txtExpenseName.KeyUp += txtExpense_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(751, 101);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 9;
            label2.Text = "Categories";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(373, 105);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 8;
            label1.Text = "Expense Name";
            // 
            // dtgExpense
            // 
            dtgExpense.BackgroundColor = SystemColors.GradientActiveCaption;
            dtgExpense.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgExpense.ColumnHeadersHeight = 29;
            dtgExpense.Location = new Point(364, 239);
            dtgExpense.Name = "dtgExpense";
            dtgExpense.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dtgExpense.RowTemplate.Height = 29;
            dtgExpense.Size = new Size(1110, 668);
            dtgExpense.TabIndex = 7;
            dtgExpense.CellClick += dtgExpense_CellClick;
            // 
            // txtID
            // 
            txtID.Location = new Point(22, 127);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(223, 27);
            txtID.TabIndex = 56;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(21, 96);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 28);
            lblId.TabIndex = 55;
            lblId.Text = "Id";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(132, 820);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 37);
            btnDelete.TabIndex = 54;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Orange;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(254, 820);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 37);
            btnReset.TabIndex = 53;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // nmAmount
            // 
            nmAmount.Location = new Point(22, 289);
            nmAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmAmount.Name = "nmAmount";
            nmAmount.Size = new Size(214, 27);
            nmAmount.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 352);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 51;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 258);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 50;
            label5.Text = "Amount";
            // 
            // dtCreated
            // 
            dtCreated.Location = new Point(15, 488);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(261, 27);
            dtCreated.TabIndex = 49;
            dtCreated.Validating += dtCreated_Validating;
            // 
            // cbCategoryUpdate
            // 
            cbCategoryUpdate.FormattingEnabled = true;
            cbCategoryUpdate.Location = new Point(15, 383);
            cbCategoryUpdate.Name = "cbCategoryUpdate";
            cbCategoryUpdate.Size = new Size(227, 28);
            cbCategoryUpdate.TabIndex = 48;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(15, 624);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(261, 155);
            txtDescription.TabIndex = 47;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(22, 199);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 27);
            txtName.TabIndex = 46;
            txtName.Validating += txtName_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 570);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 45;
            label6.Text = "Description";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(0, 820);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 37);
            btnUpdate.TabIndex = 44;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 457);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 43;
            label7.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 168);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 57;
            label3.Text = "Name";
            // 
            // validate
            // 
            validate.ContainerControl = this;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(533, 9);
            label8.Name = "label8";
            label8.Size = new Size(199, 41);
            label8.TabIndex = 58;
            label8.Text = "View Expense";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(1209, 132);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(129, 28);
            cbFilter.TabIndex = 59;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // frmViewExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 919);
            Controls.Add(cbFilter);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(lblId);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(nmAmount);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dtCreated);
            Controls.Add(cbCategoryUpdate);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(label7);
            Controls.Add(btnViewall);
            Controls.Add(cbCategories);
            Controls.Add(txtExpenseName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgExpense);
            Name = "frmViewExpense";
            Text = "frmViewExpense";
            Load += frmViewExpense_Load;
            ((System.ComponentModel.ISupportInitialize)dtgExpense).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewall;
        private ComboBox cbCategories;
        private TextBox txtExpenseName;
        private Label label2;
        private Label label1;
        private DataGridView dtgExpense;
        private TextBox txtID;
        private Label lblId;
        private Button btnDelete;
        private Button btnReset;
        private NumericUpDown nmAmount;
        private Label label4;
        private Label label5;
        private DateTimePicker dtCreated;
        private ComboBox cbCategoryUpdate;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label6;
        private Button btnUpdate;
        private Label label7;
        private Label label3;
        private ErrorProvider validate;
        private Label label8;
        private ComboBox cbFilter;
    }
}