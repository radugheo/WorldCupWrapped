using WorldCupWrapped.Data;
using WorldCupWrapped.Models;

namespace WorldCupWrapped.Helpers.Seeders
{
    public class TeamTrophySeeder
    {
        public readonly ProjectContext _projectContext;
        public TeamTrophySeeder(ProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public void SeedInitialTeamsTrophies()
        {
            if (!_projectContext.TeamTrophies.Any())
            {
                //world cup winners
                var teamTrophy1 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Argentina").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 3
                };
                var teamTrophy2 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Brazil").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 5
                };
                var teamTrophy3 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Germany").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 4
                };
                var teamTrophy4 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Uruguay").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 2
                };
                var teamTrophy5 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "France").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 2
                };
                var teamTrophy6 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "England").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 1
                };
                var teamTrophy7 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Spain").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "FIFA World Cup").Id,
                    Count = 1
                };
                //uefa euro winners
                var teamTrophy8 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Portugal").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "UEFA Euro").Id,
                    Count = 1
                };
                var teamTrophy9 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Spain").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "UEFA Euro").Id,
                    Count = 3
                };
                var teamTrophy10 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Germany").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "UEFA Euro").Id,
                    Count = 3
                };
                var teamTrophy11 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "France").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "UEFA Euro").Id,
                    Count = 2
                };
                var teamTrophy12 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Denmark").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "UEFA Euro").Id,
                    Count = 1
                };
                var teamTrophy13 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Netherlands").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "UEFA Euro").Id,
                    Count = 1
                };
                //copa america winners
                var teamTrophy14 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Argentina").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "Copa America").Id,
                    Count = 15
                };
                var teamTrophy15 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Uruguay").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "Copa America").Id,
                    Count = 15
                };
                var teamTrophy16 = new TeamTrophy
                {
                    TeamId = _projectContext.Teams.FirstOrDefault(t => t.Name == "Brazil").Id,
                    TrophyId = _projectContext.Trophies.FirstOrDefault(t => t.Name == "Copa America").Id,
                    Count = 9
                };
                _projectContext.TeamTrophies.Add(teamTrophy1);
                _projectContext.TeamTrophies.Add(teamTrophy2);
                _projectContext.TeamTrophies.Add(teamTrophy3);
                _projectContext.TeamTrophies.Add(teamTrophy4);
                _projectContext.TeamTrophies.Add(teamTrophy5);
                _projectContext.TeamTrophies.Add(teamTrophy6);
                _projectContext.TeamTrophies.Add(teamTrophy7);
                _projectContext.TeamTrophies.Add(teamTrophy8);
                _projectContext.TeamTrophies.Add(teamTrophy9);
                _projectContext.TeamTrophies.Add(teamTrophy10);
                _projectContext.TeamTrophies.Add(teamTrophy11);
                _projectContext.TeamTrophies.Add(teamTrophy12);
                _projectContext.TeamTrophies.Add(teamTrophy13);
                _projectContext.TeamTrophies.Add(teamTrophy14);
                _projectContext.TeamTrophies.Add(teamTrophy15);
                _projectContext.TeamTrophies.Add(teamTrophy16);
                _projectContext.SaveChanges();
            }
        }
    }
}
