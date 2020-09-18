import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormBuilder, FormControl } from '@angular/forms';
import { VehicleCreationService } from '../../services/vehicle-creation.service';

@Component({
  selector: 'cars',
  templateUrl: './cars.component.html',
  styleUrls: ['./cars.component.css']
})
export class CarsComponent implements OnInit {

  @Input() parentForm: FormGroup
  carFormGroup: FormGroup;
  public vehicelDetails = {
    doors: '',
    engine: '',
    bodytype: '',
    wheels: '',
  };
  constructor(private vehicalService: VehicleCreationService, protected formBuilder: FormBuilder) {
  
  }
  actionFunction() {
    var formgrp = this.carFormGroup;
    var answers = formgrp['value'];
    var typeAnswer = answers['type'];
    var makeAnswer = answers['make'];
    var modelAnswer = answers['model'];
    var doorsAnswer = answers['doors'];
    var bodytypeAnswer = answers['bodytype'];
    var engineAnswer = answers['engine'];
    var wheelsAnswer = answers['wheels'];

    this.vehicalService.createVehicle(answers);
  }
  get f() { return this.carFormGroup.controls; }
  ngOnInit() {
    this.carFormGroup = this.parentForm;
    this.carFormGroup.addControl('doors', new FormControl('', []))
    this.carFormGroup.addControl('bodytype', new FormControl('', []))
    this.carFormGroup.addControl('engine', new FormControl('', []))
    this.carFormGroup.addControl('wheels', new FormControl('', []))
    //this.carFormGroup = this.formBuilder.group({
    //  wheels: ['']
    //});
  }

}
