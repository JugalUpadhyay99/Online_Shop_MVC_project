//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practisequestion16
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producttable
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Images { get; set; }
    
        public virtual Brandtable Brandtable { get; set; }
        public virtual Categorytable Categorytable { get; set; }
    }
}
