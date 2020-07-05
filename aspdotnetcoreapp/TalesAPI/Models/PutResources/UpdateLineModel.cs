namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateLineModel
    {
        [Required]
        public Guid StoryId { get; set; }

        [Required]
        public Guid LineId { get; set; }

        [Required]
        [MinLength(1)]
        public string LineContent { get; set; }

        [Required]
        public Guid CharacterId { get; set; }
    }
}
