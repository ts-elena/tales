namespace TalesAPI.Resources.PostResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveStoryResource
    {
        [Required]
        public string StoryName { get; set; }

        [Required]
        public string StoryCoverImage { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public Guid StorySetId { get; set; }
    }
}
