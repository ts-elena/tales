using TalesAPI.Models.PutModels;

namespace TalesAPI.Mapping
{
    using AutoMapper;
    using TalesAPI.Models;
    using TalesAPI.Models.PostModels;
    using TalesApp.Domain;

    public class ModelToModelProfile : Profile
    {
        public ModelToModelProfile()
        {
            CreateMap<StorySetNumber, StorySetNumberModel>();
            CreateMap<StorySetNumber, SaveStorySetNumberModel>();
            CreateMap<StorySetNumber, UpdateStorySetNumberModel>();

            CreateMap<StorySet, StorySetModel>();
            CreateMap<StorySet, SaveStorySetModel>();
            CreateMap<StorySet, UpdateStorySetModel>();

            CreateMap<Story, StoryModel>();
            CreateMap<Story, SaveStoryModel>();
            CreateMap<Story, UpdateStoryModel>();

            CreateMap<Line, LineModels>();
            CreateMap<Line, SaveLineModel>();
            CreateMap<Line, UpdateLineModel>();

            CreateMap<LineNumber, LineNumberModels>();
            CreateMap<LineNumber, SaveLineNumberModel>();
            CreateMap<LineNumber, UpdateLineNumberModel>();

            CreateMap<Character, CharacterModels>();
            CreateMap<Character, SaveCharacterModel>();
            CreateMap<Character, UpdateCharacterModel>();

            CreateMap<DictionaryWord, DictionaryWordModels>();
            CreateMap<DictionaryWord, SaveDictionaryWordModel>();
            CreateMap<DictionaryWord, UpdateDictionaryWordModel>();
        }
    }
}
