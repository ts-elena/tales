using System.ComponentModel.DataAnnotations;

namespace TalesAPI.Models.PostModels
{
    using System;

    public class SaveLineModel
    {
        [Required]
        public Guid StoryId { get; set; }

        [Required]
        public string LineContent { get; set; }

        [Required]
        public Guid CharacterId { get; set; }
    }
}
