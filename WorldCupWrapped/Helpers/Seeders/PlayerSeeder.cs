using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json.Linq;
using Npgsql;
using System.Net;
using System.Text.RegularExpressions;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class PlayerSeeder
    {
        public readonly ProjectContext _projectContext;
        
        public PlayerSeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }

        public async Task SeedInitialPlayersAsync(string token, string _connectionString)
        {
            if (!_projectContext.Players.Any())
            {
                System.Diagnostics.Debug.WriteLine("seeder players");

                List<Player> lista_jucatori = new List<Player>();

                for (int i = 1; i <= 64; i++)
                {
                    System.Diagnostics.Debug.WriteLine(i);
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

                    if((string)joResponseMatch["status"] == "success")
                    {
                        var conn = new NpgsqlConnection(_connectionString);

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


                        //System.Diagnostics.Debug.WriteLine("a asignat readerH");

                        Guid _HomeTeamId = new Guid();

                        //System.Diagnostics.Debug.WriteLine("urmeaza sa intre in reader");
                        if (readerH.Read())
                        {
                            _HomeTeamId = readerH.GetGuid(0);
                        }

                        //System.Diagnostics.Debug.WriteLine("primul reader gata");

                        //close readerh

                        readerH.Close();

                        var readerA = cmdA.ExecuteReader();

                        Guid _AwayTeamId = new Guid();
                        if (readerA.Read())
                        {
                            _AwayTeamId = readerA.GetGuid(0);
                        }

                        //System.Diagnostics.Debug.WriteLine(_HomeTeamId + " versus " + _AwayTeamId);

                        readerA.Close();

                        //list of players for home team and for away team
                        List<string> HomeTeamPlayers = new List<string>();
                        List<string> AwayTeamPlayers = new List<string>();

                        var homescorers = (string)joResponseMatch["data"][0]["home_scorers"][0];
                        var awayscorers = (string)joResponseMatch["data"][0]["away_scorers"][0];

                        //split homescorers and awayscorers

                        if(homescorers == null)
                        {
                            homescorers = "";
                        }
                        if(awayscorers == null)
                        {
                            awayscorers = "";
                        }

                        string[] jucatoriHome = homescorers.Split(',');
                        string[] jucatoriAway = awayscorers.Split(',');


                        //System.Diagnostics.Debug.WriteLine(string.Join("\n", jucatoriHome));
                        //System.Diagnostics.Debug.WriteLine(string.Join("\n", jucatoriAway));

                        foreach (string jucator in jucatoriHome)
                        {
                            if (jucator != null && jucator != "")
                            {
                                System.Text.RegularExpressions.Match match = Regex.Match(jucator, @"\d+");
                                //string nume_jucator = Regex.Replace(jucator, @"[^a-zA-Z]", "");
                                string nume_jucator = new string(jucator.Where(char.IsLetter).ToArray());
                                nume_jucator = Regex.Replace(nume_jucator, "([A-Z])", " $1");
                                nume_jucator = nume_jucator.Substring(1);

                                bool exists_already = lista_jucatori.Any(p => p.Name == nume_jucator);

                                if (!exists_already)
                                {
                                    var JucatorInfo = new Player
                                    {
                                        Name = nume_jucator,
                                        TeamId = _HomeTeamId,

                                    };
                                    if (match.Success)
                                    {
                                        int number = int.Parse(match.Value);
                                        JucatorInfo.Goals = number;
                                    }
                                    else
                                    {
                                        JucatorInfo.Goals = 1;
                                    }
                                    lista_jucatori.Add(JucatorInfo);
                                }
                                else
                                {
                                    Player jucator_existent = lista_jucatori.Find(p => p.Name == nume_jucator);
                                    if (match.Success)
                                    {
                                        int number = int.Parse(match.Value);
                                        jucator_existent.Goals += number;
                                    }
                                    else
                                    {
                                        jucator_existent.Goals += 1;
                                    }
                                }
                            }

                        }

                        foreach (string jucator in jucatoriAway)
                        {
                            if (jucator != null && jucator != "")
                            {
                                System.Text.RegularExpressions.Match match = Regex.Match(jucator, @"\d+");
                                string nume_jucator = new string(jucator.Where(char.IsLetter).ToArray());
                                nume_jucator = Regex.Replace(nume_jucator, "([A-Z])", " $1");
                                nume_jucator = nume_jucator.Substring(1);

                                bool exists_already = lista_jucatori.Any(p => p.Name == nume_jucator);

                                if (!exists_already)
                                {
                                    var JucatorInfo = new Player
                                    {
                                        Name = nume_jucator,
                                        TeamId = _AwayTeamId,

                                    };
                                    if (match.Success)
                                    {
                                        int number = int.Parse(match.Value);
                                        JucatorInfo.Goals = number;
                                    }
                                    else
                                    {
                                        JucatorInfo.Goals = 1;
                                    }
                                    lista_jucatori.Add(JucatorInfo);
                                }
                                else
                                {
                                    Player jucator_existent = lista_jucatori.Find(p => p.Name == nume_jucator);
                                    if (match.Success)
                                    {
                                        int number = int.Parse(match.Value);
                                        jucator_existent.Goals += number;
                                    }
                                    else
                                    {
                                        jucator_existent.Goals += 1;
                                    }
                                }
                            }

                        }

                    }
                    
                }

                lista_jucatori = lista_jucatori.OrderByDescending(x => x.Goals).ToList();

                lista_jucatori.RemoveAt(0);
                lista_jucatori.RemoveAt(0);
                lista_jucatori.RemoveAt(11);
                lista_jucatori[0].Goals = 7;
                lista_jucatori[1].Goals = 8;
                lista_jucatori[3].Name = "Julián Álvarez";
                lista_jucatori[8].Name = "Álvaro Morata";
                lista_jucatori[113].Goals = 2;
                lista_jucatori.RemoveAt(121);
                lista_jucatori[48].Goals = 2;
                lista_jucatori.RemoveAt(108);
                lista_jucatori[16].Goals = 1;
                lista_jucatori.RemoveAt(84);
                lista_jucatori.RemoveAt(109);
                lista_jucatori[87].Name = "Juan Pablo Vargas";
                lista_jucatori.RemoveAt(81);



                foreach (Player pl in lista_jucatori)
                {
                    if (pl != null && pl.Name != "")
                    {
                        _projectContext.Players.Add(pl);
                    }
                }

                _projectContext.SaveChanges();
            }
        }
    }
}
