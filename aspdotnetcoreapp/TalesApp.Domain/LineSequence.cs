using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TalesApp.Domain
{
    public class LineSequence
    {
        [Required]
        public int LineNumber { get; set; }

        public Line Line { get; set; }

        [Key]
        public Guid LineId { get; set; }
    }
}
