import { Component, OnInit } from '@angular/core';
import { AxiosResponse } from 'axios';
import { ApiService } from 'src/app/services/api.service';
import { ArraySortPipe } from 'src/app/pipes/sort-by.pipe';

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.css'],
  providers: [ArraySortPipe]
})
export class PlayersComponent implements OnInit{
  constructor(private apiService: ApiService) { }
  players: any;
  teams: any;
  async ngOnInit(): Promise<void> {

    this.players = await this.getPlayers();
    this.teams = await this.getTeams();
    this.players.forEach((player: {
      country: any; teamId: any; flag: any; 
}) => {
      const team = this.teams.find((team: { id: any; }) => team.id === player.teamId);
      player.flag = team.flag;
      player.country = team.name;
    });
    console.log(this.players);
  }
  async getPlayers(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Player");
    console.log(data.data);
    return data.data;
  }

  async getTeams(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Team");
    return data.data;
  }
}

