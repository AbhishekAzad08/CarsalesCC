import { Component, OnInit, Input } from '@angular/core';
import { FormControl, FormGroup, FormBuilder } from '@angular/forms';
import { VehicleType } from '../../enums/vehicle-type.enum'

@Component({
  selector: 'app-vehicle-create-flow',
  templateUrl: './vehicle-create-flow.component.html',
  styleUrls: ['./vehicle-create-flow.component.css']
})
export class VehicleCreateFlowComponent implements OnInit {
  vehicleTypeFromEnum= VehicleType;
  @Input() vehicleType: string;
  private formControl = new FormControl();
  createForm: FormGroup;
  public vehicelDetails = {
    make: '',
    model:'',
    type: '',
    
    
  };
  constructor(protected formBuilder: FormBuilder) {
    
  }

  get f() { return this.createForm.controls; }
  ngOnInit() {
    this.createForm = this.formBuilder.group({
      make: [''],
      type: [''],
      model: [''],
      
    });
    this.vehicelDetails.type = this.vehicleTypeFromEnum[ this.vehicleType];
  }

}
