using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TalesApp.Domain
{
    public class StorySetsSequence
    {
        [Required]
        public int SetNumber { get; set; }

        public StorySet StorySet { get; set; }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid StorySetId { get; set; }
    }
}
