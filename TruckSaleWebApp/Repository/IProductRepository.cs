using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public interface IProductRepository
    {
        void Save(Product product);

        IList<Product> GetAllProducts();

        Product GetProduct(long id);

        void Update(Product product);
        Product Delete(long id);
        IList<Product> GetProductsByGroup(long id);
    }
}
