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
            Products = new List<Product>();
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
        /// Get or Set the list of products 
        /// </summary>
        public IList<Product> Products { get; set; }
    }
}
