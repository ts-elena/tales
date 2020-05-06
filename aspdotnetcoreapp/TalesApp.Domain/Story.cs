using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TalesApp.Domain
{
    public class Story
    {
        // Navigation Properties
        public StorySet StorySet { get; set; }

        public List<Line> Lines { get; set; }

        // Table Columns
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid StoryId { get; set; }

        [Required]
        public string StoryName { get; set; }

        [Required]
        public string StoryCoverImage { get; set; }

        public Guid StorySetId { get; set; }
    }
}
