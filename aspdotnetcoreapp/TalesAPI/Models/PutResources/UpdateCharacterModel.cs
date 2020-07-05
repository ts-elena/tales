namespace TalesAPI.Models.PutModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateCharacterModel
    {
        [Key]
        [Required]
        public Guid CharacterId { get; set; }

        [Required]
        [MaxLength(254)]
        [MinLength(2)]
        public string CharacterName { get; set; }

        [Required]
        [MaxLength(1000)]
        public string CharacterAvatar { get; set; }
    }
}
