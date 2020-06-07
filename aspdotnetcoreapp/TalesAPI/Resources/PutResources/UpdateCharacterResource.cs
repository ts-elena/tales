namespace TalesAPI.Resources.PutResources
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UpdateCharacterResource
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
