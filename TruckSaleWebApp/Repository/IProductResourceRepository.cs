using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Repository
{
    public interface IProductResourceRepository
    {
        IList<ProductResource> GetByProduct(long productId);

        ProductResource Add(ProductResource resource);

        void Remove(long id);
    }
}
