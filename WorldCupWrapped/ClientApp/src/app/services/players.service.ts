import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import Player from 'src/models/PlayerModel';

@Injectable({
  providedIn: 'root'
})

export class PlayerService {
    constructor(private apiService: ApiService) { }
  
    async getPlayers(): Promise<Player> {
        const data = await this.apiService.call("get", "Player");
        return data.data;
    }
}