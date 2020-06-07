namespace TalesAPI.Resources.PutResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateStoryResource
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
