//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockShop.StockShopDAL
{
    using System;
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