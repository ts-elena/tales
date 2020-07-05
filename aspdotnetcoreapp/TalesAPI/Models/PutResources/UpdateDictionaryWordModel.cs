namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateDictionaryWordModel
    {
        [MinLength(1)]
        public string DictionaryWordText { get; set; }

        [Required]
        public Guid LineId { get; set; }
    }
}
