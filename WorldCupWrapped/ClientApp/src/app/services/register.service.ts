import { Injectable } from '@angular/core';
import { AxiosResponse } from 'axios';
import UserRequestRegister from 'src/models/UserRequestRegister';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})

export class RegisterService {
    constructor(private apiService: ApiService) {}
    async registerUser(dto: UserRequestRegister): Promise<AxiosResponse> {
        return await this.apiService.call("post", "Users/create-user", dto);
    }
}