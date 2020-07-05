namespace TalesAPI.Mapping
{
    using AutoMapper;
    using TalesAPI.Models;
    using TalesAPI.Models.PostModels;
    using TalesApp.Domain;
    using TalesAPI.Models.PutModels;

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

            CreateMap<Line, LineModel>();
            CreateMap<Line, SaveLineModel>();
            CreateMap<Line, UpdateLineModel>();

            CreateMap<LineNumber, LineNumberModel>();
            CreateMap<LineNumber, SaveLineNumberModel>();
            CreateMap<LineNumber, UpdateLineNumberModel>();

            CreateMap<Character, CharacterModel>();
            CreateMap<Character, SaveCharacterModel>();
            CreateMap<Character, UpdateCharacterModel>();

            CreateMap<DictionaryWord, DictionaryWordModel>();
            CreateMap<DictionaryWord, SaveDictionaryWordModel>();
            CreateMap<DictionaryWord, UpdateDictionaryWordModel>();
        }
    }
}
