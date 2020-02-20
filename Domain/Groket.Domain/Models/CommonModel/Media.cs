using System;
using Groket.Domain.Enums;
using Groket.Domain.Models.CatalogModel;
using Groket.Domain.Models.ProductsModel;

namespace Groket.Domain.Models.CommonModel
{
    /// <summary>
    /// Get or Set the Media values
    /// </summary>
    public class Media : AuditableEntity
    {
        /// <summary>
        /// Get or Set the file caption
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// Get or Set the file size
        /// </summary>
        public int? FileSize { get; set; }

        /// <summary>
        /// Get or Set the filename
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Get or Set the type of the file
        /// </summary>
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Get or Set reference of the brand
        /// </summary>
        public Guid? FkBrandId { get; set; }

        /// <summary>
        /// Get or Set brand entity to define the relationship
        /// </summary>
        public Brand Brand { get; set; }

        /// <summary>
        /// Get or Set reference of the product
        /// </summary>
        public Guid? FkProductId { get; set; }

        /// <summary>
        /// Get or Set product entity to define the relationship
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// Get or Set reference of the catalog
        /// </summary>
        public Guid? FkCatalogId { get; set; }

        /// <summary>
        /// Get or Set catalog entity to define the relationship
        /// </summary>
        public Catalog Catalog { get; set; }

        /// <summary>
        /// Get or Set reference of the catalog
        /// </summary>
        public Guid? FkCategoryId { get; set; }

        /// <summary>
        /// Get or Set catalog entity to define the relationship
        /// </summary>
        public Category Category { get; set; }
    }
}