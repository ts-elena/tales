namespace aspdotnetcoreapp.Resourses.PostResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveStoryResource
    {
        [Required]
        public string StoryName { get; set; }

        [Required]
        public string StoryCoverImage { get; set; }

        public Guid StorySetId { get; set; }
    }
}
