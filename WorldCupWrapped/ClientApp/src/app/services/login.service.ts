import { Injectable } from '@angular/core';
import { AxiosResponse } from 'axios';
import UserRequestLogin from 'src/models/UserRequestLogin';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class LoginService {
    constructor(private apiService: ApiService) {}
    async loginUser(dto: UserRequestLogin): Promise<AxiosResponse> {
        return await this.apiService.call("post", "Users/authenticate", dto);
    }
}