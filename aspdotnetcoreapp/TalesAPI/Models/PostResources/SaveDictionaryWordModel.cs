namespace TalesAPI.Models.PostModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveDictionaryWordModel
    {
        [Required]
        [MinLength(1)]
        public string DictionaryWordText { get; set; }

        [Required]
        public Guid LineId { get; set; }
    }
}
