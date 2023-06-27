namespace PFM
{
    partial class frmViewIncome
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
            dtgIncome = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            label1 = new Label();
            label2 = new Label();
            txtIncomeName = new TextBox();
            cbCategories = new ComboBox();
            label3 = new Label();
            btnViewall = new Button();
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
            btnReset = new Button();
            btnDelete = new Button();
            txtID = new TextBox();
            lblId = new Label();
            label10 = new Label();
            validate = new ErrorProvider(components);
            cbFilter = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgIncome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validate).BeginInit();
            SuspendLayout();
            // 
            // dtgIncome
            // 
            dtgIncome.BackgroundColor = SystemColors.GradientActiveCaption;
            dtgIncome.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgIncome.ColumnHeadersHeight = 29;
            dtgIncome.Location = new Point(367, 227);
            dtgIncome.Name = "dtgIncome";
            dtgIncome.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dtgIncome.RowTemplate.Height = 29;
            dtgIncome.Size = new Size(1115, 692);
            dtgIncome.TabIndex = 0;
            dtgIncome.CellClick += dtgIncome_CellClick;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(393, 113);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Income Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(719, 113);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Categories";
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(393, 141);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(223, 27);
            txtIncomeName.TabIndex = 3;
            txtIncomeName.KeyUp += txtIncomeName_KeyUp;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Items.AddRange(new object[] { "All" });
            cbCategories.Location = new Point(719, 140);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(220, 28);
            cbCategories.TabIndex = 4;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            cbCategories.Click += cbCategories_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(541, 9);
            label3.Name = "label3";
            label3.Size = new Size(146, 31);
            label3.TabIndex = 5;
            label3.Text = "View Income";
            // 
            // btnViewall
            // 
            btnViewall.Location = new Point(1004, 141);
            btnViewall.Name = "btnViewall";
            btnViewall.Size = new Size(98, 28);
            btnViewall.TabIndex = 6;
            btnViewall.Text = "View all income";
            btnViewall.UseVisualStyleBackColor = true;
            btnViewall.Click += btnViewall_Click;
            // 
            // nmAmount
            // 
            nmAmount.Location = new Point(12, 559);
            nmAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmAmount.Name = "nmAmount";
            nmAmount.Size = new Size(214, 27);
            nmAmount.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 446);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 37;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 528);
            label5.Name = "label5";
            label5.Size = new Size(83, 28);
            label5.TabIndex = 36;
            label5.Text = "Amount";
            // 
            // dtCreated
            // 
            dtCreated.Location = new Point(12, 398);
            dtCreated.Name = "dtCreated";
            dtCreated.Size = new Size(261, 27);
            dtCreated.TabIndex = 35;
            dtCreated.Validating += dtCreated_Validating;
            // 
            // cbCategoryUpdate
            // 
            cbCategoryUpdate.FormattingEnabled = true;
            cbCategoryUpdate.Location = new Point(16, 477);
            cbCategoryUpdate.Name = "cbCategoryUpdate";
            cbCategoryUpdate.Size = new Size(227, 28);
            cbCategoryUpdate.TabIndex = 34;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 638);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(261, 174);
            txtDescription.TabIndex = 33;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 297);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 27);
            txtName.TabIndex = 32;
            txtName.Validating += txtName_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 607);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 31;
            label6.Text = "Description";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(12, 882);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(104, 37);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 348);
            label7.Name = "label7";
            label7.Size = new Size(53, 28);
            label7.TabIndex = 29;
            label7.Text = "Date";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Orange;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(257, 882);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(104, 37);
            btnReset.TabIndex = 39;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(135, 882);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 37);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 227);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(223, 27);
            txtID.TabIndex = 42;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblId.Location = new Point(12, 196);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 28);
            lblId.TabIndex = 41;
            lblId.Text = "Id";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 266);
            label10.Name = "label10";
            label10.Size = new Size(64, 28);
            label10.TabIndex = 28;
            label10.Text = "Name";
            // 
            // validate
            // 
            validate.ContainerControl = this;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(1166, 142);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(129, 28);
            cbFilter.TabIndex = 43;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // frmViewIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 920);
            Controls.Add(cbFilter);
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
            Controls.Add(label10);
            Controls.Add(btnViewall);
            Controls.Add(label3);
            Controls.Add(cbCategories);
            Controls.Add(txtIncomeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgIncome);
            Name = "frmViewIncome";
            ShowInTaskbar = false;
            Text = "frmViewIncome";
            Load += frmViewIncome_Load;
            ((System.ComponentModel.ISupportInitialize)dtgIncome).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgIncome;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Label label1;
        private Label label2;
        private TextBox txtIncomeName;
        private ComboBox cbCategories;
        private Label label3;
        private Button btnViewall;
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
        private Label label8;
        private Button btnReset;
        private Button btnDelete;
        private TextBox txtID;
        private Label lblId;
        private Label label10;
        private ErrorProvider validate;
        private ComboBox cbFilter;
    }
}