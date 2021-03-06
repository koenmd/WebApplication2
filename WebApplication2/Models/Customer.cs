//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.ActivityLog = new HashSet<ActivityLog>();
            this.BackInStockSubscription = new HashSet<BackInStockSubscription>();
            this.BlogComment = new HashSet<BlogComment>();
            this.CustomerPassword = new HashSet<CustomerPassword>();
            this.ExternalAuthenticationRecord = new HashSet<ExternalAuthenticationRecord>();
            this.Forums_Post = new HashSet<Forums_Post>();
            this.Forums_Subscription = new HashSet<Forums_Subscription>();
            this.Forums_Topic = new HashSet<Forums_Topic>();
            this.Log = new HashSet<Log>();
            this.NewsComment = new HashSet<NewsComment>();
            this.Order = new HashSet<Order>();
            this.PollVotingRecord = new HashSet<PollVotingRecord>();
            this.Forums_PrivateMessage = new HashSet<Forums_PrivateMessage>();
            this.Forums_PrivateMessage1 = new HashSet<Forums_PrivateMessage>();
            this.ProductReview = new HashSet<ProductReview>();
            this.ReturnRequest = new HashSet<ReturnRequest>();
            this.RewardPointsHistory = new HashSet<RewardPointsHistory>();
            this.ShoppingCartItem = new HashSet<ShoppingCartItem>();
            this.CustomerRole = new HashSet<CustomerRole>();
            this.Address2 = new HashSet<Address>();
        }
    
        public int Id { get; set; }
        public System.Guid CustomerGuid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string EmailToRevalidate { get; set; }
        public string AdminComment { get; set; }
        public bool IsTaxExempt { get; set; }
        public int AffiliateId { get; set; }
        public int VendorId { get; set; }
        public bool HasShoppingCartItems { get; set; }
        public bool RequireReLogin { get; set; }
        public int FailedLoginAttempts { get; set; }
        public Nullable<System.DateTime> CannotLoginUntilDateUtc { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public bool IsSystemAccount { get; set; }
        public string SystemName { get; set; }
        public string LastIpAddress { get; set; }
        public System.DateTime CreatedOnUtc { get; set; }
        public Nullable<System.DateTime> LastLoginDateUtc { get; set; }
        public System.DateTime LastActivityDateUtc { get; set; }
        public int RegisteredInStoreId { get; set; }
        public Nullable<int> BillingAddress_Id { get; set; }
        public Nullable<int> ShippingAddress_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BackInStockSubscription> BackInStockSubscription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogComment> BlogComment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPassword> CustomerPassword { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalAuthenticationRecord> ExternalAuthenticationRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_Post> Forums_Post { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_Subscription> Forums_Subscription { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_Topic> Forums_Topic { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewsComment> NewsComment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PollVotingRecord> PollVotingRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_PrivateMessage> Forums_PrivateMessage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Forums_PrivateMessage> Forums_PrivateMessage1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductReview> ProductReview { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnRequest> ReturnRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RewardPointsHistory> RewardPointsHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerRole> CustomerRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Address> Address2 { get; set; }
    }
}
