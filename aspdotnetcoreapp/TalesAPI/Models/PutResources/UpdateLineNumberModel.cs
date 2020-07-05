namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;

    public class UpdateLineNumberModel
    {
        [Required]
        public  Guid LineId { get; set; }

        [Required]
        public Guid StoryId { get; set; }

        [Required]
        [NotNull]
        public int Number { get; set; }

        [Required]
        public bool IsLast { get; set; }
    }
}
