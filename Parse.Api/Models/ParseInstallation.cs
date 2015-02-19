//
// ParseInstallation.cs
//
// Author:
//       Alberto Estrella <alberto.estrella@maven.do>
//
// Copyright (c) 2014 2012-2014
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Parse.Api.Models
{
    public class ParseInstallation : ParseObject
    {
        [JsonProperty("badge", NullValueHandling = NullValueHandling.Ignore)]
        public int? Badge { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("channels")]
        public IList<string> Channels { get; set; }

        [JsonProperty("installationId", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallationId { get; set; }

        [JsonProperty("timeZone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        [JsonProperty("pushType", NullValueHandling = NullValueHandling.Ignore)]
        public string PushType { get; set; }
    }
}

