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
    this.teams[0].imageUrl = 'https://assets.bwbx.io/images/users/iqjWHBFdfxIU/idao2nO4S8oQ/v1/-1x-1.jpg';
    console.log(this.teams);
  }
  async getTeams(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Team");
    console.log(data.data);
    return data.data;
  }
}
