using System;
using System.Collections.Generic;

namespace NHLDotNet.Request
{
    /// <summary>
    /// Represents the querystring parameters to the shcedule endpoint
    /// </summary>
    public class ScheduleRequest
    {
        /// <summary>
        /// The types of games available to query for
        /// </summary>
        public enum GameType {PreSeason, RegularSeason, PostSeason};

        /// <summary>
        /// The params to query by
        /// </summary>
        protected Dictionary<string, string> Params = new Dictionary<string, string>();

        /// <summary>
        /// The options to expand in the response
        /// </summary>
        protected List<ExpandOption> ExpandOptions = new List<ExpandOption>();

        /// <summary>
        /// Search for a specific game by it's ID
        /// </summary>
        /// <param name="gameId">The game ID to retrieve</param>
        public void SetGameId(int gameId)
        {
            Params["gamePk"] = gameId.ToString();
        }

        /// <summary>
        /// Search for games by their type (`GameType.PreSeason`, etc.)
        /// </summary>
        /// <param name="gameType">The type of game to retrieve</param>
        public void SetGameType(GameType gameType)
        {
            var type = "";
            switch (gameType) {
                case GameType.PreSeason: 
                    type = "PR"; 
                    break;
                
                case GameType.RegularSeason: 
                    type = "R"; 
                    break;
                
                case GameType.PostSeason: 
                    type = "P"; 
                    break;
            }

            Params["gameType"] = type;
        }

        /// <summary>
        /// Search for games on a specific date
        /// </summary>
        /// <param name="date">The date to retrieve games for</param>
        public void SetDate(DateTime date)
        {
            // clear out season if we're passing in a specific date
            if (Params.ContainsKey("season")) {
                Params.Remove("season");
            }

            Params["date"] = date.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// Adds an option to expand on in the response
        /// </summary>
        /// <param name="option">The new option to expand in the response</param>
        public void AddExpandOption(ExpandOption option)
        {
            ExpandOptions.Add(option);
        }

        /// <summary>
        /// Removes an option to expand in the response
        /// </summary>
        /// <param name="option">The option to stop expanding in the response</param>
        public void RemoveExpandOption(ExpandOption option)
        {
            ExpandOptions.Remove(option);
        }

        /// <summary>
        /// Updates the options to expand in the response
        /// </summary>
        /// <param name="options">The options to expand in the response</param>
        public void SetExpandOptions(List<ExpandOption> options)
        {
            ExpandOptions = options;
        }

        /// <summary>
        /// Search for games in a specific season
        /// </summary>
        /// <param name="seasonId">The season ID to retrieve games for</param>
        public void SetSeason(int seasonId)
        {
            // clear out the date if we're requesting an entire season
            if (Params.ContainsKey("date")) {
                Params.Remove("date");
            }

            Params["season"] = seasonId.ToString();
        }

        /// <summary>
        /// Retrieves a querystring representation of this class
        /// </summary>
        /// <returns>The formatted querystring</returns>
        public override string ToString()
        {
            // add any params to query by
            List<string> query = new List<string>();
            foreach (var param in Params) {
                query.Add(String.Format("{0}={1}", param.Key, param.Value));
            }

            // add anything we need to expand as well
            if (ExpandOptions.Count > 0) {
                query.Add(String.Format("expand={0}", ExpandOptions.ToString()));
            }

            return String.Join('&', query);
        }
    }
}