import { Injectable } from '@angular/core';
import Stadium from 'src/models/StadiumModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class StadiumService {
    constructor(private apiService: ApiService) { }
  
    async getStadiums(): Promise<Stadium> {
        const data = await this.apiService.call("get", "Stadium");
        return data.data;
    }
}
