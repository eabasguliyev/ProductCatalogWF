using System.Drawing;

namespace _160321Task.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string OriginCountry { get; set; }
        public double Price { get; set; }
        public Bitmap ImageBitmap { get; set; }


        public void UpdateProduct(Product product)
        {
            this.Name = product.Name;
            this.OriginCountry = product.OriginCountry;
            this.Price = product.Price;
        }
    }
}