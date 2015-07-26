using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaskChellenge_1.Models;

namespace TaskChellenge_1.Helpers
{
    public static class ProductHelper
    {
        private static int CurrentProductId = 0;
        private static object IsProductUse = new object();
        private static Dictionary<int, Product> Products = new Dictionary<int, Product>();

        public static List<Product> GetProducts() {
            return new List<Product>(Products.Values);
        }

        public static void CreateProduct(Product Product)
        {
            lock (IsProductUse)
            {
                CurrentProductId++;
                Product.Id = CurrentProductId;
                Products.Add(Product.Id, Product);
            }
        }

        public static Product GetProduct(int ProductId) {
            return Products[ProductId];
        }

        public static void AddComment(int ProductId, string Comment, string UserName)
        {
            Product Product = Products[ProductId];
            UserComment UserComment = new UserComment(Comment, UserName);
            Product.AddComment(UserComment);
        }
    }
}