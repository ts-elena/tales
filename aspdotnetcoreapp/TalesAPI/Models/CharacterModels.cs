using System;

namespace TalesAPI.Models
{
    public class CharacterModel
    {
        public Guid CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string CharacterAvatar { get; set; }
    }
}
