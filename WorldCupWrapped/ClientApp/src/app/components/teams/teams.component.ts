import { Component, OnInit } from '@angular/core';
import { ManagerService } from 'src/app/services/managers.service';
import { TeamService } from 'src/app/services/teams.service';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.css']
})
export class TeamsComponent implements OnInit{
  constructor(private teamService: TeamService, private managerService: ManagerService) { }
  teams: any;
  managers: any;
  teamWorldCups: any;
  teamOtherTrophies: any;
  responseTrophies: any;
  async ngOnInit(): Promise<void> {
    await this.teamService.getTeams().then(teams => {
      this.teams = teams;
      console.log(this.teams);
    });
    await this.managerService.getManagers().then(managers => {
      this.managers = managers;
      console.log(this.managers);
    });
    this.teams.forEach((team: { managerId: any; manager: any; }) => {
      const manager = this.managers.find((manager: { id: any; }) => manager.id === team.managerId);
      team.manager = manager.name + ' (' + manager.age + ', ' + manager.nationality + ')';
    });
    this.teams.forEach(async (team: { fifaName: any; worldCups: any; }) => {
      // const resTrophies = await this.getTrophies(team.fifaName);
      await this.teamService.getTrophies(team.fifaName).then(trophies => {
        this.responseTrophies = trophies;
        console.log("trophies: " + typeof(JSON.parse(JSON.stringify(this.responseTrophies))));
        team.worldCups = this.responseTrophies.trophies;
      });
    });
    console.log(this.teams);
  }
  
  // async getTrophies(teamName: string): Promise<AxiosResponse> {
  //   const data = await this.apiService.call("get", `Team/${teamName}/trophies`);
  //   console.log(data.data);
  //   return data.data;
  // }
}
