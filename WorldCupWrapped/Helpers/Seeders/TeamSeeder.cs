using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Net;
using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class TeamSeeder
    {
        public readonly ProjectContext _projectContext;
        public TeamSeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public async Task SeedInitialTeamsAsync(string token)
        {
            if (!_projectContext.Teams.Any())
            {    
                System.Diagnostics.Debug.WriteLine("INFO: a ajuns la team seeder cu tokenul: " + token);
                string[] teamGroupRankings = new string[33];
                string[] teamKnockoutRankings = new string[33];
                string[] teamTopScorer = new string[33];
                Guid[] teamManagers = new Guid[33];

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7254/");
                    HttpResponseMessage response = await client.GetAsync("api/Manager/get-all-managers");
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    JArray json = JArray.Parse(responseBody);
                    var i = 0;
                    foreach (var obj in json)
                    {
                        System.Diagnostics.Debug.WriteLine(obj["id"]);
                        if (i != 0)
                        {
                            teamManagers[i] = (Guid)obj["id"];
                        }
                        i++;
                    }
                    System.Diagnostics.Debug.WriteLine("INFO: a trecut de api-ul la manager!!!");
                }
                

                //group A
                teamGroupRankings[4] = "1";
                teamKnockoutRankings[4] = "Quarter Final";
                teamTopScorer[4] = "Cody Gakpo";

                teamGroupRankings[3] = "2";
                teamKnockoutRankings[3] = "Round of 16";
                teamTopScorer[3] = "Famara Diedhiou";

                teamGroupRankings[2] = "3";
                teamKnockoutRankings[2] = "Group Stage";
                teamTopScorer[2] = "Enner Valencia";

                teamGroupRankings[1] = "4";
                teamKnockoutRankings[1] = "Group Stage";
                teamTopScorer[1] = "Mohammed Muntari";

                //group B
                teamGroupRankings[5] = "1";
                teamKnockoutRankings[5] = "Quarter Final";
                teamTopScorer[5] = "Marcus Rashford";

                teamGroupRankings[7] = "2";
                teamKnockoutRankings[7] = "Round of 16";
                teamTopScorer[7] = "Haji Wright";

                teamGroupRankings[6] = "3";
                teamKnockoutRankings[6] = "Group Stage";
                teamTopScorer[6] = "Mehdi Taremi";

                teamGroupRankings[8] = "4";
                teamKnockoutRankings[8] = "Group Stage";
                teamTopScorer[8] = "Gareth Bale";

                //group C
                teamGroupRankings[9] = "1";
                teamKnockoutRankings[9] = "Winner";
                teamTopScorer[9] = "Lionel Messi";

                teamGroupRankings[14] = "2";
                teamKnockoutRankings[14] = "Round of 16";
                teamTopScorer[14] = "Robert Lewandowski";

                teamGroupRankings[13] = "3";
                teamKnockoutRankings[13] = "Group Stage";
                teamTopScorer[13] = "Henry Martín";

                teamGroupRankings[10] = "4";
                teamKnockoutRankings[10] = "Group Stage";
                teamTopScorer[10] = "Salem Al-Dawsari";

                //group D
                teamGroupRankings[15] = "1";
                teamKnockoutRankings[15] = "Runners up";
                teamTopScorer[15] = "Kylian Mbappe";

                teamGroupRankings[16] = "2";
                teamKnockoutRankings[16] = "Round of 16";
                teamTopScorer[16] = "Craig Goodwin";

                teamGroupRankings[12] = "3";
                teamKnockoutRankings[12] = "Group Stage";
                teamTopScorer[12] = "Wahbi Khazri";

                teamGroupRankings[11] = "4";
                teamKnockoutRankings[11] = "Group Stage";
                teamTopScorer[11] = "Andreas Christensen";

                //group E
                teamGroupRankings[20] = "1";
                teamKnockoutRankings[20] = "Round of 16";
                teamTopScorer[20] = "Ritsu Doan";

                teamGroupRankings[21] = "2";
                teamKnockoutRankings[21] = "Round of 16";
                teamTopScorer[21] = "Alvaro Morata";

                teamGroupRankings[19] = "3";
                teamKnockoutRankings[19] = "Group Stage";
                teamTopScorer[19] = "Niclas Füllkrug";

                teamGroupRankings[22] = "4";
                teamKnockoutRankings[22] = "Group Stage";
                teamTopScorer[22] = "Juan Vargas";

                //group F
                teamGroupRankings[17] = "1";
                teamKnockoutRankings[17] = "Semifinal";
                teamTopScorer[17] = "Youssef En-Nesyri";

                teamGroupRankings[18] = "2";
                teamKnockoutRankings[18] = "Semifinal";
                teamTopScorer[18] = "Andrej Kramaric";

                teamGroupRankings[23] = "3";
                teamKnockoutRankings[23] = "Group Stage";
                teamTopScorer[23] = "Michy Batshuayi";

                teamGroupRankings[24] = "4";
                teamKnockoutRankings[24] = "Group Stage";
                teamTopScorer[24] = "Alphonso Davies";

                //group G
                teamGroupRankings[25] = "1";
                teamKnockoutRankings[25] = "Quarter Final";
                teamTopScorer[25] = "Richarlison";

                teamGroupRankings[31] = "2";
                teamKnockoutRankings[31] = "Round of 16";
                teamTopScorer[31] = "Breel Embolo";

                teamGroupRankings[32] = "3";
                teamKnockoutRankings[32] = "Group Stage";
                teamTopScorer[32] = "Vincent Aboubakar";

                teamGroupRankings[26] = "4";
                teamKnockoutRankings[26] = "Group Stage";
                teamTopScorer[26] = "Aleksandar Mitrovic";

                //group H
                teamGroupRankings[27] = "1";
                teamKnockoutRankings[27] = "Quarter Final";
                teamTopScorer[27] = "Gonçalo Ramos";

                teamGroupRankings[30] = "2";
                teamKnockoutRankings[30] = "Round of 16";
                teamTopScorer[30] = "Gue-sung Cho";

                teamGroupRankings[29] = "3";
                teamKnockoutRankings[29] = "Group Stage";
                teamTopScorer[29] = "Giorgian de Arrascaeta";

                teamGroupRankings[28] = "4";
                teamKnockoutRankings[28] = "Group Stage";
                teamTopScorer[28] = "Mohammed Kudus";


                for (int i = 1; i <= 32; i++)
                {
                    System.Diagnostics.Debug.WriteLine("manager ID: " + teamManagers[i]);
                    var url = "http://api.cup2022.ir/api/v1/team/" + i;
                    var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                    httpRequest.Method = "GET";
                    httpRequest.Accept = "application/json";
                    httpRequest.ContentType = "application/json";
                    httpRequest.PreAuthenticate = true;
                    httpRequest.Headers.Add("Authorization", "Bearer " + token);
                    var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                    var streamReader = new StreamReader(httpResponse.GetResponseStream());

                    var response = streamReader.ReadToEnd();
                    JObject joResponse = JObject.Parse(response);
                    
                    if ((string)joResponse["status"] == "success")
                    {
                        var teamInfo = new Team
                        {
                            Name = (string)joResponse["data"][0]["name_en"],
                            FifaName = (string)joResponse["data"][0]["fifa_code"],
                            Flag = (string)joResponse["data"][0]["flag"],
                            Group = (string)joResponse["data"][0]["groups"],
                            GroupRanking = teamGroupRankings[i],
                            KnockoutRanking = teamKnockoutRankings[i],
                            TopScorer = teamTopScorer[i],
                            ManagerId = teamManagers[i]
                        };
                        System.Diagnostics.Debug.WriteLine("Echipa: " + teamInfo.Name + " " + teamInfo.FifaName + " " + teamInfo.Flag + " " + teamInfo.Group + " " + teamInfo.GroupRanking + " " + teamInfo.KnockoutRanking + " " + teamInfo.TopScorer + " " + teamInfo.ManagerId);
                        _projectContext.Teams.Add(teamInfo);
                    }

                }
                _projectContext.SaveChanges();
            }
        }
    }
}
