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
    public partial class Allowance : UserControl
    {

        private static Allowance _instance;
        public static Allowance Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new Allowance();
                return _instance;

            }
        }
        public Allowance()
        {
            InitializeComponent();
        }

        private void Allowance_Load(object sender, EventArgs e)
        {

        }

       
    }
}
