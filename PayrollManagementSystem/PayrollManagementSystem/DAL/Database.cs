using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
namespace PayrollManagementSystem.DAL
{
    class Database
    {

        public  SqlConnection getConnection()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=NATESH;Initial Catalog=Payroll;Integrated Security=True";
            return conn;
        }
    }
}
