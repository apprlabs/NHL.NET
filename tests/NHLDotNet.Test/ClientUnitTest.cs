// Copyright (c) Appr Labs. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHLDotNet.Model;
using NHLDotNet.Request;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NHLDotNet.Test
{
    [TestClass, TestCategory("Unit")]
    public class ClientUnitTest
    {
        protected class MockClient : Client
        {
            protected override async Task<string> DoRequest(string endpoint)
            {
                var filename = Regex.Replace(endpoint, @"[\/\?\&\.]", "_");
                var filePath = $"../../../Mock/{filename}.json";
                string content;
                if (File.Exists(filePath)) {
                    content = File.ReadAllText(filePath);
                } else {
                    content = base.DoRequest(endpoint).Result;
                    File.WriteAllText(filePath, content);
                }

                return await Task.Run<string>(() => { return content; });
            }
        }

        protected MockClient Client = new MockClient();

        [TestMethod]
        public void TestGetConferences()
        {
            var conferences = Client.GetConferences().Result;
            
            Assert.AreEqual(6, conferences[0].Id);
            Assert.AreEqual("Eastern", conferences[0].Name);
            Assert.AreEqual("/api/v1/conferences/6", conferences[0].Link);
            Assert.AreEqual("E", conferences[0].Abbreviation);
            Assert.AreEqual("East", conferences[0].ShortName);
            Assert.AreEqual(true, conferences[0].Active);
        }

        [TestMethod]
        public void TestGetConference()
        {
            var conference = Client.GetConference(6).Result;
            
            Assert.AreEqual(6, conference.Id);
            Assert.AreEqual("Eastern", conference.Name);
            Assert.AreEqual("/api/v1/conferences/6", conference.Link);
            Assert.AreEqual("E", conference.Abbreviation);
            Assert.AreEqual("East", conference.ShortName);
            Assert.AreEqual(true, conference.Active);
        }

        [TestMethod]
        public void TestGetDivisions()
        {
            var divisions = Client.GetDivisions().Result;
            
            Assert.AreEqual(17, divisions[0].Id);
            Assert.AreEqual("Atlantic", divisions[0].Name);
            Assert.AreEqual("/api/v1/divisions/17", divisions[0].Link);
            Assert.AreEqual("A", divisions[0].Abbreviation);
            Assert.AreEqual(6, divisions[0].Conference.Id);
            Assert.AreEqual(true, divisions[0].Active);
        }

        [TestMethod]
        public void TestGetDivision()
        {
            var division = Client.GetDivision(17).Result;
            
            Assert.AreEqual(17, division.Id);
            Assert.AreEqual("Atlantic", division.Name);
            Assert.AreEqual("/api/v1/divisions/17", division.Link);
            Assert.AreEqual("A", division.Abbreviation);
            Assert.AreEqual(6, division.Conference.Id);
            Assert.AreEqual(true, division.Active);
        }

        [TestMethod]
        public void TestGetFranchises()
        {
            var franchises = Client.GetFranchises().Result;
            
            Assert.AreEqual(1, franchises[0].FranchiseId);
            Assert.AreEqual(19171918, franchises[0].FirstSeasonId);
            Assert.AreEqual(8, franchises[0].MostRecentTeamId);
            Assert.AreEqual("Canadiens", franchises[0].TeamName);
            Assert.AreEqual("Montreal", franchises[0].LocationName);
            Assert.AreEqual("/api/v1/franchises/1", franchises[0].Link);
        }

        [TestMethod]
        public void TestGetFranchise()
        {
            var franchise = Client.GetFranchise(1).Result;
            
            Assert.AreEqual(1, franchise.FranchiseId);
            Assert.AreEqual(19171918, franchise.FirstSeasonId);
            Assert.AreEqual(8, franchise.MostRecentTeamId);
            Assert.AreEqual("Canadiens", franchise.TeamName);
            Assert.AreEqual("Montreal", franchise.LocationName);
            Assert.AreEqual("/api/v1/franchises/1", franchise.Link);
        }

        [TestMethod]
        public void TestGetGameContent()
        {
            // @TODO
        }

        [TestMethod]
        public void TestGetGameFeed()
        {
            // @TODO
        }

        [TestMethod]
        public void TestGetPlayer()
        {
            var player = Client.GetPlayer(8475722).Result;
            
            Assert.AreEqual("Jason Zucker", player.FullName);
            Assert.AreEqual("Newport Beach", player.BirthCity);
            Assert.AreEqual("USA", player.BirthCountry);
            Assert.AreEqual(30, player.Team.Id);
            Assert.AreEqual("Forward", player.PrimaryPosition.Type);
        }

        [TestMethod]
        public void TestGetSchedule()
        {
            // @TODO
        }

        [TestMethod]
        public void TestGetYesterdaysSchedule()
        {
            // @TODO
        }

        [TestMethod]
        public void TestGetTeams()
        {
            var teams = Client.GetTeams().Result;
            
            Assert.AreEqual(1, teams[0].Id);
            Assert.AreEqual("New Jersey Devils", teams[0].Name);
            Assert.AreEqual("/api/v1/teams/1", teams[0].Link);
            Assert.AreEqual("Prudential Center", teams[0].Venue.Name);
            Assert.AreEqual("America/New_York", teams[0].Venue.TimeZone.Id);
            Assert.AreEqual(18, teams[0].Division.Id);
            Assert.AreEqual(6, teams[0].Conference.Id);
            Assert.AreEqual(23, teams[0].Franchise.FranchiseId);
        }

        [TestMethod]
        public void TestGetTeam()
        {
            var team = Client.GetTeam(30).Result;
            
            Assert.AreEqual(30, team.Id);
            Assert.AreEqual("Minnesota Wild", team.Name);
            Assert.AreEqual("/api/v1/teams/30", team.Link);
            Assert.AreEqual("Xcel Energy Center", team.Venue.Name);
            Assert.AreEqual("America/Chicago", team.Venue.TimeZone.Id);
            Assert.AreEqual(16, team.Division.Id);
            Assert.AreEqual(5, team.Conference.Id);
            Assert.AreEqual(37, team.Franchise.FranchiseId);
        }
    }
}
