import { Component, ViewChild, ComponentFactoryResolver } from '@angular/core';
import { VehicleDirective } from '../directives/vehicle.directive';
import { VehicleCreateFlowComponent } from '../components/vehicle-create-flow/vehicle-create-flow.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  @ViewChild(VehicleDirective, { static: true }) vehicleHost: VehicleDirective;
  constructor(private componentFactoryResolver: ComponentFactoryResolver) { }
  private vehicles = [
    {
      id: "0",
      value: ""
    },
    {
      id: "1",
      value: "Cars"
    },
    {
      id: "2",
      value: "Bikes"
    }
  ]
  filterChanged(data:any) {

    const componentFactory = this.componentFactoryResolver.resolveComponentFactory(VehicleCreateFlowComponent);
    const viewContainerRef = this.vehicleHost.viewContainerRef;
    viewContainerRef.clear();

    const componentRef = viewContainerRef.createComponent<VehicleCreateFlowComponent>(componentFactory);
    componentRef.instance.vehicleType = data;
  }
}
