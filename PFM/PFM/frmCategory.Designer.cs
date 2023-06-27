namespace PFM
{
    partial class frmCategory
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
            rdExpense = new RadioButton();
            rdIncome = new RadioButton();
            label1 = new Label();
            dtCategory = new DataGridView();
            btnAdd = new Button();
            label2 = new Label();
            txtCategoryName = new TextBox();
            button1 = new Button();
            btnDelete = new Button();
            validate = new ErrorProvider(components);
            label3 = new Label();
            txtId = new TextBox();
            label7 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validate).BeginInit();
            SuspendLayout();
            // 
            // rdExpense
            // 
            rdExpense.AutoSize = true;
            rdExpense.Checked = true;
            rdExpense.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdExpense.Location = new Point(577, 171);
            rdExpense.Name = "rdExpense";
            rdExpense.Size = new Size(103, 32);
            rdExpense.TabIndex = 0;
            rdExpense.TabStop = true;
            rdExpense.Text = "Expense";
            rdExpense.UseVisualStyleBackColor = true;
            rdExpense.CheckedChanged += rdExpense_CheckedChanged;
            // 
            // rdIncome
            // 
            rdIncome.AutoSize = true;
            rdIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdIncome.Location = new Point(1098, 171);
            rdIncome.Name = "rdIncome";
            rdIncome.Size = new Size(97, 32);
            rdIncome.TabIndex = 1;
            rdIncome.Text = "Income";
            rdIncome.UseVisualStyleBackColor = true;
            rdIncome.CheckedChanged += rdIncome_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(605, 35);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 2;
            label1.Text = "Category";
            // 
            // dtCategory
            // 
            dtCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCategory.Location = new Point(577, 228);
            dtCategory.Name = "dtCategory";
            dtCategory.RowHeadersWidth = 51;
            dtCategory.RowTemplate.Height = 29;
            dtCategory.Size = new Size(904, 485);
            dtCategory.TabIndex = 3;
            dtCategory.CellClick += dtCategory_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(16, 461);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 316);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(178, 320);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(256, 27);
            txtCategoryName.TabIndex = 6;
            txtCategoryName.Validating += txtCategoryName_Validating;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(210, 461);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 9;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(383, 461);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // validate
            // 
            validate.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 250);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(186, 254);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(248, 27);
            txtId.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(94, 257);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 30;
            label7.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(120, 327);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 31;
            label4.Text = "*";
            // 
            // frmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 712);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtCategoryName);
            Controls.Add(dtCategory);
            Controls.Add(label1);
            Controls.Add(rdIncome);
            Controls.Add(rdExpense);
            Name = "frmCategory";
            Text = "Category";
            Load += frmViewCategory_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdExpense;
        private RadioButton rdIncome;
        private Label label1;
        private DataGridView dtCategory;
        private Button btnAdd;
        private Label label2;
        private TextBox txtCategoryName;
        private Button button1;
        private Button btnDelete;
        private ErrorProvider validate;
        private Label label3;
        private TextBox txtId;
        private Label label4;
        private Label label7;
    }
}