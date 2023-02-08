import { Injectable } from '@angular/core';
import Manager from 'src/models/ManagerModel';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class ManagerService {
    constructor(private apiService: ApiService) { }
  
    async getManagers(): Promise<Manager> {
        const data = await this.apiService.call("get", "Manager/get-all-managers");
        return data.data;
    }
}