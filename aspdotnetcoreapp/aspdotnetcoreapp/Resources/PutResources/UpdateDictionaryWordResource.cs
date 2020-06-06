namespace TalesAPI.Resources.PutResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateDictionaryWordResource
    {
        [MinLength(1)]
        public string DictionaryWordText { get; set; }

        [Required]
        public Guid LineId { get; set; }
    }
}
