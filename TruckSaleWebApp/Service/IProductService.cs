﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Models;

namespace TruckSaleWebApp.Service
{
    public interface IProductService
    {
        IList<ProductGroupBean> GetAllProductGroup();

        void AddNewProduct(ProductShortInfoBean productbean);

        IList<ProductShortInfoBean> GetAllProducts();

        ProductBean GetProduct(long id);

        string UpdateProductAvatar(long id, HttpPostedFile file);

        void UpdateProduct(ProductShortInfoBean productbean);
        IList<ProductResourceBean> GetAllResourceByProduct(long id);
        void UpdateSpecification(ProductBean productbean);
        ProductResourceBean UpdateResource(long id, string type, HttpPostedFile httpPostedFile);
        ProductGroupBean GetManufacture(long id);
        void RemoveResource(long id);
        void UpdateManufacture(long id, long manufactureId);
        IList<ProductShortInfoBean> GetProductByManufacture(long id);
        void DeleteProduct(long id);
        object GetPricing();
    }
}
