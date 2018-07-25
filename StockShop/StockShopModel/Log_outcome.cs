

namespace StockShop.StockShopModel
{
    
    public partial class Log_outcome
    {
        public int id { get; set; }
        public int id_outcome { get; set; }
        public int id_product { get; set; }
        public int count_outcome_product { get; set; }
    
        public virtual Outcome Outcome { get; set; }
        public virtual Product Product { get; set; }
    }
}
