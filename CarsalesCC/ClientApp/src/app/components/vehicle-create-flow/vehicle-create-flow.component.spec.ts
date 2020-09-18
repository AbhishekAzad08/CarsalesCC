import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VehicleCreateFlowComponent } from './vehicle-create-flow.component';

describe('VehicleCreateFlowComponent', () => {
  let component: VehicleCreateFlowComponent;
  let fixture: ComponentFixture<VehicleCreateFlowComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VehicleCreateFlowComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VehicleCreateFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
