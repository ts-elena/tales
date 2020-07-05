namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateStoryModel
    {
        [Required]
        public Guid StoryId { get; set; }

        [Required]
        [MinLength(3)]
        public string StoryName { get; set; }

        [Required]
        public string StoryCoverImage { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public Guid StorySetId { get; set; }
    }
}
