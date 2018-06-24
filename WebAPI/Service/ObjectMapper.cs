using WebAPI.Domain;
using WebAPI.Model;

namespace WebAPI.Service
{
    public static class ObjectMapper
    {
        public static Product ItemToProduct(Item item)
        {
            return new Product() { ProductId = item.id, ProductName = item.name};
        }

        public static Item ProductToItem(Product product)
        {
            return new Item() { id = product.ProductId, name = product.ProductName};
        }
    }
}