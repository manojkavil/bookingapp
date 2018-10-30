import { TestBed } from '@angular/core/testing';

import { ApiService } from './api.service';

describe('Api.ServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: Api.Service = TestBed.get(Api.Service);
    expect(service).toBeTruthy();
  });
});
