namespace aspdotnetcoreapp.Resourses.PostResources
{
    using System.ComponentModel.DataAnnotations;

    public class SaveStorySetResource
    {
        [Required]
        public string StorySetName { get; set; }
    }
}
