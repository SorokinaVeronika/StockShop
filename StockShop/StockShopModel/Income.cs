

namespace StockShop.StockShopModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public Income()
        {
            this.Log_income = new HashSet<Log_income>();
        }
    
        public int id { get; set; }
        public int id_employee { get; set; }
        public string name_income { get; set; }
        public System.DateTime date_order_income { get; set; }
        public System.DateTime data_income { get; set; }
        public double price_income { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Log_income> Log_income { get; set; }
    }
}
