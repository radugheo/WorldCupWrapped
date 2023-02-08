import { Injectable } from '@angular/core';
import Team from 'src/models/TeamModel';
import TeamTrophyResponse from 'src/models/TeamTrophyResponseModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class TeamService {
    constructor(private apiService: ApiService) { }
  
    async getTeams(): Promise<Team> {
        const data = await this.apiService.call("get", "Team");
        return data.data;
    }

    async getTrophies(teamName: string): Promise<TeamTrophyResponse> {
      const data = await this.apiService.call("get", `Team/${teamName}/trophies`);
      // console.log(`aici sunt trofeele pentru ${teamName}: ${JSON.stringify(data.data)}`);
      return Object(JSON.stringify(data.data));
  }
}