using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using TruckSaleWebApp.Bean;
using TruckSaleWebApp.Models;
using TruckSaleWebApp.Repository;
using TruckSaleWebApp.Utils;

namespace TruckSaleWebApp.Service
{
    public class ProductService : IProductService
    {
        private static readonly string UPLOAD_IMG_PATH = Path.DirectorySeparatorChar + "Content" + Path.DirectorySeparatorChar + "img" + Path.DirectorySeparatorChar + "products";
        private static readonly string DEFAULT_AVATAR = UPLOAD_IMG_PATH + Path.DirectorySeparatorChar + "truckdefault.jpg"; 

        private IProductRepository _productRepo;

        private IProductGroupRepository _productGroupRepo;

        public ProductService(IProductRepository productRepo, IProductGroupRepository productGroupRepo)
        {
            _productRepo = productRepo;
            _productGroupRepo = productGroupRepo;
        }

        public IList<ProductGroupBean> GetAllProductGroup()
        {
            IList<ProductGroupBean> result = new List<ProductGroupBean>();
            try
            {
                result = BeanUtil.ConvertToList<ProductGroup, ProductGroupBean>( _productGroupRepo.FindAllProducts());
            } catch (Exception e)
            {
                throw new Exception("Error when get manufacture");
            }

            return result;
        }

        public void AddNewProduct(ProductShortInfoBean productbean)
        {
            if (productbean == null)
                throw new Exception("Add New Product Error with empty product");
            if (productbean.Groupid <= 0)
                throw new Exception("Add New Product Error with empty manufacture");
            if (string.IsNullOrEmpty(productbean.Name.Trim()))
                throw new Exception("Add New Product Error with empty product name");

            try
            {
                Product product = new Product()
                {
                    Name = productbean.Name,
                    Price = productbean.Price,
                    ProductGroupId = productbean.Groupid,
                    Img = DEFAULT_AVATAR
                };
                _productRepo.Save(product);
                
            } catch(Exception e)
            {
                throw new Exception("Add New Product Error: " + e.Message);
            }
        }

        public IList<ProductShortInfoBean> GetAllProducts()
        {
            IList<ProductShortInfoBean> result = new List<ProductShortInfoBean>();

            try
            {
                var products = _productRepo.GetAllProducts();
                result = BeanUtil.ConvertToList<Product, ProductShortInfoBean>(products);
            } catch(Exception e)
            {
                throw new Exception("Get all product get error: " + e.Message);
            }

            return result;
        }

        public ProductBean GetProduct(long id)
        {
            ProductBean product = null;

            try
            {
                Product p = _productRepo.GetProduct(id);
                product = new ProductBean(p);
            } catch(Exception e)
            {
                throw new Exception("Get product error: " + e.Message);
            }
            return product;
        }

        public string UpdateProductAvatar(long id, HttpPostedFile file)
        {
            string result = "";
            try
            {
                Product product = _productRepo.GetProduct(id);
                if (product != null)
                {
                    string oldImgPath = product.Img;
                    string imgPath = FileHelper.UploadFile(file, UPLOAD_IMG_PATH);
                    product.Img = imgPath;
                    _productRepo.Update(product);
                    if (!string.IsNullOrEmpty(oldImgPath) && oldImgPath != DEFAULT_AVATAR)
                    {
                        File.Delete(oldImgPath);
                    }
                    result = imgPath;
                } else
                {
                    throw new Exception("Product not found for product id = " + id);
                }

            }catch(Exception e)
            {
                throw new Exception("Update product avatar failed: " + e.Message);
            }

            return result;
        }
    }
}