namespace TalesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StorySet
    {
        // Navigation properties
        public List<Story> Stories { get; set; }

        public StorySetsSequence StorySetsSequence { get; set; }

        // Table Columns
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid StorySetId { get; set; }

        public string StorySetName { get; set; }
    }
}
