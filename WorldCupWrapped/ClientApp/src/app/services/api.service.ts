import { Injectable } from '@angular/core';
import axios, { AxiosRequestConfig, AxiosResponse } from 'axios';
import ApiResponse from 'src/models/ApiResponse.model';

const url = 'https://localhost:5001'

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor() { }

  async call(method: 'get' | 'post' | 'put' | 'delete', path: string, data?: any, config?: AxiosRequestConfig): Promise<AxiosResponse> {
    try {
      console.log(`${url}/${path}`, data);
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
  async request<T>(method: 'get' | 'post' | 'put' | 'delete', url: string, data: any, err: string): Promise<ApiResponse<T>> {
    const ret = await this.call(method, url, data);
    return new ApiResponse({
      status: ret.status,
      data: ret.data,
      message: err
    });
  }
}