using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TalesApp.Domain
{
    public class StorySetsSequence
    {
        [Required]
        public int SetNumber { get; set; }

        public List<StorySet> StorySets { get; set; }

        [Key]
        public Guid StorySetId { get; set; }
    }
}
