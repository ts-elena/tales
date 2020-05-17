using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnetcoreapp.Resourses
{
    public class DictionaryWordsResourses
    {
        public Guid LineId { get; set; }
        public Guid DictionaryWordId { get; set; }
        public string DictionaryWordText { get; set; }
        public DateTime WordAddedTime { get; set; }

    }
}
