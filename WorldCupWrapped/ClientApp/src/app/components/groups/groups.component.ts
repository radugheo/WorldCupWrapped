import { Component, OnInit } from '@angular/core';
import { TeamService } from 'src/app/services/teams.service';
import { MatchService} from 'src/app/services/matches.service';


@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.css']
})
export class GroupsComponent implements OnInit {

  constructor(private teamService: TeamService, private matchService: MatchService) { }

  groups: any;
  matches: any;
  selectedGroup: any;
  showGroupMatches = false;

  async ngOnInit(): Promise<void> {


    this.groups = [];
    for (const groupName of ["A", "B", "C", "D", "E", "F", "G", "H"]) {
      await this.teamService.getGroup(groupName).then(data => {
        this.groups.push({ name: groupName, teams: data.sort((a, b) => a.groupRanking - b.groupRanking) });
      });
      console.log(this.groups);
    }
    this.matches = [];
    for (const groupName of ["A", "B", "C", "D", "E", "F", "G", "H"]) {
      await this.matchService.getMatches(groupName).then(matches => {
        this.matches.push({ name: groupName, matches: matches });
      });
    }
    console.log(this.matches);
  }

  // async getGroup(groupName: any): Promise<any[]> {
  //   const data = await this.apiService.call("get", `Team/${groupName}`);
  //   console.log(data.data);
  //   return data.data;
  // }

  // async getMatches(groupName: any): Promise<any[]> {
  //   const data = await this.apiService.call("get", `Match/${groupName}`);
  //   console.log(data.data);
  //   return data.data;
  // }

  showMatches(groupName: any) {
    this.selectedGroup = this.matches.find((group: { name: any; }) => group.name === groupName);
    this.showGroupMatches = true;
  }

  hideMatches() {
    this.showGroupMatches = false;
  }

}
