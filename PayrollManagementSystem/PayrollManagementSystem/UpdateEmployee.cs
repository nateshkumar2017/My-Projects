using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollManagementSystem.DAL;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PayrollManagementSystem
{
    public partial class UpdateEmployee : UserControl
    {
        private static UpdateEmployee _instance;
        public static UpdateEmployee Instance
        {


            get
            {
                if (_instance == null)
                    _instance = new UpdateEmployee();
                return _instance;

            }

        }
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

            //display();
            //departmentcomboBox();
        }
        void display()
        {

            EmployeeData emp = new EmployeeData();
            Database db = new Database();
            SqlConnection con = db.getConnection();
            try
            {

                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(emp.getAllEmployees(), con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

            }

            catch (Exception exx)
            {

                string str = exx.Message;
                MessageBox.Show(str, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {


            EmployeeID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtContact.Text= dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtDesignation.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtQualification.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*
                 Database db = new Database();
            EmployeeData dq = new EmployeeData();
            SqlConnection conn= db.getConnection();

            try
            {
                conn.Open();



                SqlCommand com = new SqlCommand(dq.updateEmployee(EmployeeID.Text,txtFirstName.Text, txtLastName.Text, txtEmail.Text,txtContact.Text,txtDesignation.Text,txtAddress.Text,txtQualification.Text), conn);
              
                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Your data Update Succesfully..!");
                }
                conn.Close();
            }
            catch (Exception exx)
            {
                string str = exx.Message;
                
                MessageBox.Show(str,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        */
        }
        void departmentcomboBox()
        {

            Database db = new Database();
            Dataquery dq = new Dataquery();
            SqlConnection conn = db.getConnection();
            try
            {

                conn.Open();
                SqlCommand com = new SqlCommand(dq.getDepartments(), conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmbxDepartement.Items.Add(dr[0]);
                }
                conn.Close();
            }
            catch (Exception exx)
            {


                MessageBox.Show(exx.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
