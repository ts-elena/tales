namespace TalesAPI.Resources
{
    using System;

    public class LineNumberResource
    {
        public  Guid StoryId { get; set; }
        public Guid LineId { get; set; }
        public int Number { get; set; }
        public bool IsLast { get; set; }
    }
}
