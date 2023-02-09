import { Component, OnInit } from '@angular/core';
import { ArraySortPipe } from 'src/app/pipes/sort-by.pipe';
import { TeamService } from 'src/app/services/teams.service';
import { PlayerService} from 'src/app/services/players.service';
 

@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.css'],
  providers: [ArraySortPipe]
})
export class PlayersComponent implements OnInit{
  constructor(private teamService: TeamService, private playerService: PlayerService) { }
  players: any;
  teams: any;
  async ngOnInit(): Promise<void> {

    await this.playerService.getPlayers().then(players => {
      this.players = players;
      console.log(this.players);
    });

    await this.teamService.getTeams().then(teams => {
      this.teams = teams;
      console.log(this.teams);
    });

    this.players.forEach((player: {
      country: any; teamId: any; flag: any; 
}) => {
      const team = this.teams.find((team: { id: any; }) => team.id === player.teamId);
      player.flag = team.flag;
      player.country = team.name;
    });
    console.log(this.players);
  }
}

