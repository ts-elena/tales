namespace TalesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StorySet
    {
        // Navigational properties
        public List<Story> Stories { get; set; }

        public StorySetNumber StorySetNumber { get; set; }

        // Table Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StorySetId { get; set; }

        [Required]
        public string StorySetName { get; set; }
    }
}
