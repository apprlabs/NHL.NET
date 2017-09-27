using NHLDotNet.Exception;
using NHLDotNet.Model;
using NHLDotNet.Request;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace NHLDotNet
{
    /// <summary>
    /// The client to work with the NHL API
    /// </summary>
    public class Client
    {
        const string URL = "https://statsapi.web.nhl.com/api/v1/";

        /// <summary>
        /// The HTTP Client for interacting with the service
        /// </summary>
        protected HttpClient HttpClient = new HttpClient();

        /// <summary>
        /// Gets all active conferences
        /// </summary>
        /// <returns>The conference</returns>
        public List<Conference> GetConferences()
        {
            return JsonConvert.DeserializeObject<ConferenceResponse>(
                DoRequest("conferences")
            ).Conferences;
        }

        /// <summary>
        /// Gets a specific conference
        /// </summary>
        /// <param name="conferenceId">The ID of the conference to retrieve</param>
        /// <returns>The conferences</returns>
        public Conference GetConference(int conferenceId)
        {
            return JsonConvert.DeserializeObject<ConferenceResponse>(
                DoRequest(String.Format("{0}{1}", "conferences/", conferenceId))
            ).Conferences[0];
        }

        /// <summary>
        /// Gets all active divisions
        /// </summary>
        /// <returns>The division</returns>
        public List<Division> GetDivisions()
        {
            return JsonConvert.DeserializeObject<DivisionResponse>(
                DoRequest("divisions")
            ).Divisions;
        }

        /// <summary>
        /// Gets a specific division
        /// </summary>
        /// <param name="divisionId">The ID of the division to retrieve</param>
        /// <returns>The divisions</returns>
        public Division GetDivision(int divisionId)
        {
            return JsonConvert.DeserializeObject<DivisionResponse>(
                DoRequest(String.Format("{0}{1}", "divisions/", divisionId))
            ).Divisions[0];
        }

        /// <summary>
        /// Gets all active franchises
        /// </summary>
        /// <returns>The franchise</returns>
        public List<Franchise> GetFranchises()
        {
            return JsonConvert.DeserializeObject<FranchiseResponse>(
                DoRequest("franchises")
            ).Franchises;
        }

        /// <summary>
        /// Gets a specific franchise
        /// </summary>
        /// <param name="franchiseId">The ID of the franchise to retrieve</param>
        /// <returns>The franchises</returns>
        public Franchise GetFranchise(int franchiseId)
        {
            return JsonConvert.DeserializeObject<FranchiseResponse>(
                DoRequest(String.Format("{0}{1}", "franchises/", franchiseId))
            ).Franchises[0];
        }

        /// <summary>
        /// Gets the games for today's date
        /// </summary>
        /// <returns>The games for today's date</returns>
        public Date GetSchedule()
        {
            return JsonConvert.DeserializeObject<ScheduleResponse>(
                DoRequest("schedule")
            ).Dates[0];
        }

        /// <summary>
        /// Gets the games by the request specified
        /// </summary>
        /// <param name="request">The options to retrieve games by</param>
        /// <returns>Games matching the request</returns>
        public List<Date> GetSchedule(ScheduleRequest request)
        {
            return JsonConvert.DeserializeObject<ScheduleResponse>(
                DoRequest(String.Format("{0}?{1}", "schedule", request.ToString()))
            ).Dates;
        }

        /// <summary>
        /// Gets all active teams
        /// </summary>
        /// <returns>The team</returns>
        public List<Team> GetTeams()
        {
            return JsonConvert.DeserializeObject<TeamResponse>(
                DoRequest("teams")
            ).Teams;
        }

        /// <summary>
        /// Gets a specific team
        /// </summary>
        /// <param name="teamId">The ID of the team to retrieve</param>
        /// <returns>The teams</returns>
        public Team GetTeam(int teamId)
        {
            return JsonConvert.DeserializeObject<TeamResponse>(
                DoRequest(String.Format("{0}{1}", "teams/", teamId))
            ).Teams[0];
        }

        /// <summary>
        /// Perform the request to the API
        /// </summary>
        /// <param name="endpoint">The endpoint to get data from</param>
        /// <returns>The result from the request</returns>
        protected string DoRequest(string endpoint)
        {
            try {
                return HttpClient.GetStringAsync(String.Format("{0}{1}", URL, endpoint)).Result;
            } catch {
                throw new RequestException("Service request failed");
            }
        }
    }
}
