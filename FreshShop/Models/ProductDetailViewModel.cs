namespace FreshShop.Models
{
    public class ProductDetailViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public float DiscountPrice { get; set; }
        public string[] ProductImages { get; set; }

    }
}