﻿using System.Collections.Generic;
using InstaSharper.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstaSharper.ResponseWrappers
{
    internal class InstaFeedResponse : BaseLoadableResponse
    {
        [JsonProperty("is_direct_v2_enabled")]
        public bool IsDirectV2Enabled { get; set; }

        [JsonProperty(TypeNameHandling = TypeNameHandling.Auto)]
        public List<InstaMediaItemResponse> Items { get; set; } = new List<InstaMediaItemResponse>();
    }
}