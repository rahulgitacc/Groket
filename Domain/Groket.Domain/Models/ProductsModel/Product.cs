using System;
using System.Collections.Generic;
using Groket.Domain.Models.CatalogModel;
using Groket.Domain.Models.CommonModel;

namespace Groket.Domain.Models.ProductsModel
{
    /// <summary>
    /// Get or Set product information
    /// </summary>
    public class Product : AuditableEntity
    {
        public Product()
        {
            ProductWithTags = new HashSet<ProductWithTag>();
            Media = new HashSet<Media>();
            PriceHistory = new HashSet<ProductPriceHistory>();
            IsAllowToOrder = true;
        }
        /// <summary>
        /// Get or Set product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or Set product short description
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Get or Set product Long description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Get or Set product current price
        /// </summary>
        public decimal Price { get; set; }
        
        /// <summary>
        /// Get or Set special price
        /// </summary>
        public decimal? SpecialPrice { get; set; }

        /// <summary>
        /// Get or Set has option value if the product has different variety  to choose 
        /// </summary>
        public bool HasOptions { get; set; }

        /// <summary>
        /// Get or Set is the product is featured
        /// </summary>
        public bool IsFeatured { get; set; }

        /// <summary>
        /// Get or Set is the product is calling for the price
        /// </summary>
        public bool IsCallForPricing { get; set; }

        /// <summary>
        /// Get or Set Is Allow to order
        /// </summary>
        public bool IsAllowToOrder { get; set; }

        /// <summary>
        /// Get or Set the stock of the product
        /// </summary>
        public int? StockQuantity { get; set; }

        /// <summary>
        /// Get or set Product media reference  
        /// </summary>
        public ICollection<Media> Media { get; set; }

        /// <summary>
        /// Get or Set reference of the Brand
        /// </summary>
        public Guid FkBrandId { get; set; }

        /// <summary>
        /// Get or Set brand entity to define the relationship
        /// </summary>
        public Brand Brand { get; set; }
        
        /// <summary>
        /// Get or Set reference of the Category
        /// </summary>
        public Guid FkCategoryId { get; set; }

        /// <summary>
        /// Get or Set reference of the product category
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Get or Set reference of the product price history
        /// </summary>
        public ICollection<ProductPriceHistory> PriceHistory { get; set; }
        
        /// <summary>
        /// Get or Set associated product and tag relationship
        /// </summary>
        public ICollection<ProductWithTag> ProductWithTags { get; set; }
    }
}