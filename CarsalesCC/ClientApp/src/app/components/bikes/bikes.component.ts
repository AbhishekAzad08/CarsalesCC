import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { VehicleCreationService } from '../../services/vehicle-creation.service';

@Component({
  selector: 'bikes',
  templateUrl: './bikes.component.html',
  styleUrls: ['./bikes.component.css']
})
export class BikesComponent implements OnInit {
  @Input() parentForm: FormGroup
  bikeFormGroup: FormGroup;

  constructor(private vehicalService: VehicleCreationService, protected formBuilder: FormBuilder) { }
  actionFunction() {
    var formgrp = this.bikeFormGroup;
    var answers = formgrp['value'];
    
  }
  ngOnInit() {
    this.bikeFormGroup = this.parentForm;
    //Add bike specific form control here in the parentFormGroup
  }

}
