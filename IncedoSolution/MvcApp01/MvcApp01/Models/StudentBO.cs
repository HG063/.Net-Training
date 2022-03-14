using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp01.Models
{
    public class StudentBO
    {
        public List<StudentModel> Students { get; set; }
        public StudentBO()
        {
            Students = new List<StudentModel>
            {
                new StudentModel{ Id=101,SName="Anil",Course="EEE",Fee=45000},
                new StudentModel{ Id=102,SName="Ram",Course="CSE",Fee=50000},
                new StudentModel{ Id=103,SName="Sita",Course="ECE",Fee=40000}
            };
        }
        public List<StudentModel> GetAllStudents()
        {
            return Students;
        }
    }
}
