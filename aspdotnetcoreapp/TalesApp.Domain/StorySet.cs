namespace TalesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class StorySet
    {
        [Key]
        public Guid StorySetId { get; set; }

        public string StorySetName { get; set; }

        public List<Story> Stories { get; set; }

        public StorySetsSequence StorySetsSequence { get; set; }
    }
}
