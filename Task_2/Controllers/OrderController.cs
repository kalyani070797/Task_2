using Microsoft.AspNetCore.Mvc;
using Task_2.Core.Orders.Interface;
using Task_2.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController(
                                   IOrderCreator orderCreator,
                                   IOrderUpdation orderUpdation,
                                   IOrderCreatorWithOrderItemsCreator orderCreatorWithOrderItemsCreator) : ControllerBase
    {
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(int customerId,int productId,int quantity)
        {
            orderCreator.UpdateQuantity(customerId, productId, quantity);
        }
        [HttpPost("OrderCreatorWithOrderItemsCreator")]
        public CommonApi PostOrderAndOrderItems(OrderAndOrderItemsRequestModel orderAndOrderItemsRequestModel)
        {
            orderCreatorWithOrderItemsCreator.CreateOrderWithOrderItem(orderAndOrderItemsRequestModel); 
            return new CommonApi()
            {
                StatusCode = System.Net.HttpStatusCode.OK,
                Message = "Record inserted in Order and OrderItems tables"
            };
        }
        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int orderId, DateTime orderDate)
        {
            orderUpdation.UpdateOrder(orderId, orderDate);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
