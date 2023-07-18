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
            using (StreamReader reader = new StreamReader(inStream)) {
                using (StreamWriter writer = new StreamWriter(outStream))
                {
                    string result = "Team                           | MP |  W |  D |  L |  P";
                    string line;
                    Dictionary<string, TeamStat> teamsResults = new Dictionary<string, TeamStat>();
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
                                var oldStat = teamsResults[matchResult[0]];
                                teamsResults[matchResult[0]] = new TeamStat{Won = oldStat.Won++, Drawn = oldStat.Drawn, Lost = oldStat.Lost};
                                oldStat = teamsResults[matchResult[1]];
                                teamsResults[matchResult[0]] = new TeamStat{Won = oldStat.Won, Drawn = oldStat.Drawn, Lost = oldStat.Lost++};
                                break;
                            case "draw":
                                oldStat = teamsResults[matchResult[0]];
                                teamsResults[matchResult[0]] = new TeamStat{Won = oldStat.Won, Drawn = oldStat.Drawn++, Lost = oldStat.Lost};
                                oldStat = teamsResults[matchResult[1]];
                                teamsResults[matchResult[0]] = new TeamStat{Won = oldStat.Won, Drawn = oldStat.Drawn++, Lost = oldStat.Lost};
                                break;
                            default:
                                oldStat = teamsResults[matchResult[0]];
                                teamsResults[matchResult[0]] = new TeamStat{Won = oldStat.Won, Drawn = oldStat.Drawn, Lost = oldStat.Lost++};
                                oldStat = teamsResults[matchResult[1]];
                                teamsResults[matchResult[0]] = new TeamStat{Won = oldStat.Won++, Drawn = oldStat.Drawn, Lost = oldStat.Lost};
                                break;
                        }
                    }

                    writer.Write(result);
                }
            }
        }
    }

    public class TeamStat
    {
        public int Won;
        public int Drawn;
        public int Lost;
    }

    enum matchResult
    {
        win,
        draw,
        loss
    }

}