namespace TalesAPI.Models.PostModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveStorySetNumberModel
    {
        [Required]
        public Guid StorySetId { get; set; }

        [Required]
        public int SetNumber { get; set; }
    }
}
