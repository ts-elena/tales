using TalesAPI.Resources.PutResources;

namespace TalesAPI.Mapping
{
    using AutoMapper;
    using TalesAPI.Resources;
    using TalesAPI.Resources.PostResources;
    using TalesApp.Domain;

    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<StorySetNumber, StorySetNumberResource>();
            CreateMap<StorySetNumber, SaveStorySetNumberResource>();
            CreateMap<StorySetNumber, UpdateStorySetNumberResource>();

            CreateMap<StorySet, StorySetResource>();
            CreateMap<StorySet, SaveStorySetResource>();
            CreateMap<StorySet, UpdateStorySetResource>();

            CreateMap<Story, StoryResource>();
            CreateMap<Story, SaveStoryResource>();
            CreateMap<Story, UpdateStoryResource>();

            CreateMap<Line, LineResource>();
            CreateMap<Line, SaveLineResource>();
            CreateMap<Line, UpdateLineResource>();

            CreateMap<LineNumber, LineNumberResource>();
            CreateMap<LineNumber, SaveLineNumberResource>();
            CreateMap<LineNumber, UpdateLineNumberResource>();

            CreateMap<Character, CharacterResource>();
            CreateMap<Character, SaveCharacterResource>();
            CreateMap<Character, UpdateCharacterResource>();

            CreateMap<DictionaryWord, DictionaryWordResource>();
            CreateMap<DictionaryWord, SaveDictionaryWordResource>();
            CreateMap<DictionaryWord, UpdateDictionaryWordResource>();
        }
    }
}
