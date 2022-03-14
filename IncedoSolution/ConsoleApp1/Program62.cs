using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program62
    {
        static void Main(string[] args)
        {
            string cs = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=IncedoEmployeeDB";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string query = "insert into tblEmployees values (@id,@ename,@job,@salary)";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", 11);
            cmd.Parameters.AddWithValue("@ename", "Rajesh");
            cmd.Parameters.AddWithValue("@job", "Developer");
            cmd.Parameters.AddWithValue("@salary", 2500);

            int count = cmd.ExecuteNonQuery(); //to issue any command other than select
            Console.WriteLine($"{count} rows added successfully");
        }
    }
}
