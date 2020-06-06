namespace TalesAPI.Resources.PutResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateStorySetResource
    {
        [Required]
        public Guid StorySetId { get; set; }

        [Required]
        [MinLength(3)]
        public string StorySetName { get; set; }
    }
}
