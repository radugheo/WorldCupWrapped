import { Component } from '@angular/core';
import { AxiosResponse } from 'axios';
import { ApiService } from 'src/app/services/api.service';

@Component({
  selector: 'app-stadiums',
  templateUrl: './stadiums.component.html',
  styleUrls: ['./stadiums.component.css']
})

export class StadiumsComponent {
  constructor(private apiService: ApiService) { }
  stadiums : any;
  cities : any;

  async ngOnInit(): Promise<void>{
    this.stadiums = await this.getStadiums();
    this.cities = await this.getCities();
    //for every stadium, add the city name to the stadium object, as stadium.cityId = city.id
    this.stadiums.forEach((stadium: any) => {
      stadium.cityName = this.cities.find((city: any) => city.id === stadium.cityId).name;
      stadium.logo = 'https://www.qatar2022.qa/sites/default/files/2022-07/' + stadium.name + '.png';
    });

    this.stadiums.forEach((stadium: { expanded: boolean; }) => stadium.expanded = false);

    console.log(this.stadiums);

  };

  async getStadiums(): Promise<AxiosResponse>{
    const data = await this.apiService.call('get', 'Stadium');
    console.log(data.data);
    return data.data;
  }

  async getCities(): Promise<AxiosResponse>{
    const data = await this.apiService.call('get', 'City/get-all-cities');
    console.log(data.data);
    return data.data;
  }

  toggleExpanded(stadium: any){
    // Set the selected stadium to expanded
    stadium.expanded = !stadium.expanded;
  }

}



