using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            var list = new List<Item>();
            list.Add(new Item() { id = 1, name="Lego1"});
            list.Add(new Item() { id = 2, name="Lego2"});
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            var item = new Item();
            item.id = 1;
            item.name = "LegoAPI";
            return item;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
