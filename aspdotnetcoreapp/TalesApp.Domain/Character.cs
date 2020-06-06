namespace TalesApp.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Character
    {
        // Navigation properties
        public List<Line> Lines { get; set; }

        // Table Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CharacterId { get; set; }

        [MaxLength(254)]
        [MinLength(2)]
        [Required]
        public string CharacterName { get; set; }

        [MaxLength(1000)]
        public string CharacterAvatar { get; set; }
    }
}
