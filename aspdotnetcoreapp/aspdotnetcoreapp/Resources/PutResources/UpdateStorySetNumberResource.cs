namespace TalesAPI.Resources.PutResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateStorySetNumberResource
    {
        [Required]
        public Guid StorySetId { get; set; }

        [Required]
        public int SetNumber { get; set; }
    }
}
