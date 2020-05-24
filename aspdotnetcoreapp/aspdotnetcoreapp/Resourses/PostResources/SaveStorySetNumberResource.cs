namespace aspdotnetcoreapp.Resourses.PostResources
{
    using System.ComponentModel.DataAnnotations;

    public class SaveStorySetNumberResource
    {
        [Required]
        public int SetNumber { get; set; }
    }
}
