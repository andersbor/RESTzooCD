using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RESTzooCD.Managers;
using RESTzooCD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTzooCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly AnimalsManager _manager = new AnimalsManager();

        // GET: api/<AnimalsController>
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<AnimalsController>/5
        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<AnimalsController>
        [HttpPost]
        public Animal Post([FromBody] Animal value)
        {
            return _manager.Add(value);
        }

        // PUT api/<AnimalsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<AnimalsController>/5
        [HttpDelete("{id}")]
        public Animal Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
