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
            txtAmount = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            label4 = new Label();
            label1 = new Label();
            validate = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)validate).BeginInit();
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
            label6.Location = new Point(140, 138);
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
            // txtAmount
            // 
            txtAmount.Location = new Point(437, 266);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(223, 27);
            txtAmount.TabIndex = 19;
            txtAmount.Validating += txtAmount_Validating;
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
            btnAdd.Location = new Point(637, 497);
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
            // frmIncome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 621);
            Controls.Add(dtCreated);
            Controls.Add(cbCategory);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmIncome";
            Text = "frmIncome";
            Load += frmIncome_Load;
            ((System.ComponentModel.ISupportInitialize)validate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtCreated;
        private ComboBox cbCategory;
        private Label label6;
        private TextBox txtDescription;
        private TextBox txtAmount;
        private TextBox txtName;
        private Label label5;
        private Button btnAdd;
        private Label label4;
        private Label label1;
        private ErrorProvider validate;
    }
}