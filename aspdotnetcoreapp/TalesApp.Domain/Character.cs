using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TalesApp.Domain
{
    public class Character
    {
        [Key]
        public Guid CharacterId { get; set; }

        [Required]
        public string CharacterName { get; set; }

        public string CharacterAvatar { get; set; }

        public List<Line> Lines { get; set; }
    }
}
