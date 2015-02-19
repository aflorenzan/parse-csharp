//
// UploadInfo.cs
//
// Author:
//       Alberto Estrella <alberto.estrella@maven.do>
//
// Copyright (c) 2014 2014
using System;
using Newtonsoft.Json.Serialization;

namespace Parse.Api.Models
{
    public class UploadInfo
    {
        public UploadInfo(string name, string url)
        {
            Name = name;
            Url = url;
        }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("url")]
        public string Url { get; private set; }
    }
}

