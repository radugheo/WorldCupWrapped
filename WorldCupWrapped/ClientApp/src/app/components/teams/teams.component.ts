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
  async ngOnInit(): Promise<void> {
    this.teams = await this.getTeams();
    console.log(this.teams);
  }
  async getTeams(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Team");
    console.log(data.data);
    return data.data;
  }
}
