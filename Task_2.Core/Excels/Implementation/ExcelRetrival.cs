using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.Core.Excels.Interface;
using Task_2.Infrastructure.PracticeDbContext;

namespace Task_2.Core.Excels.Implementation
{
    public class ExcelRetrival : IExcelRetrival
    {
        public readonly UserDbContext _userDbContext;
        public ExcelRetrival(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public byte[] GetExcel()
        {
            var product = _userDbContext.Product.ToList();
            using (var stream = new MemoryStream())
            {

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.Add("ProductDetails");
                    //Row,column
                    worksheet.Cells[1, 1].Value = "ProductId";
                    worksheet.Cells[1, 2].Value = "ProductName";
                    worksheet.Cells[1, 3].Value = "Price";
                    for (int i = 0; i < product.Count; i++)
                    {
                        worksheet.Cells[i + 2, 1].Value = product[i].ProductId;
                        worksheet.Cells[i + 2, 2].Value = product[i].ProductName;
                        worksheet.Cells[i + 2, 3].Value = product[i].Price;

                    }
                    //worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    package.Save();
                }
                return stream.ToArray();
            }
        }
    }
}
