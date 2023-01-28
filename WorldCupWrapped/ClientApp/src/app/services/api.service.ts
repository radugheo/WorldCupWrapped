import { Injectable } from '@angular/core';
import axios, { AxiosRequestConfig, AxiosResponse } from 'axios';

const url = 'https://localhost:7254'

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor() { }

  async call(method: 'get' | 'post' | 'put' | 'delete', path: string, data?: any, config?: AxiosRequestConfig): Promise<AxiosResponse> {
    try {
      console.log(`${url}/api/${path}`, data);
      return await axios({
        method,
        url: `${url}/api/${path}`,
        data,
        ...config,
        validateStatus: (status) => status < 500
      });
    } catch (error) {
      console.error(error);
      throw error;
    }
  }
}