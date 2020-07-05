namespace TalesAPI.Mapping
{
    using AutoMapper;
    using TalesAPI.Models;
    using TalesAPI.Models.PostModels;
    using TalesApp.Domain;
    using TalesAPI.Models.PutModels;

    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveStorySetNumberModel, StorySetNumber>();
            CreateMap<StorySetNumberModel, StorySetNumber>();
            CreateMap<UpdateStorySetNumberModel, StorySetNumber>();

            CreateMap<StorySetModel, StorySet>();
            CreateMap<SaveStorySetModel, StorySet>();
            CreateMap<UpdateStorySetModel, StorySet>();

            CreateMap<StoryModel, Story>();
            CreateMap<SaveStoryModel, Story>();
            CreateMap<UpdateStoryModel, Story>();

            CreateMap<LineNumberModel, LineNumber>();
            CreateMap<SaveLineNumberModel, LineNumber>();
            CreateMap<UpdateLineNumberModel, LineNumber>();

            CreateMap<LineModel, Line>();
            CreateMap<SaveLineModel, Line>();
            CreateMap<UpdateLineModel, Line>();

            CreateMap<DictionaryWordModel, DictionaryWord>();
            CreateMap<SaveDictionaryWordModel, DictionaryWord>();
            CreateMap<UpdateDictionaryWordModel, DictionaryWord>();

            CreateMap<CharacterModel, Character>();
            CreateMap<SaveCharacterModel, Character>();
            CreateMap<UpdateCharacterModel, Character>();
        }
    }
}
