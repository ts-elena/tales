namespace TalesApp.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class LineNumber
    {
        // Navigational properties
        public Line Line { get; set; }

        // Table Columns
        [Key]
        public Guid LineId { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
