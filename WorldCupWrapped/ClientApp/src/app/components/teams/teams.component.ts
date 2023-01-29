import { Component, OnInit } from '@angular/core';
import { AxiosResponse } from 'axios';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-teams',
  templateUrl: './teams.component.html',
  styleUrls: ['./teams.component.css']
})
export class TeamsComponent implements OnInit{
  constructor(private apiService: ApiService) { }
  teams: any;
  managers: any;
  async ngOnInit(): Promise<void> {
    this.teams = await this.getTeams();
    this.managers = await this.getManagers();
    this.teams.forEach((team: { managerId: any; manager: any; }) => {
      const manager = this.managers.find((manager: { id: any; }) => manager.id === team.managerId);
      team.manager = manager.name;
    });
    this.teams.forEach(async (team: { fifaName: any; worldCups: any; }) => {
      const resTrophies = await this.getTrophies(team.fifaName);
      console.log(resTrophies.data);
      team.worldCups = resTrophies.data;
    });
    console.log(this.teams);
  }
  async getTeams(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Team");
    console.log(data.data);
    return data.data;
  }
  async getManagers(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Manager/get-all-managers");
    console.log(data.data);
    return data.data;
  }
  async getTrophies(teamName: string): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", `Team/${teamName}/trophies`);
    console.log(data.data);
    return data.data;
  }
}
