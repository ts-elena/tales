namespace aspdotnetcoreapp.Resourses
{
    using System;
    using TalesApp.Domain;

    public class LineResource
    {
        public Guid LineId { get; set; }
        public Guid StoryId { get; set; }
        public string LineContent { get; set; }
        public Guid CharacterId { get; set; }
    }
}
