using Newtonsoft.Json.Linq;
using Npgsql;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class MatchSeeder
    {
        public readonly ProjectContext _projectContext;

        public MatchSeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task SeedInitialMatchesAsync(string token)
        {
            if (!_projectContext.Matches.Any())
            {
                System.Diagnostics.Debug.WriteLine("seeder matches");

                Guid[] matchStadiums = new Guid[65];

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7254/");
                    HttpResponseMessage responseStadium = await client.GetAsync("api/Stadium");
                    responseStadium.EnsureSuccessStatusCode();
                    var responseBodyStadium = await responseStadium.Content.ReadAsStringAsync();
                    JArray jsonStadium = JArray.Parse(responseBodyStadium);

                    //take the first object from jsonStadium
                    var aljanoub = jsonStadium[0]; //Al Janoub
                    var lusail = jsonStadium[1]; //Lusail
                    var khalifaint = jsonStadium[2]; //Khalifa Int Stadium
                    var ahmadbin = jsonStadium[3]; //Ahmad Bin Ali
                    var stadium974 = jsonStadium[4]; //974
                    var althumana = jsonStadium[5]; //Al Thumana
                    var albayt = jsonStadium[6]; //Al Bayt
                    var educationcity = jsonStadium[7]; //Education City

                    int nr = 1;
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)ahmadbin["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)aljanoub["id"];
                    matchStadiums[nr++] = (Guid)stadium974["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)educationcity["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)althumana["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr++] = (Guid)albayt["id"];
                    matchStadiums[nr++] = (Guid)khalifaint["id"];
                    matchStadiums[nr++] = (Guid)lusail["id"];
                    matchStadiums[nr] = (Guid)albayt["id"];


                    System.Diagnostics.Debug.WriteLine("INFO: a trecut de api-ul la stadioane!!!");
                }

                for(int i = 1; i <= 64; i++)
                {
                    //System.Diagnostics.Debug.WriteLine("stadion meciul nr " + i + matchStadiums[i]);
                    var url = "http://api.cup2022.ir/api/v1/match/" + i;
                    var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpRequest.Method = "GET";
                    httpRequest.Accept = "application/json";
                    httpRequest.ContentType = "application/json";
                    httpRequest.PreAuthenticate = true;
                    httpRequest.Headers.Add("Authorization", "Bearer " + token);
                    var httpResponseMatch = (HttpWebResponse)httpRequest.GetResponse();
                    var streamReaderMatch = new StreamReader(httpResponseMatch.GetResponseStream());

                    var responseMatch = streamReaderMatch.ReadToEnd();
                    JObject joResponseMatch = JObject.Parse(responseMatch);

                    if ((string)joResponseMatch["status"] == "success")
                    {

                        //System.Diagnostics.Debug.WriteLine("acum ar trebui sa inceapa asta cu select ul");

                        var conn = new NpgsqlConnection("Host=wcw-database.cen3l3c0hkio.us-east-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=adminadmin;Database=wcw-database;");

                        conn.Open();

                        var cmdH = new NpgsqlCommand("SELECT \"Id\" FROM \"Teams\" WHERE \"Name\" = @teamName", conn);
                        var cmdA = new NpgsqlCommand("SELECT \"Id\" FROM \"Teams\" WHERE \"Name\" = @teamName", conn);

                        //take parameter of connectionstring from appsettings.json

                        //System.Diagnostics.Debug.WriteLine("a facut selecturile bine");

                        var HomeTeamName = (string)joResponseMatch["data"][0]["home_team_en"];
                        var AwayTeamName = (string)joResponseMatch["data"][0]["away_team_en"];

                        //System.Diagnostics.Debug.WriteLine(HomeTeamName);


                        cmdH.Parameters.AddWithValue("@teamName", HomeTeamName);
                        cmdA.Parameters.AddWithValue("@teamName", AwayTeamName);

                        //System.Diagnostics.Debug.WriteLine("a asignat si teamName");

                        var readerH = cmdH.ExecuteReader();


                        System.Diagnostics.Debug.WriteLine("a asignat readerH");

                        Guid _HomeTeamId = new Guid(); 

                        //System.Diagnostics.Debug.WriteLine("urmeaza sa intre in reader");
                        if(readerH.Read())
                        {
                            _HomeTeamId = readerH.GetGuid(0);
                        }

                        //System.Diagnostics.Debug.WriteLine("primul reader gata");

                        //close readerh

                        readerH.Close();

                        var readerA = cmdA.ExecuteReader();

                        Guid _AwayTeamId = new Guid();
                        if(readerA.Read())
                        {
                            _AwayTeamId = readerA.GetGuid(0);
                        }

                        System.Diagnostics.Debug.WriteLine(_HomeTeamId + " versus " + _AwayTeamId);

                        readerA.Close();

                        var MatchInfo = new Match
                        {
                            HomeTeam = (string)joResponseMatch["data"][0]["home_team_en"],
                            HomeTeamId = _HomeTeamId,
                            AwayTeam = (string)joResponseMatch["data"][0]["away_team_en"],
                            AwayTeamId = _AwayTeamId,
                            Date = (string)joResponseMatch["data"][0]["local_date"],
                            StadiumId = matchStadiums[i],
                            HomeGoals = (int)joResponseMatch["data"][0]["home_score"],
                            AwayGoals = (int)joResponseMatch["data"][0]["away_score"],
                            Phase = (string)joResponseMatch["data"][0]["group"],
                        };

                        System.Diagnostics.Debug.WriteLine(MatchInfo.HomeTeam + " versus " + MatchInfo.AwayTeam + " in " + MatchInfo.StadiumId + " la data de " + MatchInfo.Date + " in faza " + MatchInfo.Phase + " cu scorul " + MatchInfo.HomeGoals + " - " + MatchInfo.AwayGoals);
                        _projectContext.Matches.Add(MatchInfo);
                    }

                }

                _projectContext.SaveChanges();
            }
        }
    }
}
