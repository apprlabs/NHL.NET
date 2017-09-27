using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class GameTeam
    {
        [JsonProperty("leagueRecord")]
        public LeagueRecord LeageRecord { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }
    }
}