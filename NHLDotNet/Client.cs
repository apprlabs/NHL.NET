using NHLDotNet.Exception;
using NHLDotNet.Model;
using NHLDotNet.Request;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace NHLDotNet
{
    /// <summary>
    /// The client to work with the NHL API
    /// </summary>
    public class Client
    {
        private readonly string _baseUri;
        
        /// <summary>
        /// The HTTP Client for interacting with the service
        /// </summary>
        protected readonly HttpClient _httpClient;

        public Client(string apiUrl = null, HttpClientHandler httpClientHandler = null)
        {
            _baseUri = apiUrl == null ? "https://statsapi.web.nhl.com/api/v1/" : apiUrl;
            _httpClient = httpClientHandler == null ? new HttpClient() : new HttpClient(httpClientHandler);
        }

        /// <summary>
        /// Gets all active conferences
        /// </summary>
        /// <returns>The conference</returns>
        public async Task<List<Conference>> GetConferences()
        {
            return JsonConvert.DeserializeObject<ConferenceResponse>(
                await DoRequest("conferences")
            ).Conferences;
        }

        /// <summary>
        /// Gets a specific conference
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to retrieve</param>
        /// <returns>The conferences</returns>
        public async Task<Conference> GetConference(int conferenceId)
        {
            return JsonConvert.DeserializeObject<ConferenceResponse>(
                await DoRequest($"conferences/{conferenceId}")
            ).Conferences[0];
        }

        /// <summary>
        /// Gets all active divisions
        /// </summary>
        /// <returns>The division</returns>
        public async Task<List<Division>> GetDivisions()
        {
            return JsonConvert.DeserializeObject<DivisionResponse>(
                await DoRequest("divisions")
            ).Divisions;
        }

        /// <summary>
        /// Gets a specific division
        /// </summary>
        /// <param name="divisionId">The ID of the division to retrieve</param>
        /// <returns>The divisions</returns>
        public async Task<Division> GetDivision(int divisionId)
        {
            return JsonConvert.DeserializeObject<DivisionResponse>(
                await DoRequest($"divisions/{divisionId}")
            ).Divisions[0];
        }

        /// <summary>
        /// Gets all active franchises
        /// </summary>
        /// <returns>The franchise</returns>
        public async Task<List<Franchise>> GetFranchises()
        {
            return JsonConvert.DeserializeObject<FranchiseResponse>(
                await DoRequest("franchises")
            ).Franchises;
        }

        /// <summary>
        /// Gets a specific franchise
        /// </summary>
        /// <param name="franchiseId">The ID of the franchise to retrieve</param>
        /// <returns>The franchises</returns>
        public async Task<Franchise> GetFranchise(int franchiseId)
        {
            return JsonConvert.DeserializeObject<FranchiseResponse>(
                await DoRequest($"franchises/{franchiseId}")
            ).Franchises[0];
        }

        /// <summary>
        /// Gets the games for today's date
        /// </summary>
        /// <returns>The games for today's date</returns>
        public async Task<Date> GetSchedule()
        {
            return JsonConvert.DeserializeObject<ScheduleResponse>(
                await DoRequest("schedule")
            ).Dates[0];
        }

        /// <summary>
        /// Gets the games by the request specified
        /// </summary>
        /// <param name="request">The options to retrieve games by</param>
        /// <returns>Games matching the request</returns>
        public async Task<List<Date>> GetSchedule(ScheduleRequest request)
        {
            return JsonConvert.DeserializeObject<ScheduleResponse>(
                await DoRequest($"schedule?{request}")
            ).Dates;
        }

        /// <summary>
        /// Gets all active teams
        /// </summary>
        /// <returns>The team</returns>
        public async Task<List<Team>> GetTeams()
        {
            return JsonConvert.DeserializeObject<TeamResponse>(
                await DoRequest("teams")
            ).Teams;
        }

        /// <summary>
        /// Gets a specific team
        /// </summary>
        /// <param name="teamId">The ID of the team to retrieve</param>
        /// <returns>The teams</returns>
        public async Task<Team> GetTeam(int teamId)
        {
            return JsonConvert.DeserializeObject<TeamResponse>(
                await DoRequest($"teams/{teamId}")
            ).Teams[0];
        }

        /// <summary>
        /// Perform the request to the API
        /// </summary>
        /// <param name="endpoint">The endpoint to get data from</param>
        /// <returns>The result from the request</returns>
        protected async Task<string> DoRequest(string endpoint)
        {
            try 
            {
                return await _httpClient.GetStringAsync($"{_baseUri}{endpoint}");
            } 
            catch 
            {
                throw new RequestException("Service request failed");
            }
        }
    }
}
