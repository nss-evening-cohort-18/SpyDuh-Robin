using Microsoft.AspNetCore.Mvc;
using SpyDuh_Robin.Interfaces;
using SpyDuh_Robin.Models;
using SpyDuh_Robin.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpyDuh_Robin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {
        //private SpyRepository _spyrepository = new SpyRepository();
        private ISpyRepository _spy;
        public SpyController(ISpyRepository ipsy)
        {
            _spy = ipsy;
        }

        // GET: api/<SpyController>
        [HttpGet]
        public List<Spy> GetAll()
        {
            return _spy.GetAll();
        }

        // GET api/<SpyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SpyController>
        [HttpPost]
        public void Post([FromBody] Spy spy)
        {
           _spy.Post(spy);
        }

        // PUT api/<SpyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SpyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
