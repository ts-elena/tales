namespace TalesApp.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StorySetNumber
    {
        // Navigational Properties
        public StorySet StorySet { get; set; }

        // Table Columns
        [Key]
        public Guid StorySetId { get; set; }
        
        [Required]
        public int SetNumber { get; set; }
    }
}
