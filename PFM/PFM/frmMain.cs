using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PFM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            panel1.BackColor = ColorTranslator.FromHtml(ManageColor.hexColor6); ;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProfile());

        }

        private Form ActiveForm = null;


        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmIncome());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmDashboard());
        }

        private void btnViewIncome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewIncome());
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExpense());
        }

        private void btnviewExpense_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewExpense());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCategory());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }
    }
}
