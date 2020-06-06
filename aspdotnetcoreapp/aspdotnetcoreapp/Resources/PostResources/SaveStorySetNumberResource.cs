namespace TalesAPI.Resources.PostResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveStorySetNumberResource
    {
        [Required]
        public Guid StorySetId { get; set; }

        [Required]
        public int SetNumber { get; set; }
    }
}
