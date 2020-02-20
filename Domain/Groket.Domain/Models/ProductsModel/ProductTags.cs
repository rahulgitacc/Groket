using Groket.Domain.Models.CommonModel;
using System.Collections.Generic;

namespace Groket.Domain.Models.ProductsModel
{
    /// <summary>
    /// Get or Set the product tag to display related product
    /// </summary>
    public class ProductTags : AuditableEntity
    {
        public ProductTags()
        {
            ProductWithTags = new HashSet<ProductWithTag>();
            IsPublished = true;
        }
        /// <summary>
        /// Get or Set tag name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or Set is published
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Get or Set associated product and tag relationship
        /// </summary>
        public ICollection<ProductWithTag> ProductWithTags { get; set; }
    }
}
