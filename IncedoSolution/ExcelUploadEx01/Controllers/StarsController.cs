using ExcelUploadEx01.Context;
using ExcelUploadEx01.Models;
using ExcelUploadEx01.Service;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx01.Controllers
{
    public class StarsController : Controller
    {
        IStarService _starService = null;
        List<Star> _star = new List<Star>();
        public StarsController(IStarService starService)
        {
            _starService = starService;
        }
        public IActionResult Index()
        { 
            return View();
        }
        public JsonResult SaveStars(List<Star> stars)
        {
            _star = _starService.SaveStars(stars);
                return Json(_star);
        }
        public string GenerateAndDownloadExcel(int TestCaseId, string TestScenerio)
        {
            List<Star> stars = _starService.GetStars();

            var dataTable = CommonMethods.ConvertListToDataTable(stars);
            
            byte[] fileContents = null;

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("Stars");

                ws.DefaultRowHeight = 16;
                ws.DefaultColWidth = 20;

                ws.Cells["A1"].EntireColumn.Width = 30;
                ws.Cells["A1"].Value = "Twitter Manual Testing";
                ws.Cells["A1"].Style.Font.Bold = true;
                ws.Cells["A1"].Style.Font.Size = 13;
                ws.Cells["A1"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                ws.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                
                ws.Cells["A2"].Value = "Author : Harshit";
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
