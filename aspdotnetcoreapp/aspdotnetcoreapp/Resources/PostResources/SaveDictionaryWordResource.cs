namespace TalesAPI.Resources.PostResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveDictionaryWordResource
    {
        [Required]
        [MinLength(1)]
        public string DictionaryWordText { get; set; }

        [Required]
        public Guid LineId { get; set; }
    }
}
