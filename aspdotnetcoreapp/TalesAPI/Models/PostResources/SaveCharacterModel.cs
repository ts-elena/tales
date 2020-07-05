namespace TalesAPI.Models.PostModels
{
    using System.ComponentModel.DataAnnotations;

    public class SaveCharacterModel
    {
        [Required]
        [MaxLength(254)]
        [MinLength(2)]
        public string CharacterName { get; set; }

        [MaxLength(1000)]
        public string CharacterAvatar { get; set; }
    }
}
