namespace TalesAPI.Resources.PostResources
{
    using System.ComponentModel.DataAnnotations;

    public class SaveStorySetResource
    {
        [Required]
        [MinLength(3)]
        public string StorySetName { get; set; }
    }
}
