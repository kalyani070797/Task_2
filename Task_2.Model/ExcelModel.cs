using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Model
{
    public class ExcelModel
    {
        //IFormFile is used to upload the Excel file 
        public IFormFile formFile { get; set; }
    }
}
