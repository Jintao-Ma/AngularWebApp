using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain;
using WebAPI.Model;
using WebAPI.Service;

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

        DataAccess _dataAccess;
        public ValuesController(DataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
             var productList = _dataAccess.GetProducts();
             var itemList = new List<Item>();
             foreach(Product product in productList)
            {
                var item = ObjectMapper.ProductToItem(product);
                itemList.Add(item);
            }
            return itemList;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Item GetItem(int id)
        {
            var product = _dataAccess.GetProduct(id);
            if (product != null){
                return ObjectMapper.ProductToItem(product);
            }
            return new Item() { id = 0, name = "Not Found"};
        }

        // POST api/values
        [HttpPost]
        public Item AddItem([FromBody]Item item)
        {
            _dataAccess.Create(ObjectMapper.ItemToProduct(item));
            return item;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Item UpdateItem(int id, [FromBody]Item item)
        {
            _dataAccess.Update(ObjectMapper.ItemToProduct(item));
            return item;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _dataAccess.Delete(id);
        }
    }
}
