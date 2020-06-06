using System.ComponentModel.DataAnnotations;

namespace TalesAPI.Resources.PostResources
{
    using System;

    public class SaveLineResource
    {
        [Required]
        public Guid StoryId { get; set; }

        [Required]
        public string LineContent { get; set; }

        [Required]
        public Guid CharacterId { get; set; }
    }
}
