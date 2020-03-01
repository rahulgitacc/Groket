using Groket.Domain.Enums;
using Groket.Domain.Models.CommonModel;

namespace Groket.Domain.Models.Marketing
{
    /// <summary>
    /// Get or Set the expenditures
    /// </summary>
    public class Expenditure : AuditableEntity
    {
        /// <summary>
        /// Get or Set expenditure title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Get or Set type of expenditure
        /// </summary>
        public ExpenditureType ExpenditureType { get; set; }

        /// <summary>
        /// Get or Set comments
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Get or Set the cost
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Get or set the relationship with the marketing
        /// </summary>
        public Marketing Marketing { get; set; }

        /// <summary>
        /// Get or set the relationship with the fund transaction
        /// </summary>
        public FundTransaction FundTransaction { get; set; }
    }
}