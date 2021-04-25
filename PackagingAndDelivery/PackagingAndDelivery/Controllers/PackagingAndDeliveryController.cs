using Microsoft.AspNetCore.Mvc;
using PackagingAndDelivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PackagingAndDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagingAndDeliveryController : ControllerBase
    {
        public IRepo<GetPackagingDeliveryCharge> _repository;

        /*// GET: api/<PackagingAndDeliveryController>
[HttpGet]
public IEnumerable<string> Get()
{
return new string[] { "value1", "value2" };
}
*/
        public PackagingAndDeliveryController(IRepo<GetPackagingDeliveryCharge> repo)
        {
            _repository = repo;
        }
        [HttpGet]
        public ActionResult<GetPackagingDeliveryCharge> PackagingDeliveryCharge(GetPackagingDeliveryCharge charges)
        {
            var charge = _repository.PackagingDeliveryCharge(charges);
            return Ok(charge);
        }
        // GET api/<PackagingAndDeliveryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PackagingAndDeliveryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PackagingAndDeliveryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PackagingAndDeliveryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
