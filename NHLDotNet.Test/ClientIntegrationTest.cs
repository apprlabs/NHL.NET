using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHLDotNet.Model;
using NHLDotNet.Request;
using System;
using System.Collections.Generic;

namespace NHLDotNet.Test
{
    [TestClass, TestCategory("Integration")]
    public class ClientIntegrationTest
    {
        protected Client Client = new Client();

        [TestMethod]
        public void TestGetConferences()
        {
            List<Conference> conferences = Client.GetConferences();
            Assert.IsTrue(conferences.Count > 0);
        }

        [TestMethod]
        public void TestGetConference()
        {
            Assert.AreEqual("Eastern", Client.GetConference(6).Name);
        }

        [TestMethod]
        public void TestGetDivisions()
        {
            List<Division> divisions = Client.GetDivisions();
            Assert.IsTrue(divisions.Count > 0);
        }

        [TestMethod]
        public void TestGetDivision()
        {
            Assert.AreEqual("Central", Client.GetDivision(16).Name);
        }

        [TestMethod]
        public void TestGetFranchises()
        {
            List<Franchise> franchises = Client.GetFranchises();
            Assert.IsTrue(franchises.Count > 0);
        }

        [TestMethod]
        public void TestGetFranchise()
        {
            Assert.AreEqual("Wild", Client.GetFranchise(37).TeamName);
        }

        [TestMethod]
        public void TestGetTodaysSchedule()
        {
            Date today = Client.GetSchedule();
            // Assert.AreEqual(DateTime.Now.ToString("yyyy-MM-dd"), today.DateString);
        }

        [TestMethod]
        public void TestGetSeasonsSchedule()
        {
            var request = new ScheduleRequest();
            var seasonId = "";
            if (DateTime.Now.Month >= 6) {
                seasonId = DateTime.Now.Year.ToString() + (DateTime.Now.Year + 1).ToString();
            } else {
                seasonId = (DateTime.Now.Year - 1).ToString() + DateTime.Now.Year.ToString();
            }
            request.SetSeason(Int32.Parse(seasonId));
            List<Date> seasonDates = Client.GetSchedule(request);
            Assert.IsTrue(seasonDates.Count > 0);
        }

        [TestMethod]
        public void TestGetSingleGame()
        {
            var request = new ScheduleRequest();
            request.SetGameId(2017010075);
            List<Date> dates = Client.GetSchedule(request);
            Assert.AreEqual("PR", dates[0].Games[0].GameType);
        }

        [TestMethod]
        public void TestGetTeams()
        {
            List<Team> teams = Client.GetTeams();
            Assert.IsTrue(teams.Count > 0);
        }

        [TestMethod]
        public void TestGetTeam()
        {
            Assert.AreEqual("Wild", Client.GetTeam(30).TeamName);
        }
    }
}
