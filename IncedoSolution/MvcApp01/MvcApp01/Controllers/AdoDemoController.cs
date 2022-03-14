using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MvcApp01.Controllers
{
    public class AdoDemoController : Controller
    {
        string cs = string.Empty;
        SqlConnection cn = null;
        public SqlConnection ConnectToSql()
        {
            string cs = "server=G1-443HZH3-L\\SQLEXPRESS; integrated security=true; database=IncedoEmployeeDB";
            cn = new SqlConnection(cs);
            cn.Open();
            return cn;
        }
        [HttpGet]
        public IActionResult Index()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id, string ename, string job, int salary, string b1)
        {
            string query = string.Empty;
            switch (b1)
            {
                case "Retrieve":
                    query = "Select * from tblEmployees where id=@id";
                    SqlCommand cmd = new SqlCommand(query, ConnectToSql());
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        ViewBag.id = $"Employee Id : {dr[0].ToString()}";
                        ViewBag.ename = $"Employee Name : {dr[1].ToString()}";
                        ViewBag.job = $"Employee Job : {dr[2].ToString()}";
                        ViewBag.salary = $"Employee Salary : {dr[3].ToString()}";
                    }
                    else
                    {
                        ViewBag.msg = $"{id} not exist...";
                    }
                    break;
                case "Create":
                    query = "Insert into tblEmployees values (@id,@ename,@job,@salary)";
                    cmd = new SqlCommand(query, ConnectToSql());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ename", ename);
                    cmd.Parameters.AddWithValue("@job", job);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    int count = cmd.ExecuteNonQuery();
                    ViewBag.msg = $"{count} rows added successfully...";
                    break;
                case "Update":
                    query = "Update tblEmployees set ename=@ename,job=@job,salary=@salary where id=@id";
                    cmd = new SqlCommand(query, ConnectToSql());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@ename", ename);
                    cmd.Parameters.AddWithValue("@job", job);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    count = cmd.ExecuteNonQuery();
                    ViewBag.msg = $"{count} rows updated successfully...";
                    break;
                case "Delete":
                    query = "Delete tblEmployees where id=@id";
                    cmd = new SqlCommand(query, ConnectToSql());
                    cmd.Parameters.AddWithValue("@id", id);
                    count = cmd.ExecuteNonQuery();
                    ViewBag.msg = $"{count} rows deleted successfully...";
                    break;
                default:
                    break;
            }
            return View();
        }
    }
}
