import { Injectable } from '@angular/core';
import City from 'src/models/CityModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class CityService {
    constructor(private apiService: ApiService) { }
  
    async getCities(): Promise<City>{
        const data = await this.apiService.call("get", "City/get-all-cities");
        return data.data;
      }
}
