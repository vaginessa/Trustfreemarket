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
    
    public partial class User
    {
        public User()
        {
            this.ContactMsgs = new HashSet<ContactMsg>();
            this.EscrowsBuyer = new HashSet<Escrow>();
            this.EscrowsSeller = new HashSet<Escrow>();
            this.FeedbacksFrom = new HashSet<Feedback>();
            this.FeedbacksAbout = new HashSet<Feedback>();
            this.Listings = new HashSet<Listing>();
            this.PasswordResets = new HashSet<PasswordReset>();
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> LastModifiedDt { get; set; }
        public Nullable<decimal> SellerScore { get; set; }
        public Nullable<decimal> BuyerScore { get; set; }
        public Nullable<decimal> TotalScore { get; set; }
    
        public virtual ICollection<ContactMsg> ContactMsgs { get; set; }
        public virtual ICollection<Escrow> EscrowsBuyer { get; set; }
        public virtual ICollection<Escrow> EscrowsSeller { get; set; }
        public virtual ICollection<Feedback> FeedbacksFrom { get; set; }
        public virtual ICollection<Feedback> FeedbacksAbout { get; set; }
        public virtual ICollection<Listing> Listings { get; set; }
        public virtual ICollection<PasswordReset> PasswordResets { get; set; }
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}
