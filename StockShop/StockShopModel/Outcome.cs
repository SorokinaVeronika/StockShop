

namespace StockShop.StockShopModel
{
    using System.Collections.Generic;
    
    public partial class Outcome
    {
        public Outcome()
        {
            this.Log_outcome = new HashSet<Log_outcome>();
        }
    
        public int id { get; set; }
        public int id_employee { get; set; }
        public System.DateTime date_order_outcome { get; set; }
        public System.DateTime date_delivery { get; set; }
        public string name_outcome { get; set; }
        public double price_outcome { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Log_outcome> Log_outcome { get; set; }
    }
}
