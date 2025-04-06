using Microsoft.EntityFrameworkCore;
using FootballChampionship;
using System;

using var context = new AppDbContext();

//1.Retrieve all teams sorted by name.

//var teamsByName = context.Teams.Select(t => t.Name).ToList();

//2.Find all players who play as "Forward".
//var forwardPosition = context.Players.Where(x => x.Position == "Forward").ToList();

//3.List all leagues and their corresponding countries
//var countries = context.Leagues.ToList();

//4. Get the total number of teams in the database.
//var totalTeams = context.Teams.Count();

//5.Retrieve all matches played in a specific league (e.g., "Premier League").

//var matchesLeague = context.Matches.Include(l =>l.League).ToList();

//6.Find all players older than 30.

//var playersAges = context.Players.Where(x=>x.Age > 30).ToList();

//7.Get the number of teams in each league.

//var numberOfTeams = context.Leagues.Include(l=>l.Teams).ToList();
//foreach (var league in numberOfTeams)
//{
//    Console.WriteLine($"The league is: {league.Name} the team is: {league.Teams.Count()}");
//}

//1.Find the team with the most players.

var teamWithTheMostPlayers = context.Teams.Include(t=>t.Players).OrderByDescending(p=>p.Players.Count()).FirstOrDefault();

//2.Retrieve the top 3 players who have scored the most goals.

var topPlayers = context.Players
    .Include(p => p.Goals) 
    .OrderByDescending(p => p.Goals.Count) 
    .Take(3) 
    .ToList();

//3.Get the league with the highest total number of goals scored in all its matches.
var leagueGoals = context.Leagues.Include(l => l.Goals).OrderByDescending(x=>x.Goals.Count()).ToList();

//4.Find matches where both teams scored the same number of goals (draws).
var drawMatches = context.Matches.Where(m => m.HomeScore == m.AwayScore).ToList();

//5.Retrieve all teams that have played at least 10 matches.
var teamsWithAtLeast10Matches = context.Teams
    .Where(t => context.Matches.Count(m => m.HomeTeamId == t.Id || m.AwayTeamId == t.Id) >= 10)
    .ToList();

//6.Find the oldest and youngest players in the database.
var oldestPlayers = context.Players.OrderByDescending(p => p.Age).Take(3).ToList();
var youngestPlayers = context.Players.OrderBy(p=>p.Age).Take(3).ToList();

//7.Get the player who scored the earliest goal in any match.
var fastestGoal = context.Goals.OrderBy(g=>g.Minute).Include(g=>g.Player).FirstOrDefault();

//8. Retrieve the teams that have played the most matches.
var teamsWithMostMatches = context.Teams
    .Select(t => new
    {
        Team = t,
        MatchesPlayed = context.Matches.Count(m => m.HomeTeamId == t.Id || m.AwayTeamId == t.Id)
    })
    .OrderByDescending(t => t.MatchesPlayed)
    .ToList();

//9.Find the match with the highest number of total goals scored.
var highestScoringMatch = context.Matches
    .OrderByDescending(m => m.HomeScore + m.AwayScore)
    .FirstOrDefault();

//10.Get the league with the most teams participating.
var teamsParticipating = context.Leagues.OrderByDescending(l=>l.Teams.Count()).FirstOrDefault();    




;



