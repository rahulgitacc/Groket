using Groket.Domain.Models.CatalogModel;
using Groket.Domain.Models.CommonModel;

namespace Groket.Domain.Models.ProductsModel
{
    /// <summary>
    /// Get or Set product information
    /// </summary>
    public class Product : AuditableEntity
    {
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
        /// Get or Set
        /// </summary>
        public bool IsAllowToOrder { get; set; }

        /// <summary>
        /// Get or Set the stock of the product
        /// </summary>
        public int StockQuantity { get; set; }

        /// <summary>
        /// Product image
        /// </summary>
        public Media ThumbnailImage { get; set; }

        /// <summary>
        /// Get or Set reference of the brand
        /// </summary>
        public Brand Brand { get; set; }

        /// <summary>
        /// Get or Set reference of the product category
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Get or Set reference of the product price history
        /// </summary>
        public ProductPriceHistory PriceHistory { get; set; }
    }
}