namespace aspdotnetcoreapp.Mapping
{
    using aspdotnetcoreapp.Resourses;
    using aspdotnetcoreapp.Resourses.PostResources;
    using AutoMapper;
    using TalesApp.Domain;

    public class ResourceToModelProfile: Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveStorySetNumberResource, StorySetNumber>();
            CreateMap<StorySetNumberResource, StorySetNumber>();

            CreateMap<StorySetResource, StorySet>();
            CreateMap<SaveStorySetResource, StorySet>();

            CreateMap<StoryResource, Story>();
            CreateMap<SaveStoryResource, Story>();

            CreateMap<LineNumberResource, LineNumber>();
            CreateMap<LineResource, Line>();
            CreateMap<DictionaryWordResource, DictionaryWord>();
            CreateMap<CharacterResource, Character>();
        }
    }
}
