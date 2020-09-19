
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from './base.service';
import { environment } from '../../environments/environment';
import { BehaviorSubject } from 'rxjs';
import { CarCreateRequest } from '../models/request/car.create.request';


@Injectable({
  providedIn: 'root'
})
export class VehicleCreationService extends BaseService {

  baseUrl = environment.baseUrl;


  constructor(httpClient: HttpClient) {
    super(httpClient);
  }

  createCar(data: CarCreateRequest) {

    return this.httpClient.post(`${this.baseUrl}cars/create`, data);
  
  }

}
