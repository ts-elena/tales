namespace TalesAPI.Models
{
    using System;

    public class LineModel
    {
        public string LineId { get; set; }
        public string LineContent { get; set; }
        public Guid CharacterId { get; set; }
    }
}
