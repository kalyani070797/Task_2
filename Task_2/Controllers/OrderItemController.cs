using Microsoft.AspNetCore.Mvc;
using Task_2.Core.OrderItem.Interface;
using Task_2.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController (
                                       IOrderItemsCreator orderItemsCreator) : ControllerBase
    {
        // GET: api/<OrderItemController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderItemController>
        [HttpPost]
        public CommonApi Post([FromBody] OrderItemsRequestModel  orderItemsRequestModel)
        {
            orderItemsCreator.CreateOrderItemsByMultipleItems(orderItemsRequestModel);
            return new CommonApi
            {
                StatusCode=System.Net.HttpStatusCode.OK,
                Message = "Record inserted"
            };
        }

        // PUT api/<OrderItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
