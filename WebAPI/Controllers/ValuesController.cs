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
        public List<Item> itemList = new List<Item>() {
            new Item() { id = 1, name="Lego1"},
            new Item() { id = 2, name="Lego2"},
            new Item() { id = 3, name="Lego3"},
            new Item() { id = 4, name="Lego4"},
            new Item() { id = 5, name="Lego5"},
            new Item() { id = 6, name="Lego6"}
        };
        // GET api/values
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            return itemList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Item GetItem(int id)
        {
            return itemList.Where(item => item.id == id).First();
        }

        // POST api/values
        [HttpPost]
        public Item AddItem([FromBody]Item item)
        {
            //do the add item
            return item;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Item UpdateItem(int id, [FromBody]Item item)
        {
            item.id = id;
            return item;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //do the delete
        }
    }
}
