namespace TalesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Story
    {
        // Navigational Properties
        public StorySet StorySet { get; set; }

        public List<Line> Lines { get; set; }

        // Table Columns
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid StoryId { get; set; }

        [Required]
        public string StoryName { get; set; }

        [Required]
        public string StoryCoverImage { get; set; }

        public Guid StorySetId { get; set; }
    }
}
