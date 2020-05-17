using aspdotnetcoreapp.Resourses;
using aspdotnetcoreapp.Resourses.PostResources;
using AutoMapper;
using TalesApp.Domain;

namespace aspdotnetcoreapp.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            // Story Sets Sequence
            CreateMap<StorySetsSequence, StorySetsSequenceResourse>();
            CreateMap<SaveStorySetSequenceResource, StorySetsSequence>();

            CreateMap<StorySet, StorySetResourse>();
            CreateMap<Story, StoriesResourses>();
            CreateMap<Line, LinesResourses>();
            CreateMap<LineSequence, LineSequencesResourses>();
            CreateMap<Character, CharacterResourses>();
            CreateMap<DictionaryWord, DictionaryWordsResourses>();
        }
    }
}
