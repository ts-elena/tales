namespace TalesApp.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DictionaryWord
    {
        // Navigational properties
        public Line Line { get; set; }

        // Table columns
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid DictionaryWordId { get; set; }

        [Required]
        public string DictionaryWordText { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public DateTime WordAddedTime { get; set; }

        public Guid LineId { get; set; }
    }
}
