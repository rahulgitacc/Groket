using Groket.Domain.Models.CommonModel;
using Groket.Domain.Models.ProductsModel;
using System.Collections.Generic;

namespace Groket.Domain.Models.CatalogModel
{
    /// <summary>
    /// Get or Set the band values
    /// </summary>
    public class Brand : AuditableEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
            IsPublished = true;
        }

        /// <summary>
        /// Get or Set band name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or Set band slug
        /// </summary>
        public string Slug { get; set; }
        
        /// <summary>
        /// Get or Set band description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or Set band is published or not
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Get or Set band image
        /// </summary>
        public Media Media { get; set; }
        
        /// <summary>
        /// Get or set list of products
        /// </summary>
        public ICollection<Product> Products { get; set; }
    }
}