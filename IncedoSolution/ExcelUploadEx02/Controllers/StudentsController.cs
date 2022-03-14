using ExcelUploadEx02.Models;
using ExcelUploadEx02.Service;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx02.Controllers
{
    public class StudentsController : Controller
    {
        IStudentService _studentService = null;
        List<Student> _student = new List<Student>();
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult SaveStudents(List<Student> student)
        {
            _student = _studentService.SaveStudents(student);
            return Json(_student);
        }
        public string GenerateAndDownloadExcel(int StudentId, string Name)
        {
            List<Student> students = _studentService.GetStudents();

            var dataTable = CommonMethods.ConvertListToDataTable(students);

            byte[] fileContents = null;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Students");

                ws.DefaultRowHeight = 16;
                ws.DefaultColWidth = 20;

                ws.Cells["A1"].EntireColumn.Width = 20;
                ws.Cells["A1"].Value = "School";
                ws.Cells["A1"].Style.Font.Bold = true;
                ws.Cells["A1"].Style.Font.Size = 13;
                ws.Cells["A1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A2"].Value = "Student List";
                ws.Cells["A2"].Style.Font.Bold = true;
                ws.Cells["A2"].Style.Font.Size = 13;
                ws.Cells["A2"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                ws.Cells["A3"].LoadFromDataTable(dataTable, true);
                ws.Cells["A3:H3"].Style.Font.Bold = true;
                ws.Cells["A3:H3"].Style.Font.Size = 12;
                ws.Cells["A3:H3"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Cells["A3:H3"].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.SkyBlue);
                ws.Cells["A3:H3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A3:H3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                pck.Save();
                fileContents = pck.GetAsByteArray();
            }
            return Convert.ToBase64String(fileContents);
        }
    }
}

