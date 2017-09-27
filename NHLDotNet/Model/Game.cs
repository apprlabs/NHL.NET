using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NHLDotNet.Model
{
    public class Game
    {
        [JsonProperty("gamePk")]
        public int GamePrimaryKey { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("gameDate")]
        public DateTime GameDate { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("teams")]
        public Teams Teams { get; set; }

        [JsonProperty("linescore")]
        public LineScore LineScore { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        [JsonProperty("tickets")]
        public List<Ticket> Tickets { get; set; }

        [JsonProperty("content")]
        public Content Content { get; set; }
    }
}