using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TalesApp.Domain
{
    public class Character
    {
        // Navigation properties
        public List<Line> Lines { get; set; }

        // Table Columns
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Guid CharacterId { get; set; }

        [Required]
        public string CharacterName { get; set; }

        public string CharacterAvatar { get; set; }
    }
}
