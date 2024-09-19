using Microsoft.AspNetCore.Mvc;
using Task_2.Core.Mappings.Interface;
using Task_2.Model.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MappingController : ControllerBase
    {
        public readonly IMappingCreator _mappingCreator;
        public readonly IMappingUpdator _mappingUpdator;
        public MappingController(IMappingCreator mappingCreator,
            IMappingUpdator mappingUpdator)
        { 
        
            _mappingCreator = mappingCreator;
            _mappingUpdator= mappingUpdator;
        }


        // GET: api/<MappingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MappingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MappingController>
        [HttpPost]
        public void Post([FromBody] MappingResponseModel mappingResponse)
        {
            _mappingCreator.CreateMapping(mappingResponse);
        }

        // PUT api/<MappingController>/5
        [HttpPut("Updating the data")]
        public void Put([FromBody] MappingResponseModel mappingResponse)
        {
            _mappingUpdator.UpdateMapping(mappingResponse);
        }

        // DELETE api/<MappingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        //Update Data
        [HttpPut("Updating the data without deleting previous data")]
        public void Update([FromBody] MappingResponseModel mappingResponse)
        {
            _mappingUpdator.UpdateMapping1(mappingResponse);
        }
    }
}
