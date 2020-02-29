using System;

namespace Groket.Domain.Models.ProductsModel
{
    /// <summary>
    /// Get or set relation between Product and Product tag
    /// </summary>
    public class ProductWithTag
    {
        /// <summary>
        /// Get or Set product id reference
        /// </summary>
        public Guid FkProductId { get; set; }

        /// <summary>
        /// Get or Set Product entity to define the relationship
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Get or Set product tag id reference
        /// </summary>
        public Guid FkProductTagId { get; set; }

        /// <summary>
        /// Get or Set Product tag entity to define the relationship
        /// </summary>
        public ProductTags ProductTags { get; set; }
    }
}