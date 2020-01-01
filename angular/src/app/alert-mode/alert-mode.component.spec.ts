import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AlertModeComponent } from './alert-mode.component';

describe('AlertModeComponent', () => {
  let component: AlertModeComponent;
  let fixture: ComponentFixture<AlertModeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlertModeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AlertModeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
