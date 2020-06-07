namespace TalesAPI.Resources
{
    using System;

    public class StoryResource
    {
        public Guid StoryId { get; set; }
        public string StoryName { get; set; }
        public string StoryCoverImage { get; set; }
        public bool IsActive { get; set; }
        public Guid StorySetId { get; set; }
    }
}
