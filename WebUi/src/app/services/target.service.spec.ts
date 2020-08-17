import { TestBed, inject } from '@angular/core/testing';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { TargetService } from './target.service';

describe('TargetService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [TargetService],
    });
  });

  it('should be created', inject([TargetService], (service: TargetService) => {
    expect(service).toBeTruthy();
  }));
});
