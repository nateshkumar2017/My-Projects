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
    public partial class Salary : UserControl
    {
        private static Salary _instance;
        public static Salary Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new Salary();
                return _instance;

            }

        }
        public Salary()
        {
            InitializeComponent();
        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void Salary_Load_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
