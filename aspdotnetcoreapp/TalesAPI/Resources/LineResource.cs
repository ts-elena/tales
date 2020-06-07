namespace TalesAPI.Resources
{
    using System;

    public class LineResource
    {
        public string LineId { get; set; }
        public string LineContent { get; set; }
        public Guid CharacterId { get; set; }
    }
}
