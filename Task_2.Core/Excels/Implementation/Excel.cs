using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Excels.Interface;
using Task_2.Infrastructure.PracticeDbContext;
using Task_2.Infrastructure.Tables;

namespace Task_2.Core.Excels.Implementation
{
    public class Excel : IExcel
    {
        public readonly UserDbContext _userDbContext;
        public Excel(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        //Stream is class which is used to stores images,files etc
        public void ExcelMethod(Stream stream)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount; row++)
                {
                    var product = new Product()
                    {
                        ProductName = worksheet.Cells[row, 1].Value.ToString(),
                        Price = Convert.ToDecimal(worksheet.Cells[row, 2].Value.ToString()),
                    };
                    _userDbContext.Product.Add(product);
                }
                _userDbContext.SaveChanges();
            }
        }
    }
}
