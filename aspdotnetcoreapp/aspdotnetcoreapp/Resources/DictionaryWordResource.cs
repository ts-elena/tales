namespace TalesAPI.Resources
{
    using System;

    public class DictionaryWordResource
    {
        public Guid LineId { get; set; }
        public Guid DictionaryWordId { get; set; }
        public string DictionaryWordText { get; set; }
        public DateTime WordAddedTime { get; set; }

    }
}
