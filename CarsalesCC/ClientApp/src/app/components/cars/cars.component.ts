import { Component, OnInit, Input,EventEmitter,Output } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { VehicleCreationService } from '../../services/vehicle-creation.service';
import { BsModalRef } from 'ngx-bootstrap/modal/bs-modal-ref.service';
import { BsModalService } from 'ngx-bootstrap';
import { CreateSuccessComponent } from '../../modals/create-success/create-success.component';

@Component({
  selector: 'cars',
  templateUrl: './cars.component.html',
  styleUrls: ['./cars.component.css']
})
export class CarsComponent implements OnInit {

  @Input() parentForm: FormGroup;
  @Output() toParent = new EventEmitter<boolean>();
  submitted = false;
  public createSuccessModal: BsModalRef;
  carFormGroup: FormGroup;
  public vehicelDetails = {
    doors: '',
    engine: '',
    bodytype: '',
    wheels: '',
  };
  validation_messages = {
    'doors': [
      { type: 'required', message: 'doors is required' },      
      { type: 'pattern', message: 'Only numbers allowed' },
    ],
    'engine': [
      { type: 'required', message: 'engine is required' },
      { type: 'maxlength', message: 'engine cannot be more than 25 characters long' },
    ],
    'wheels': [
      { type: 'required', message: 'wheels is required' },
      { type: 'pattern', message: 'Only numbers allowed' },
    ],
    'bodytype': [
      { type: 'required', message: 'bodytype is required' },
      { type: 'maxlength', message: 'bodytype cannot be more than 25 characters long' },
    ]
  }
  constructor(private vehicalService: VehicleCreationService, protected formBuilder: FormBuilder, private modalService: BsModalService) {
  
  }

  actionFunction() {
    this.submitted = true;
    this.toParent.emit(true);
    //var formgrp = this.carFormGroup;
    if (this.carFormGroup.invalid) {
      return;
    }
    var answers = this.carFormGroup['value'];
    this.vehicalService.createCar(answers).subscribe(result => {
      this.modalService.show(CreateSuccessComponent, {
        animated: true,
        keyboard: true,
        backdrop: true,
        ignoreBackdropClick: true,
        initialState: { carId: result.id.toString() },
      });
      this.toParent.emit(true);
      this.parentForm.markAsUntouched();
      this.parentForm.markAsPristine();
      this.parentForm.reset();
      
    }, error => console.error(error));
      
  }
  get f() { return this.carFormGroup.controls; }
  ngOnInit() {
    this.carFormGroup = this.parentForm;
    this.carFormGroup.addControl('doors', new FormControl('', Validators.compose([Validators.required, Validators.pattern('^[0-9]*$')])))
    this.carFormGroup.addControl('bodytype', new FormControl('', Validators.required))
    this.carFormGroup.addControl('engine', new FormControl('', Validators.required))
    this.carFormGroup.addControl('wheels', new FormControl('', Validators.compose([Validators.required, Validators.pattern('^[0-9]*$')])))
  
  }

}
