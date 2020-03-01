
using Groket.Domain.Enums;
using Groket.Domain.Models.CommonModel;
using System;

namespace Groket.Domain.Models.Marketing
{
    /// <summary>
    /// Get or Set the Marketing properties
    /// </summary>
    public class Marketing : AuditableEntity
    {
        /// <summary>
        /// Get or Set the name of the marketing
        /// </summary>
        public string CampaignName { get; set; }

        /// <summary>
        /// Get or Set the name of the Campaigning area
        /// </summary>
        public string CampaigningArea { get; set; }

        /// <summary>
        /// Get or Set the assigned person id
        /// </summary>
        public Guid AssignedTo { get; set; }

        /// <summary>
        /// Get or Set the date of the campaigning
        /// </summary>
        public DateTime ScheduleDate { get; set; }

        /// <summary>
        /// Get or Set the time of the campaigning
        /// </summary>
        public string ScheduleTime { get; set; }

        /// <summary>
        /// Get or Set the mode of the marketing
        /// </summary>
        public MarketingMode MarketingMode { get; set; }

        /// <summary>
        /// Get or set the campaigning status
        /// </summary>
        public CampaignStatus CampaignStatus { get; set; }

        /// <summary>
        /// Get or set the foreign key for the Expenditure table
        /// </summary>
        public Guid FkExpenditureId { get; set; }

        /// <summary>
        /// Get or set the relationship with the Expenditure
        /// </summary>
        public Expenditure Expenditure { get; set; }

    }
}
