namespace _56_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Tournament
    {   
        public static void Tally(Stream inStream, Stream outStream)
        {
            Dictionary<string, TeamStat> teamsResults = new Dictionary<string, TeamStat>();
            using (StreamReader reader = new StreamReader(inStream)) {
                using (StreamWriter writer = new StreamWriter(outStream))
                {
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        var matchResult = line.Split(";");
                        IfNewTeamAddTeam(teamsResults, matchResult[0]);
                        IfNewTeamAddTeam(teamsResults, matchResult[1]);
                        CalculatePoints(teamsResults, matchResult);
                    }
                    DetermineRankings(ref teamsResults);
                    
                    string result = "Team                           | MP |  W |  D |  L |  P";
                    var sortedTeams = from team in teamsResults orderby team.Value.Points descending, team.Key select team;
                    foreach( var team in sortedTeams )
                    {
                        result += "\n";
                        string nameString = team.Key.PadRight(30);

                        result += $"{nameString} | {team.Value.MatchesPlayed,2} | {team.Value.Won,2} | {team.Value.Drawn,2} | {team.Value.Lost,2} | {team.Value.Points, 2}";
                    }
                    writer.Write(result);
                }
            }
        }

        private static void IfNewTeamAddTeam(Dictionary<string, TeamStat> teamsResults, string teamName)
        {
            if (!teamsResults.ContainsKey(teamName))
                teamsResults.Add(teamName, new TeamStat { Won = 0, Drawn = 0, Lost = 0 });

        }

        private static void CalculatePoints(Dictionary<string, TeamStat> teamsResults, string[] matchResult)
        {
            switch (matchResult[2])
            {
                case "win":
                    teamsResults[matchResult[0]].Won++;
                    teamsResults[matchResult[1]].Lost++;
                    break;
                case "draw":
                    teamsResults[matchResult[0]].Drawn++;
                    teamsResults[matchResult[1]].Drawn++;
                    break;
                default:
                    teamsResults[matchResult[0]].Lost++;
                    teamsResults[matchResult[1]].Won++;
                    break;
            }
        }

        

        private static void DetermineRankings(ref Dictionary<string, TeamStat> teamsResults)
        {
            foreach(string teamName in teamsResults.Keys)
            {
                teamsResults[teamName].Points = 3 * teamsResults[teamName].Won + teamsResults[teamName].Drawn;
                teamsResults[teamName].MatchesPlayed = teamsResults[teamName].Won + teamsResults[teamName].Drawn + teamsResults[teamName].Lost;
            }
        }
    }

    public class TeamStat
    {
        public int Won;
        public int Drawn;
        public int Lost;
        public int Points;
        public int MatchesPlayed;
    }
}