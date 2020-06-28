namespace TalesAPI.Resources.PostResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveLineNumberResource
    {
        [Required]
        public Guid StoryId { get; set; }

        [Required]
        public  Guid LineId { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public bool IsLast { get; set; }
    }
}
