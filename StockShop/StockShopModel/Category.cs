

namespace StockShop.StockShopModel
{
    using System.Collections.Generic;
    
    public partial class Category
    {
        public Category()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int id { get; set; }
        public string name_category { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
