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
      this.matches.push({ name: groupName, matches: data.sort((a, b) => {
        if(a.date < b.date) 
          if(groupName == this.final || groupName == this.qr)
            return 1;
          else return -1;
        if(a.date > b.date)
          if(groupName == this.final || groupName == this.qr)
            return -1;
          else return 1;
        return 0;
      }) });
    }
    // swap the matches 3 and 6 and 4 and 5 from round of 16
    let temp = this.matches[3].matches[2];
    this.matches[3].matches[2] = this.matches[3].matches[5];
    this.matches[3].matches[5] = temp;

    temp = this.matches[3].matches[3];
    this.matches[3].matches[3] = this.matches[3].matches[4];
    this.matches[3].matches[4] = temp;
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
