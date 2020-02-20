
using Groket.Domain.Models.CommonModel;
using System;

namespace Groket.Domain.Models.ProductsModel
{
    /// <summary>
    /// Get/Set price history
    /// </summary>
    public class ProductPriceHistory : AuditableEntity
    {
        /// <summary>
        /// Get/Set product price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Get/Set old product price
        /// </summary>
        public decimal? OldPrice { get; set; }

        /// <summary>
        /// Get/Set product price changed percentage
        /// </summary>
        public string PriceChangePercentage { get; set; }

        /// <summary>
        /// Get/Set product key reference 
        /// </summary>
        public Guid FkProductId { get; set; }

        /// <summary>
        /// Get or Set Product entity to define the relationship
        /// </summary>
        public Product Product { get; set; }
    }
}
