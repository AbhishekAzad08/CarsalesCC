import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ModalModule } from 'ngx-bootstrap';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { VehicleComponent } from './components/vehicle/vehicle.component';
import { VehicleCreateFlowComponent } from './components/vehicle-create-flow/vehicle-create-flow.component';
import { CarsComponent } from './components/cars/cars.component';
import { VehicleDirective } from './directives/vehicle.directive';
import { BikesComponent } from './components/bikes/bikes.component';
import { BaseService } from './services/base.service';
import { VehicleCreationService } from './services/vehicle-creation.service';
import { CreateSuccessComponent } from './modals/create-success/create-success.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    VehicleComponent,
    VehicleCreateFlowComponent,
    CarsComponent,
    VehicleDirective,
    BikesComponent,
    CreateSuccessComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    ModalModule.forRoot(),
    FormsModule, ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'create', component: VehicleCreateFlowComponent },
    ])
  ],
  providers: [BaseService, VehicleCreationService],
  bootstrap: [AppComponent],
  entryComponents: [CreateSuccessComponent]
})
export class AppModule { }
