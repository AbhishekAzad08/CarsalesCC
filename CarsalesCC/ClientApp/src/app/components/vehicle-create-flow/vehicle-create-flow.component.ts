import { Component, OnInit, Input } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { VehicleType } from '../../enums/vehicle-type.enum'

@Component({
  selector: 'app-vehicle-create-flow',
  templateUrl: './vehicle-create-flow.component.html',
  styleUrls: ['./vehicle-create-flow.component.css']
})
export class VehicleCreateFlowComponent implements OnInit {
  vehicleTypeFromEnum = VehicleType;
  submitted: boolean;
  @Input() vehicleType: string;
  createForm: FormGroup;
  public vehicelDetails = {
    make: '',
    model:'',
    vehicletype: '',
    
  };
  validation_messages = {
    'make': [
      { type: 'required', message: 'Make is required' },
      { type: 'maxlength', message: 'Make cannot be more than 25 characters long' },
    ],
    'vehicletype': [
      { type: 'required', message: 'Type is required' },
      { type: 'maxlength', message: 'Type cannot be more than 25 characters long' },
    ],
    'model': [
      { type: 'required', message: 'Model is required' },
      { type: 'maxlength', message: 'Model cannot be more than 25 characters long' },
    ]
  }
  constructor(protected formBuilder: FormBuilder) {
    
  }
  actionFunction(msgFromChild: boolean) {
    this.submitted = msgFromChild;
    if (this.createForm.invalid) {
      return;
    }   
  }

  get f() { return this.createForm.controls; }

  ngOnInit() {
    this.createForm = this.formBuilder.group({
      make: ['', Validators.compose([Validators.required, Validators.maxLength(25)])],
      vehicletype: ['', Validators.required],
      model: ['', Validators.compose([Validators.required, Validators.maxLength(25)])],
      
    });
    this.vehicelDetails.vehicletype = this.vehicleTypeFromEnum[ this.vehicleType];
  }

}
