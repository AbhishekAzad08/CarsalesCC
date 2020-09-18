
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { environment } from '../../environments/environment';
import { BehaviorSubject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class VehicleCreationService extends BaseService {

  baseUrl = environment.baseUrl;
  createVehicleObj: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);
  public forecasts: WeatherForecast[];

  constructor(httpClient: HttpClient) {
    super(httpClient);
  }

  createVehicle(data:any) {
    this.httpClient.get<WeatherForecast[]>(this.baseUrl + 'weatherforecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

}
interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
