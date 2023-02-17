import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewentryComponent } from './newentry.component';

describe('NewentryComponent', () => {
  let component: NewentryComponent;
  let fixture: ComponentFixture<NewentryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewentryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewentryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
