import { Directive, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[vehicleHost]'
})
export class VehicleDirective {

  constructor(public viewContainerRef: ViewContainerRef) { }

}
