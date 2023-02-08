import { Component } from '@angular/core';
import { AxiosResponse } from 'axios';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-knockout',
  templateUrl: './knockout.component.html',
  styleUrls: ['./knockout.component.css']
})
export class KnockoutComponent {

  constructor(private apiService: ApiService) { }
  matches: any;
  final:String = "FIN";
  semi:String = "semi";
  qr:String = "QR";
  r16:String = "R16";
  teams: any;

  async ngOnInit(): Promise<void>{
    this.matches = [];
    this.teams = await this.getTeams();
    for (const groupName of ["FIN", "semi", "QR", "R16"]) {
      const data = await this.getMatches(groupName);
      this.matches.push({ name: groupName, matches: data });
    }
    console.log(this.matches);
  }

  async getMatches(groupName: any): Promise<any[]> {
    const data = await this.apiService.call("get", `Match/${groupName}`);
    console.log(data.data);
    return data.data;
  }

  async getTeams(): Promise<AxiosResponse> {
    const data = await this.apiService.call("get", "Team");
    console.log(data.data);
    return data.data;
  }
  
}
