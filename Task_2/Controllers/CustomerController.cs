using Microsoft.AspNetCore.Mvc;
using Task_2.Core.Customerss.Implementation;
using Task_2.Core.Customerss.Interface;
using Task_2.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController (
                                      ICustomerCreator customerCreator,
                                      ICustomerLogin customerLogin) : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CustomerController>/5
        [HttpGet("CustomerLogin")]
        public CommonApi Get(string email, string password)
        {
           var get= customerLogin.LoginCustomer(email, password);
            return new CommonApi
            {
                Data = get,
                StatusCode=System.Net.HttpStatusCode.OK,
                Message = "CustomerLogin  "
            };
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerRequestModel customerResponse)
        {
            customerCreator.CreateCustomer(customerResponse);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
