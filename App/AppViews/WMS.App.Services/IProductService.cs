using System.Collections.Generic;
using WMS.Model;

namespace WMS.App.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        List<Product> SearchProducts(ProductSearchParameter parameter);
        Product SaveProduct(Product entity);
        bool DeleteProduct(int entityId);
    }
}