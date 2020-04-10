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
    public partial class Deduction : UserControl
    {
        private static Deduction _instance;
        public static Deduction Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new Deduction();
                return _instance;

            }

        }
        public Deduction()
        {
            InitializeComponent();
        }

        private void Deduction_Load(object sender, EventArgs e)
        {

        }
    }
}
