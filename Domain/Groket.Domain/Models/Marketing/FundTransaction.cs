using Groket.Domain.Models.CommonModel;
using System;

namespace Groket.Domain.Models.Marketing
{
    /// <summary>
    /// Get or Set the fund transaction details
    /// </summary>
    public class FundTransaction : AuditableEntity
    {
        /// <summary>
        /// Get or Set who added or used the fund
        /// </summary>
        public Guid Owner { get; set; }

        /// <summary>
        /// Get or Set is the fund is credited or debited
        /// </summary>
        public bool IsCredited { get; set; }

        /// <summary>
        /// Get or Set total remaining fund
        /// </summary>
        public decimal TotalFund { get; set; }

        /// <summary>
        /// Get or set the foreign key for the Expenditure table
        /// </summary>
        public Guid? FkExpenditureId { get; set; }

        /// <summary>
        /// Get or set the relationship with the Expenditure
        /// </summary>
        public Expenditure Expenditure { get; set; }
    }
}
