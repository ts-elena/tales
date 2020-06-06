namespace TalesApp.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class LineNumber
    {
        // Navigational properties
        [ForeignKey("LineId, StoryId")]
        public Line Line { get; set; }

        // Table Columns
        [Key]
        public Guid LineId { get; set; }

        [Key]
        public Guid StoryId { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
