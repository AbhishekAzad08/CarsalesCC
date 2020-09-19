import { Component, OnInit, Input } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-create-success',
  templateUrl: './create-success.component.html',
  styleUrls: ['./create-success.component.css']
})
export class CreateSuccessComponent implements OnInit {

  @Input() carID: string;
  constructor(private bsModalRef: BsModalRef) { }

  ngOnInit() {
  }
  closeModal() {
    this.bsModalRef.hide();
  }
}
