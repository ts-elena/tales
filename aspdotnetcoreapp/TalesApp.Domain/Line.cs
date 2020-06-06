namespace TalesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Line
    {
        // Navigational properties
        public LineNumber LineNumber { get; set; }

        public Story Story { get; set; }

        public Character Character { get; set; }

        public List<DictionaryWord> DictionaryWords { get; set; }

        // Table Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LineId { get; set; }

        [Key]
        public Guid StoryId { get; set; }

        [Required]
        public string LineContent { get; set; }

        public Guid CharacterId { get; set; }
    }
}
