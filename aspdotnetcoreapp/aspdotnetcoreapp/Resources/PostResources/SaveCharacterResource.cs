namespace TalesAPI.Resources.PostResources
{
    using System.ComponentModel.DataAnnotations;

    public class SaveCharacterResource
    {
        [Required]
        [MaxLength(254)]
        [MinLength(2)]
        public string CharacterName { get; set; }

        [MaxLength(1000)]
        public string CharacterAvatar { get; set; }
    }
}
