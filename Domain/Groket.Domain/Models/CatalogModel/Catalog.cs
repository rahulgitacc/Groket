using Groket.Domain.Models.CommonModel;
using System;
using System.Collections.Generic;

namespace Groket.Domain.Models.CatalogModel
{
    /// <summary>
    /// Get or Set product catalog value to differentiate different category
    /// </summary>
    public class Catalog : AuditableEntity
    {
        public Catalog()
        {
            Categories = new HashSet<Category>();
            IsPublished = true;
            IncludeInMenu = true;
        }

        /// <summary>
        /// Get or Set category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or Set catalog slug
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Get or Set catalog meta title
        /// </summary>
        public string MetaTitle  { get; set; }

        /// <summary>
        /// Get or Set catalog meta keyword to search
        /// </summary>
        public string MetaKeywords  { get; set; }

        /// <summary>
        /// Get or Set catalog description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or Set catalog display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Get or Set catalog published value
        /// </summary>
        public bool IsPublished { get; set; }

        /// <summary>
        /// Get or Set catalog is include in the menu
        /// </summary>
        public bool IncludeInMenu  { get; set; }

        /// <summary>
        /// Get or Set children category Id
        /// </summary>
        public ICollection<Category> Categories { get; set; }

        /// <summary>
        /// Get or Set catalog thumbnail image
        /// </summary>
        public Media Media { get; set; }

    }
}