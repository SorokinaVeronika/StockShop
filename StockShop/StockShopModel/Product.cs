

namespace StockShop.StockShopModel
{
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Log_income = new HashSet<Log_income>();
            this.Log_outcome = new HashSet<Log_outcome>();
        }
    
        public int id { get; set; }
        public int id_category { get; set; }
        public int id_unity { get; set; }
        public string name_product { get; set; }
        public int count_product { get; set; }
        public double price { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Log_income> Log_income { get; set; }
        public virtual ICollection<Log_outcome> Log_outcome { get; set; }
        public virtual Unity Unity { get; set; }
    }
}
