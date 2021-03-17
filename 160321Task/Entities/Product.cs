using System;
using System.Drawing;
using Newtonsoft.Json;

namespace _160321Task.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string OriginCountry { get; set; }
        public double Price { get; set; }
        [JsonIgnore]
        public Image Image { get; set; }

        public Byte[] ImageBytes { get; set; }

        public void UpdateProduct(Product product)
        {
            this.Name = product.Name;
            this.OriginCountry = product.OriginCountry;
            this.Price = product.Price;
        }
    }
}