﻿namespace TalesApp.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class DictionaryWord
    {
        [Key]
        public Guid DictionaryWordId { get; set; }

        public Line Line { get; set; }

        public Guid LineId { get; set; }

        [Required]
        public string DictionaryWordText { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public DateTime WordAddedTime { get; set; }
    }
}
