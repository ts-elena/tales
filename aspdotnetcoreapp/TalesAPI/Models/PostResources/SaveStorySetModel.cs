namespace TalesAPI.Models.PostModels
{
    using System.ComponentModel.DataAnnotations;

    public class SaveStorySetModel
    {
        [Required]
        [MinLength(3)]
        public string StorySetName { get; set; }
    }
}
