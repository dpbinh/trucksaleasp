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

        private static readonly string INSIDE = "inside";

        private static readonly string OUTSIDE = "outside";

        private IProductRepository _productRepo;

        private IProductGroupRepository _productGroupRepo;

        private IProductResourceRepository _resourceRepo;

        public ProductService(IProductRepository productRepo, IProductGroupRepository productGroupRepo, IProductResourceRepository resourceRepo)
        {
            _productRepo = productRepo;
            _productGroupRepo = productGroupRepo;
            _resourceRepo = resourceRepo;
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
                        FileHelper.Delete(oldImgPath);
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

        public void UpdateProduct(ProductShortInfoBean productbean)
        {
            try
            {
                Product product = _productRepo.GetProduct(productbean.Id);
                product.Name = productbean.Name;
                product.Price = productbean.Price;
                _productRepo.Update(product);
            } catch(Exception e)
            {
                throw new Exception("Update Product Error : " + e.Message);
            }
        }

        public void UpdateSpecification(ProductBean productbean)
        {
            try
            {
                Product product = _productRepo.GetProduct(productbean.Id);
                productbean.CloneTo(product);
                _productRepo.Update(product);
            }
            catch (Exception e)
            {
                throw new Exception("Update Product Specification Error : " + e.Message);
            }
        }

        public ProductResourceBean UpdateResource(long id, string type, HttpPostedFile file)
        {
            if(!INSIDE.Equals(type) && !OUTSIDE.Equals(type))
            {
                throw new Exception("Resource Type not found");
            }

            ProductResourceBean result = null;
            try
            {
                Product product = _productRepo.GetProduct(id);
                if (product != null)
                {
                    
                    string path = FileHelper.UploadFile(file, UPLOAD_IMG_PATH);
                    ProductResource r = new ProductResource()
                    {
                        productId = product.Id,
                        ResourcePath = path,
                        ResourceType = type
                    };
                    ProductResource saved = _resourceRepo.Add(r);
                    result = new ProductResourceBean(saved);
                }
                else
                {
                    throw new Exception("Product not found for product id = " + id);
                }
            } catch(Exception e)
            {
                throw new Exception("Update resource error: " + e.Message);
            }
            return result;
        }

        public void RemoveResource(long id)
        {
            try
            {
                var rs = _resourceRepo.Remove(id);
                FileHelper.Delete(rs.ResourcePath);
            } catch(Exception e)
            {
                throw new Exception("Remove Resource Error : " + e.Message);
            }
        }

        public IList<ProductResourceBean> GetAllResourceByProduct(long id)
        {
            IList<ProductResourceBean> result = new List<ProductResourceBean>();
            try
            {
                result = BeanUtil.ConvertToList<ProductResource, ProductResourceBean>(_resourceRepo.GetByProduct(id));
            } catch(Exception e)
            {
                throw new Exception("Error Get resource for product : " + id + ": " + e.Message);
            }
            return result;
        }

        public void UpdateManufacture(long id, long manufactureId)
        {
            try
            {
                var product = _productRepo.GetProduct(id);
                if (product == null)
                    throw new Exception("Product not found for product id = " + id);

                var group = _productGroupRepo.Get(manufactureId);
                if (group == null)
                    throw new Exception("Manufacture not found for manufacture id = " + manufactureId);

                if(product.ProductGroupId != manufactureId)
                {
                    product.ProductGroupId = manufactureId;
                    product.ProductGroup = group;
                    _productRepo.Update(product);
                    
                }
            } catch(Exception e)
            {
                throw new Exception(string.Format("update manufacture for product {0} get error: {1}", id, e.Message)); 
            }
        }

        public void DeleteProduct(long id)
        {
            try
            {
                var product = _productRepo.Delete(id);
                if(product != null)
                {
                    if (!string.IsNullOrEmpty(product.Img) && product.Img != DEFAULT_AVATAR)
                    {
                        FileHelper.Delete(product.Img);
                    }
                    
                    var resources = _resourceRepo.GetByProduct(product.Id);
                    string error = "";
                    foreach(var rs in resources)
                    {
                        try
                        {
                            RemoveResource(rs.Id);
                        } catch(Exception e)
                        {
                            error += e.Message + Environment.NewLine;
                        }
                        
                    }

                    if (!string.IsNullOrEmpty(error))
                    {
                        throw new Exception("delete resource for product error : " + error);
                    }
                }
            } catch(Exception e)
            {
                throw new Exception("Delete product error with product id = " + id + " : " + e.Message);
            }
        }

        public ProductGroupBean GetManufacture(long id)
        {
            ProductGroupBean result = null;
            try
            {
                result = new ProductGroupBean(_productGroupRepo.Get(id));
            } catch(Exception e)
            {
                throw new Exception("Get Manufacture id = " + id + " error : " + e.Message);
            }

            return result;
        }

        public IList<ProductShortInfoBean> GetProductByManufacture(long id)
        {
            IList<ProductShortInfoBean> result = new List<ProductShortInfoBean>();
            try
            {
                result = BeanUtil.ConvertToList<Product, ProductShortInfoBean>(_productRepo.GetProductsByGroup(id));
            }catch(Exception e)
            {
                throw new Exception("Get Product by manufacture error : " + e.Message);
            }

            return result;
        }

        public object GetPricing()
        {
            IList<PricingBean> result = new List<PricingBean>();
            try
            {
                IList<ProductShortInfoBean> products = GetAllProducts();
                foreach(ProductShortInfoBean product in products)
                {
                    var list = result.Where(p => p.ManufactureId == product.Groupid).ToList();
                    var pricing = list.Count > 0 ? list[0] : null;
                    if(pricing == null)
                    {
                        pricing = new PricingBean()
                        {
                            Manufacture = product.GroupName,
                            ManufactureId = product.Groupid,
                        };
                    }
                    pricing.Products.Add(product);
                    result.Add(pricing);
                }
            } catch(Exception e)
            {
                throw new Exception("Get pricing error : " + e.Message);
            }
            return result;
        }
    }

    
}