using Groket.Domain.Models.CommonModel;

namespace Groket.Domain.Models.CatalogModel
{
    /// <summary>
    /// Get or Set Category values
    /// </summary>
    public class Category : AuditableEntity
    {
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
        /// Get or Set category media id reference
        /// </summary>
        public string MediaId { get; set; }
        
        /// <summary>
        /// Get or Set category thumbnail image
        /// </summary>
        public Media ThumbnailImage { get; set; }

        /// <summary>
        /// Get or Set reference of the Catalog
        /// </summary>
        public Catalog Catalog { get; set; }
    }
}