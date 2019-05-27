using RefactorMe;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    [RoutePrefix("Product")]
    public class ProductController : ApiController
    {
        public class Product
        {
            public Guid Id { get; set; }

            public string Name { get; set; }

            public double Price { get; set; }

            public string Type { get; set; }
            public string Currency { get; set; }
        }


        [Route("getProducts")]
        [HttpGet]
        public List<Product> getProducts(HttpRequestMessage request)
        {
        
            List<Product> list = new List<Product>();
            try
            {

                var model = ProductDataConsolidator.Get().ToList();
                //var model = ProductData.Get().ToList();

                foreach (var item in model)
                {
                    Product product = new Product();
                    product.Id = item.Id;
                    product.Name = item.Name;
                    product.Price = item.Price;
                    product.Currency = item.Currency;
                    product.Type = item.Type;
                    list.Add(product);
                }
             
            }
            catch (Exception e)
            {
            }
            return list;
        }
    }
}