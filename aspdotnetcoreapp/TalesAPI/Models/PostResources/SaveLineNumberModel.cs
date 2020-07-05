namespace TalesAPI.Models.PostModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SaveLineNumberModel
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
