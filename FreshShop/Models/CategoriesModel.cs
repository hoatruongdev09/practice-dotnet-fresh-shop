using System.Collections.Generic;

namespace FreshShop.Models
{
    public class CategoriesModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }
        public List<CategoriesModel> SubCategory { get; set; }
    }
}