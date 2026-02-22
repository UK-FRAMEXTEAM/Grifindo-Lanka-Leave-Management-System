using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Lanka_Leave_Management_System
{
    public class DB_Con
    {
        public SqlConnection DB_Connection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Grifindo_Lanka_DB;Integrated Security=True;Connect Timeout=30";
            return new SqlConnection(connectionString);
        }
    }
}