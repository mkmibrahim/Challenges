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
        private static Dictionary<string, TeamStat> teamsResults = new Dictionary<string, TeamStat>();

        public static void Tally(Stream inStream, Stream outStream)
        {
            using (StreamReader reader = new StreamReader(inStream)) {
                using (StreamWriter writer = new StreamWriter(outStream))
                {
                    string result = "Team                           | MP |  W |  D |  L |  P";
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        var matchResult = line.Split(";");
                        if (!teamsResults.ContainsKey(matchResult[0])) {
                            teamsResults.Add(matchResult[0], new TeamStat{ Won = 0, Drawn = 0, Lost = 0});
                            };
                        if (!teamsResults.ContainsKey(matchResult[1])) {
                            teamsResults.Add(matchResult[1], new TeamStat{ Won = 0, Drawn = 0, Lost = 0});
                            };
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
                    DetermineRanking();
                    foreach (KeyValuePair<string, TeamStat> team in teamsResults.OrderByDescending(value => value.Value.Points))
                    {
                        result += "\n";
                        string nameString = team.Key.PadRight(30);
                        
                        result +=  $"{nameString} |  {team.Value.MatchesPlayed} |  {team.Value.Won} |  {team.Value.Drawn} |  {team.Value.Lost} |  {team.Value.Points}";
                            }
                    writer.Write(result);
                }
            }
        }

        private static void DetermineRanking()
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

    enum matchResult
    {
        win,
        draw,
        loss
    }

}