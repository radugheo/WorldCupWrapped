import { Component } from '@angular/core';
import { StadiumService } from 'src/app/services/stadiums.service';
import { CityService } from 'src/app/services/cities.service';


@Component({
  selector: 'app-stadiums',
  templateUrl: './stadiums.component.html',
  styleUrls: ['./stadiums.component.css']
})

export class StadiumsComponent {
  constructor(private stadiumService: StadiumService, private cityService: CityService) { }
  stadiums : any;
  cities : any;

  async ngOnInit(): Promise<void>{

    await this.stadiumService.getStadiums().then(stadiums => {
      this.stadiums = stadiums;
      console.log(this.stadiums);
    });

    await this.cityService.getCities().then(cities => {
      this.cities = cities;
      console.log(this.cities);
    });
    //for every stadium, add the city name to the stadium object, as stadium.cityId = city.id
    this.stadiums.forEach((stadium: any) => {
      stadium.cityName = this.cities.find((city: any) => city.id === stadium.cityId).name;
      stadium.logo = 'https://www.qatar2022.qa/sites/default/files/2022-07/' + stadium.name + '.png';
    });

    this.stadiums.forEach((stadium: { expanded: boolean; }) => stadium.expanded = false);

    console.log(this.stadiums);

  };

  toggleExpanded(stadium: any){
    // Set the selected stadium to expanded
    stadium.expanded = !stadium.expanded;
  }

}



