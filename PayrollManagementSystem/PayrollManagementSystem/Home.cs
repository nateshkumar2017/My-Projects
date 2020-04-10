using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem
{
    public partial class Home : UserControl
    {
        private static Home _instance;
        public static Home Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new Home();
                return _instance;

            }

        }
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee.Instance.Visible = true;
            if (!mainpanel.Controls.Contains(Employee.Instance))
            {

                mainpanel.Controls.Add(Employee.Instance);
                Employee.Instance.BringToFront();

            }
            else
                Employee.Instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Allowance.Instance.Visible = true;
            if (!mainpanel.Controls.Contains(Allowance.Instance))
            {

                mainpanel.Controls.Add(Allowance.Instance);
                Allowance.Instance.BringToFront();

            }
            else
                Allowance.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendence.Instance.Visible = true;
            if (!mainpanel.Controls.Contains(Attendence.Instance))
            {

                mainpanel.Controls.Add(Attendence.Instance);
                Attendence.Instance.BringToFront();

            }
            else
                Attendence.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary.Instance.Visible = true;
            if (!mainpanel.Controls.Contains(Salary.Instance))
            {

                mainpanel.Controls.Add(Salary.Instance);
                Salary.Instance.BringToFront();

            }
            else
                Salary.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deduction.Instance.Visible = true;
            if (!mainpanel.Controls.Contains(Deduction.Instance))
            {

                mainpanel.Controls.Add(Deduction.Instance);
                Deduction.Instance.BringToFront();

            }
            else
                Deduction.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports.Instance.Visible = true;
            if (!mainpanel.Controls.Contains(Reports.Instance))
            {

                mainpanel.Controls.Add(Reports.Instance);
                Reports.Instance.BringToFront();

            }
            else
                Reports.Instance.BringToFront();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
