import { Injectable } from '@angular/core';
import Match from 'src/models/MatchModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class MatchService {
    constructor(private apiService: ApiService) { }


    async getMatches(groupName: any): Promise<Match> {
        const data = await this.apiService.call("get", `Match/${groupName}`);
        console.log(data.data);
        return data.data;
      }
}
