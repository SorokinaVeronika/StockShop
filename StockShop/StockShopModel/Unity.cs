

namespace StockShop.StockShopModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Unity
    {
        public Unity()
        {
            this.Product = new HashSet<Product>();
        }
    
        public int id { get; set; }
        public string name_unity { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
    }
}
