import { Component, OnInit } from '@angular/core';
import { AxiosResponse } from 'axios';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrls: ['./groups.component.css']
})
export class GroupsComponent implements OnInit {

  constructor(private apiService: ApiService) { }

  groups: any;
  matches: any;
  selectedGroup: any;
  showGroupMatches = false;

  async ngOnInit(): Promise<void> {
    this.groups = [];
    for (const groupName of ["A", "B", "C", "D", "E", "F", "G", "H"]) {
      const data = await this.getGroup(groupName);
      this.groups.push({ name: groupName, teams: data.sort((a, b) => a.groupRanking - b.groupRanking) });
    }
    this.matches = [];
    for (const groupName of ["A", "B", "C", "D", "E", "F", "G", "H"]) {
      const data = await this.getMatches(groupName);
      this.matches.push({ name: groupName, matches: data });
    }
    console.log(this.matches);
  }

  async getGroup(groupName: any): Promise<any[]> {
    const data = await this.apiService.call("get", `Team/${groupName}`);
    console.log(data.data);
    return data.data;
  }

  async getMatches(groupName: any): Promise<any[]> {
    const data = await this.apiService.call("get", `Match/${groupName}`);
    console.log(data.data);
    return data.data;
  }

  showMatches(groupName: any) {
    this.selectedGroup = this.matches.find((group: { name: any; }) => group.name === groupName);
    this.showGroupMatches = true;
  }

  hideMatches() {
    this.showGroupMatches = false;
  }

}
