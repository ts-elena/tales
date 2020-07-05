namespace TalesAPI.Models
{
    using System;

    public class LineNumberModel
    {
        public  Guid StoryId { get; set; }
        public Guid LineId { get; set; }
        public int Number { get; set; }
        public bool IsLast { get; set; }
    }
}
