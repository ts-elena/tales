namespace aspdotnetcoreapp.Mapping
{
    using aspdotnetcoreapp.Resourses;
    using aspdotnetcoreapp.Resourses.PostResources;
    using AutoMapper;
    using TalesApp.Domain;

    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<StorySetNumber, StorySetNumberResource>();
            CreateMap<StorySetNumber, SaveStorySetNumberResource>();

            CreateMap<StorySet, StorySetResource>();
            CreateMap<StorySet, SaveStorySetResource>();

            CreateMap<Story, StoryResource>();
            CreateMap<Story, SaveStoryResource>();

            CreateMap<Line, LineResource>();
            CreateMap<LineNumber, LineNumberResource>();
            CreateMap<Character, CharacterResource>();
            CreateMap<DictionaryWord, DictionaryWordResource>();
        }
    }
}
