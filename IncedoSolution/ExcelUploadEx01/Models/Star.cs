using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx01.Models
{
    public class Star
    {
        [Key]
        public string TestCaseId { get; set; } = "";
        public string TestScenerio { get; set; } = "";
        public string TestCaseDescription { get; set; } = "";
        public string TestSteps { get; set; } = "";
        public string Precondition { get; set; } = "";
        public string TestData { get; set; } = "";
        public string ExpectedResult { get; set; } = "";
        public string ActualResult { get; set; } = "";
    }
}
