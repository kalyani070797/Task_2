using Microsoft.AspNetCore.Mvc;
using Task_2.Core.Dashboards.Interface;
using Task_2.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController(IDashboardCommon dashboardCommon) : ControllerBase
    {
        // GET: api/<DashboardController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DashboardController>/5
        [HttpGet("GetDashboard")]
        public CommonApi GetDashboard(int year)
        {
            
           var get= dashboardCommon.GetDashboard(year);
            return new CommonApi
            {
                Data = get,
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }

        // POST api/<DashboardController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DashboardController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DashboardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
