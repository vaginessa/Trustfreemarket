//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnarkRE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EscrowAccept
    {
        public EscrowAccept()
        {
            this.Escrows = new HashSet<Escrow>();
        }
    
        public int AcceptId { get; set; }
        public string SellerPubkey { get; set; }
        public string SellerPrivkey { get; set; }
        public string EscrowAddress { get; set; }
        public string PinvBuyer { get; set; }
        public string PinvSeller { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime AutoReleaseDt { get; set; }
        public Nullable<decimal> LastAddressBalance { get; set; }
    
        public virtual ICollection<Escrow> Escrows { get; set; }
    }
}
