using ExcelUploadEx01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx01.Service
{
    public interface IStarService
    {
        List<Star> GetStars();
        List<Star> SaveStars(List<Star> stars);

    }
}
