namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateStorySetModel
    {
        [Required]
        public Guid StorySetId { get; set; }

        [Required]
        [MinLength(3)]
        public string StorySetName { get; set; }
    }
}
