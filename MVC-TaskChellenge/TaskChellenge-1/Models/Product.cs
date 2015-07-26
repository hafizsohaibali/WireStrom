using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TaskChellenge_1.Helpers;

namespace TaskChellenge_1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Price { get; set; }

        public List<UserComment> UserComments { get; set; }

        public void AddComment(UserComment UserComment)
        {
            if (UserComments == null)
            {
                UserComments = new List<UserComment>();
            }
            UserComments.Add(UserComment);
        }

        public void CreateProduct()
        {
            ProductHelper.CreateProduct(this);
        }

        public static Product GetProduct(int ProductId)
        {
            return ProductHelper.GetProduct(ProductId);
        }

        public static List<Product> GetProducts()
        {
            return ProductHelper.GetProducts();
        }


    }
}