import { TestBed } from '@angular/core/testing';

import { PersonagensStarWarsService } from './personagens-star-wars.service';

describe('PersonagensStarWarsService', () => {
  let service: PersonagensStarWarsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PersonagensStarWarsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
