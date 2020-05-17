using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnetcoreapp.Resourses.PostResources
{
    public class SaveStorySetSequenceResource
    {
        [Required]
        public int SetNumber { get; set; }
    }
}
