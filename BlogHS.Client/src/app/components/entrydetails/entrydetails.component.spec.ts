import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EntrydetailsComponent } from './entrydetails.component';

describe('EntrydetailsComponent', () => {
  let component: EntrydetailsComponent;
  let fixture: ComponentFixture<EntrydetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EntrydetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EntrydetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
