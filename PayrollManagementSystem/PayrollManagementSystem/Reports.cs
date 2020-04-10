using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CrystalDecisions.CrystalReports.Engine;
namespace PayrollManagementSystem
{
    public partial class Reports : UserControl
    {
        private static Reports _instance;
        public static Reports Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new Reports();
                return _instance;

            }

        }
        public Reports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
