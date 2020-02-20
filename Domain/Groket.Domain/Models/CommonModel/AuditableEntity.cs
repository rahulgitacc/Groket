using System;
using Groket.Domain;

namespace Groket.Domain.Models.CommonModel
{
    /// <summary>
    /// Class for tracking the activity
    /// </summary>
    public class AuditableEntity
    {
        public AuditableEntity()
        {
            RowStatus = (int)Enums.RowStatus.Active;
        }

        /// <summary>
        /// Get or Set entity id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get or Set entry created by value
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Get or Set entity created date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Get or Set entity last modified user
        /// </summary>
        public Guid? LastModifiedBy { get; set; }

        /// <summary>
        /// Get or Set entity last modified date
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Get or Set entity RowStatus
        /// </summary>
        public int RowStatus { get; set; }
    }
}