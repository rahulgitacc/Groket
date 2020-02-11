using Groket.Domain.Enums;

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
        public int FileSize { get; set; }

        /// <summary>
        /// Get or Set the filename
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Get or Set the type of the file
        /// </summary>
        public MediaType MediaType { get; set; }
    }
}