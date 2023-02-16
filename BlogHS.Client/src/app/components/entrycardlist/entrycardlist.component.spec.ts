import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EntrycardlistComponent } from './entrycardlist.component';

describe('EntrycardlistComponent', () => {
  let component: EntrycardlistComponent;
  let fixture: ComponentFixture<EntrycardlistComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EntrycardlistComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EntrycardlistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
