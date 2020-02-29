using System;
using System.Collections.Generic;
using Groket.Domain.Models.CommonModel;
using Groket.Domain.Models.ProductsModel;

namespace Groket.Domain.Models.CatalogModel
{
    /// <summary>
    /// Get or Set Category values
    /// </summary>
    public class Category : AuditableEntity
    {
        
        public Category()
        {
            Products = new List<Product>();
        }

        /// <summary>
        /// Get or Set category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or Set category slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Get or Set category description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or Set is published value
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Get or Set category display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Get or Set category is included into menu
        /// </summary>
        public bool IncludeInMenu { get; set; }
        
        /// <summary>
        /// Get or Set category thumbnail image
        /// </summary>
        public Media Media { get; set; }
        
        /// <summary>
        /// Get or Set reference of the catalog
        /// </summary>
        public Guid FkCatalogId { get; set; }

        /// <summary>
        /// Get or Set catalog entity to define the relationship
        /// </summary>
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Get or Set related products
        /// </summary>
        public IList<Product> Products { get; set; }
    }
}