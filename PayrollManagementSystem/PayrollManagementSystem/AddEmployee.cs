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
    public partial class AddEmployee : UserControl
    {
        private static AddEmployee _instance;
        public static AddEmployee Instance
        {
            

            get
            {
                if (_instance == null)
                    _instance = new AddEmployee();
                return _instance;

            }

        }
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

           // departmentcomboBox();
            //destinationComBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            char gender = '\0';
            if (RadiobtnMale.Checked == true)
            {
                gender = 'M';
            }
            else if (RadiobtnFemale.Checked == true)
            {

                gender = 'F';

            }

            Database db = new Database();
            EmployeeData dq = new EmployeeData();
            SqlConnection conn= db.getConnection();

            try
            {
                conn.Open();

                SqlCommand com = new SqlCommand(dq.insertEmployee(txtEmployeeID.Text, txtFirstName.Text, txtLastName.Text, gender,txtEmail.Text,txtContact.Text,dtpDateOfJoin.Value.ToShortDateString(),txtDesignation.SelectedText,txtAddress.Text,DateOfBirth.Value.ToShortDateString(),txtQualification.Text), conn);
                             
                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Your data inserted..!");
                }
                conn.Close();
            }
            catch (Exception exx)
            {
                string str = exx.Message;
                
                MessageBox.Show(str,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

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
        void destinationComBox()
        {
        
                   Database db = new Database();
            Dataquery dq = new Dataquery();
            SqlConnection conn = db.getConnection();
            try
            {

                conn.Open();
                SqlCommand com = new SqlCommand(dq.getDestination(), conn);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtDesignation.Items.Add(dr[0]);
                
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

