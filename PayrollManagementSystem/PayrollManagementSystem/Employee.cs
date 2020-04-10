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
    public partial class Employee : UserControl
    {
        private static Employee _instance;
        public static Employee Instance
        {

            get
            {
                if (_instance == null)
                    _instance = new Employee();
                return _instance;

            }

        }
        public Employee()
        {
            InitializeComponent();

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!employeepanel.Controls.Contains(AddEmployee.Instance))
            {

                employeepanel.Controls.Add(AddEmployee.Instance);
                AddEmployee.Instance.BringToFront();

            }
            else
                AddEmployee.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!employeepanel.Controls.Contains(SearchEmployee.Instance))
            {

                employeepanel.Controls.Add(SearchEmployee.Instance);
                SearchEmployee.Instance.BringToFront();

            }
            else
               SearchEmployee.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!employeepanel.Controls.Contains(UpdateEmployee.Instance))
            {

                employeepanel.Controls.Add(UpdateEmployee.Instance);
                UpdateEmployee.Instance.BringToFront();

            }
            else
                UpdateEmployee.Instance.BringToFront();
        }
    }
}
