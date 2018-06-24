using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using WebAPI.Model;
 
namespace WebAPI.Domain
{
    public class DataAccess
    {
        MongoClient _client;
        IMongoDatabase _db;
 
        public DataAccess()
        {
            _client = new MongoClient(new MongoUrl("mongodb://localhost:27017"));
            _db = _client.GetDatabase("EmployeeDB");      
        }
 
        public IEnumerable<Product> GetProducts()
        {
            return _db.GetCollection<Product>("Products").Find(new BsonDocument()).ToListAsync().Result;
        }
 
 
        public Product GetProduct(int id)
        {
            return _db.GetCollection<Product>("Products").Find(x => x.ProductId.Equals(id)).FirstOrDefaultAsync().Result;
        }
 
        public Product Create(Product product)
        {
            _db.GetCollection<Product>("Products").InsertOneAsync(product);
            return product;
        }

        public Product Update(Product product)
        {
            var existingProduct = GetProduct(product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductName = product.ProductName;
                ReplaceOneResult result = _db.GetCollection<Product>("Products").ReplaceOne(p => p.ProductId.Equals(product.ProductId), existingProduct, new UpdateOptions { IsUpsert = true });
            }
            return product;
        }
        public void Delete(int id)
        {
            _db.GetCollection<Product>("Products").DeleteOneAsync(p => p.ProductId.Equals(id));
        }
    }
}