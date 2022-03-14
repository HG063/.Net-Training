using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program64
    {
        static void Main(string[] args)
        {
            string cs = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=IncedoEmployeeDB";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();

            string query = "delete from tblEmployees where id=@id";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", 11);

            int count = cmd.ExecuteNonQuery(); //to issue any command other than select
            Console.WriteLine($"{count} rows deleted successfully...");
        }
    }
}
