/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { TarrifServiceService } from './tarrifService.service';

describe('Service: TarrifService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [TarrifServiceService]
    });
  });

  it('should ...', inject([TarrifServiceService], (service: TarrifServiceService) => {
    expect(service).toBeTruthy();
  }));
});
