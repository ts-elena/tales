﻿namespace TalesAPI.Models
{
    using System;

    public class DictionaryWordModel
    {
        public Guid LineId { get; set; }
        public Guid DictionaryWordId { get; set; }
        public string DictionaryWordText { get; set; }
        public DateTime WordAddedTime { get; set; }

    }
}
