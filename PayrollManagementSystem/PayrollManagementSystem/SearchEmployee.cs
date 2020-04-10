using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using PayrollManagementSystem.DAL;
namespace PayrollManagementSystem
{
    public partial class SearchEmployee : UserControl
    {
        private static SearchEmployee _instance;
        public static SearchEmployee Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new SearchEmployee();
                return _instance;

            }

        }
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*string query="";
            EmployeeData emp = new EmployeeData();
            if (cmbxSearch.SelectedIndex == 0)
            {

                query = emp.getEmployeByid(Convert.ToInt32(txtSearch.Text));
            }
            else if (cmbxSearch.SelectedIndex == 1)
            {

                query = emp.getEmloyeeByName(txtSearch.Text);
            }
            else if (cmbxSearch.SelectedIndex == 2)
            {

                query = emp.getAllEmployees();
            }

            Database db = new Database();
            SqlConnection con= db.getConnection();
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception exx)
            {

                string str = exx.Message;

                MessageBox.Show(str, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
