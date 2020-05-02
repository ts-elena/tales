using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TalesApp.Domain
{
    public class Line
    {
        public Story Story { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid LineId { get; set; }

        [Required]
        public Guid StoryId { get; set; }

        [Required]
        public string LineContent { get; set; }

        public Guid CharacterId { get; set; }

        public Character Character { get; set; }

        public List<DictionaryWord> DictionaryWords { get; set; }
    }
}
