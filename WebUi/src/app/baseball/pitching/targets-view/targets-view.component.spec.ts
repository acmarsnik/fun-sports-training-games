import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TargetsViewComponent } from './targets-view.component';

describe('TargetViewComponent', () => {
  let component: TargetsViewComponent;
  let fixture: ComponentFixture<TargetsViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TargetsViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TargetsViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
