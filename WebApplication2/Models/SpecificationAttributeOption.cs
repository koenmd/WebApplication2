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
    
    public partial class SpecificationAttributeOption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecificationAttributeOption()
        {
            this.Product_SpecificationAttribute_Mapping = new HashSet<Product_SpecificationAttribute_Mapping>();
        }
    
        public int Id { get; set; }
        public int SpecificationAttributeId { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public int DisplayOrder { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product_SpecificationAttribute_Mapping> Product_SpecificationAttribute_Mapping { get; set; }
        public virtual SpecificationAttribute SpecificationAttribute { get; set; }
    }
}
