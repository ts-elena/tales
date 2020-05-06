using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TalesApp.Domain
{
    public class LineSequence
    {
        // Navigation properties
        public Line Line { get; set; }

        [Key]
        public Guid LineId { get; set; }

        [Required]
        public int SequenceNumber { get; set; }
    }
}
