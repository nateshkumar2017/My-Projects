using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    public partial class Payroll : Form
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payroll Management System is Design & Develop my Natesh Kumar & Athaul Rai","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can contact with this email : natesh.fast13@gmail.com","Help",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            mainpanel.Visible = true;
            Allowance.Instance.Visible = false;
            Attendence.Instance.Visible = false;
            Deduction.Instance.Visible = false;
            Employee.Instance.Visible = false;
            Reports.Instance.Visible = false;
            Salary.Instance.Visible = false;
            
            if (!mainpanel.Controls.Contains(Home.Instance))
            {

                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.BringToFront();

            }
            else
                Home.Instance.BringToFront();
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
     
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
           
        }

        private void Payroll_Load(object sender, EventArgs e)
        {


            if (!mainpanel.Controls.Contains(Home.Instance))
            {

                mainpanel.Controls.Add(Home.Instance);
                Home.Instance.BringToFront();

            }
            else
                Home.Instance.BringToFront();
        }

        private void Payroll_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

    }
}
