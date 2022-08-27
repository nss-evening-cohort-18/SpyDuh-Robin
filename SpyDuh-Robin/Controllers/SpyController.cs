using Microsoft.AspNetCore.Mvc;
using SpyDuh_Robin.Interfaces;
using SpyDuh_Robin.Models;
using SpyDuh_Robin.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpyDuh_Robin.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpGet("{agency}")]
        public List<Spy> GetAgency(string agency)
        {
            return _spy.GetAgency(agency);
        }

        // GET api/<SpyController>/5
        [HttpGet("{skill}")]
        public List<Spy> GetBySkill(string skill)
        {
            return _spy.GetBySkill(skill);
        }

        [HttpGet("{friend}")]
        public List<Spy> GetByFriends(int friend)
        {
            return _spy.GetByFriend(friend);
        }

        [HttpGet("{enemy}")]
        public List<Spy> GetByEnemy(int enemy)
        {
            return _spy.GetByEnemy(enemy);
        }

        [HttpGet("{friend}")]
        public List<Spy> GetByFriendofFriend(int friend)
        {
            return _spy.GetByFriendofFriend(friend);
        }

        [HttpGet("{id}")]
        public int GetByDueDate(int id)
        {
            return _spy.GetByDueDate(id);
        }

        // POST api/<SpyController>
        [HttpPost]
        public void Post([FromBody] Spy spy)
        {
           _spy.Post(spy);
        }

        // PUT api/<SpyController>/5
        [HttpPut("{id}")]
        public void AddSkill(int id, [FromBody] List<string> value)
        {
            _spy.AddSkill(id, value);
        }

        [HttpPut("{id}")]
        public void AddService(int id, [FromBody] List<string> value)
        {
            _spy.AddService(id, value);
        }

        // DELETE api/<SpyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
