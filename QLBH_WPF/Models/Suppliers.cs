//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBH_WPF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suppliers
    {
        private string _supplierID;
        public string SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = $"S{value}";
            }
        }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    
}