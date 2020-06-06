using TalesAPI.Resources.PutResources;

namespace TalesAPI.Mapping
{
    using AutoMapper;
    using TalesAPI.Resources;
    using TalesAPI.Resources.PostResources;
    using TalesApp.Domain;

    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveStorySetNumberResource, StorySetNumber>();
            CreateMap<StorySetNumberResource, StorySetNumber>();
            CreateMap<UpdateStorySetNumberResource, StorySetNumber>();

            CreateMap<StorySetResource, StorySet>();
            CreateMap<SaveStorySetResource, StorySet>();
            CreateMap<UpdateStorySetResource, StorySet>();

            CreateMap<StoryResource, Story>();
            CreateMap<SaveStoryResource, Story>();
            CreateMap<UpdateStoryResource, Story>();

            CreateMap<LineNumberResource, LineNumber>();
            CreateMap<SaveLineNumberResource, LineNumber>();
            CreateMap<UpdateLineNumberResource, LineNumber>();

            CreateMap<LineResource, Line>();
            CreateMap<SaveLineResource, Line>();
            CreateMap<UpdateLineResource, Line>();

            CreateMap<DictionaryWordResource, DictionaryWord>();
            CreateMap<SaveDictionaryWordResource, DictionaryWord>();
            CreateMap<UpdateDictionaryWordResource, DictionaryWord>();

            CreateMap<CharacterResource, Character>();
            CreateMap<SaveCharacterResource, Character>();
            CreateMap<UpdateCharacterResource, Character>();
        }
    }
}
