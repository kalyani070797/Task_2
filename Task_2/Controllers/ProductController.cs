using Microsoft.AspNetCore.Mvc;
using Task_2.Core.Excels.Interface;
using Task_2.Core.Products.Interface;
using Task_2.Model;
using Task_2.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductCreator _productCreator;
        public readonly IExcel _excel;
        public readonly IExcelRetrival _excelRetrival;
        public ProductController(IProductCreator productCreator,
            IExcel excel,
             IExcelRetrival excelRetriva)
        {
            _productCreator = productCreator;
            _excel = excel;
            _excelRetrival = excelRetriva;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] ProductRequestModel productResponse)
        {
            _productCreator.CreateProduct(productResponse);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpPost("Excel Post")]
        public void Post(ExcelModel excelModel)
        {
            try
            {
                //MemoryStream is used to hold the generated excel file 
                using (var stream = new MemoryStream())
                {
                   excelModel.formFile.CopyTo(stream);
                    _excel.ExcelMethod(stream);
                }

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        [HttpGet("Excel get")]
        public IActionResult Getyy()
        {
            var excelFile = _excelRetrival.GetExcel();
            var fileName = "Products.xlsx";
            return File(excelFile, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
    }
}
