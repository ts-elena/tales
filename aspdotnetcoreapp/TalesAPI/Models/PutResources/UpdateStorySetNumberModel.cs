namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateStorySetNumberModel
    {
        [Required]
        public Guid StorySetId { get; set; }

        [Required]
        public int SetNumber { get; set; }
    }
}
