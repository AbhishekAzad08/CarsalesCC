import { TestBed } from '@angular/core/testing';

import { VehicleCreationService } from './vehicle-creation.service';

describe('VehicleCreationService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: VehicleCreationService = TestBed.get(VehicleCreationService);
    expect(service).toBeTruthy();
  });
});
