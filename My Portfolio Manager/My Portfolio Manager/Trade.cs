//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_Portfolio_Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trade
    {
        public int Id { get; set; }
        public bool Isbuy { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int InstrumentId { get; set; }
    
        public virtual Instrument Instrument { get; set; }
    }
}
