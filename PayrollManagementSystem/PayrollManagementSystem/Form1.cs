using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollManagementSystem.DAL;
using System.Data.SqlClient;
using System.Data.Sql;
namespace PayrollManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {   /*

            int count = 0;
            Database dbconn = new Database();
            Dataquery dbquery = new Dataquery();
            SqlConnection mycon = dbconn.getConnection();
            try
            {
                mycon.Open();
 
                SqlCommand cmd = new SqlCommand(dbquery.getLogin(txtUser.Text, txtPassword.Text), mycon);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {

                    MessageBox.Show("You Succesfully Login","Succesfull Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Payroll f2 = new Payroll();
                    f2.Show();
                    this.Hide();

                }
                else if (count > 0)
                {
                    MessageBox.Show("Duplicate username or password ");
                }
                else
                {
                    MessageBox.Show("username or password not correct..");
                }
                txtUser.Clear();
                txtPassword.Clear();
                mycon.Close();
            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.StackTrace.ToString(),"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
               {
                   mycon.Close();
                 
                }
        }

      */
            Payroll f2 = new Payroll();
            f2.Show();
            this.Hide();
        }
    }
}
