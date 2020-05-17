using aspdotnetcoreapp.Resourses;
using aspdotnetcoreapp.Resourses.PostResources;
using AutoMapper;
using TalesApp.Domain;

namespace aspdotnetcoreapp.Mapping
{
    public class ResourceToModelProfile: Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<StorySetsSequence, StorySetsSequenceResourse>();
            CreateMap<StorySetsSequenceResourse, StorySetsSequence>();
        }
    }
}
