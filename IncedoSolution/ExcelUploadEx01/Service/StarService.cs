using EFCore.BulkExtensions;
using ExcelUploadEx01.Context;
using ExcelUploadEx01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUploadEx01.Service
{
    public class StarService : IStarService
    {
        DatabaseContext _dbContext = null;
        public StarService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Star> GetStars()
        {
            return _dbContext.Stars.ToList();
        }

        public List<Star> SaveStars(List<Star> stars)
        {
            _dbContext.BulkInsert(stars);
            return stars;
        }
    }
}
