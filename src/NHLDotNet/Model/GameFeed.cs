// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    /// <summary>
    /// Represents the feed from a game
    /// </summary>
    public class GameFeed
    {
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("gamePk")]
        public long GameID { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("metaData")]
        public MetaData MetaData { get; set; }

        [JsonProperty("gameData")]
        public GameData GameData { get; set; }

        [JsonProperty("liveData")]
        public LiveData LiveData { get; set; }
    }
}