

namespace StockShop.StockShopModel
{
    
    public partial class Log_income
    {
        public int id { get; set; }
        public int id_income { get; set; }
        public int id_product { get; set; }
        public int count_income_product { get; set; }
        public double price_income_product { get; set; }
    
        public virtual Income Income { get; set; }
        public virtual Product Product { get; set; }
    }
}
