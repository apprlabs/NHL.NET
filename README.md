# NHL.NET
A .NET SDK for consuming the NHL API @ https://statsapi.web.nhl.com/api/v1/

## Usage
To begin, create your client: `var client = new NHLDotNet.Client()` (if you need to provide a custom `HttpClientHandler`, you can do so: `var client = new NHLDotNet.Client(new HttpClientHandler())`).

With your client, you can now query the NHL dataset.

### Requests
#### Conferences
  * `client.GetConferences()`
    * Gets all active conferences 
  * `client.GetConference(int conferenceId)`
    * Gets a specific conference

#### Divisions
  * `client.GetDivisions()`
    * Gets all active divisions 
  * `client.GetDivision(int divisionId)`
    * Gets a specific division

#### Franchises
  * `client.GetFranchises()`
    * Gets all active franchises 
  * `client.GetFranchise(int franchiseId)`
    * Gets a specific franchise

#### Game Content
  Game content is media surrounding a game. This includes preview articles (if written), video highlights, and highlights after the game's complete. Game ID can be gathered from the schedule.

  * `client.GameGameContent(int gameId)`
    * Gets game content

#### Game Feed
  Game feed is the list of events that happen throughout a game, as the game happens, with the entirety being available after the game's completion. This of the list of SHOT, HIT, BLOCK from NHL.com's Ice Tracker. Game ID can be gathered from the schedule.

  * `client.GetGameFeed(int gameId)`
    * Gets game content

#### Player
  * `client.GetPlayer(int playerId)`
    * Gets a specific player

#### Schedule
  * `client.GetSchedule()`
    * Gets the list of games occurring today
  * `client.GetSchedule(NHLDotNet.Request.ScheduleRequest request)`
    * Gets a list of games matching the request options.
    * Available request options:
      * `GameId` - Get only a specific game
      * `GameType` - Get only preseason, regular season, or postseason games
      * `Date` - Get games for a specific date
      * `ExpandOptions` - Gets additional content for a game. Available options are:
          * `Teams` - Get details for teams in the game response
          * `Broadcasts` - Get details for broadcasts in the game response
          * `Linescore` - Get details for linescore in the game response
          * `Tickets` - Get details for tickets in the game response
          * `MediaGuide` - Get the media guide (listings) in the game response
      * `Season` - Get all games for a season. Season IDs are `YYYY(YYYY+1)` (e.g. 20172018).

#### Teams
  * `client.GetTeams()`
    * Gets all active teams 
  * `client.GetTeam(int teamId)`
    * Gets a specific team