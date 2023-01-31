import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DecorationCircleComponent } from './decoration-circle.component';

describe('DecorationCircleComponent', () => {
  let component: DecorationCircleComponent;
  let fixture: ComponentFixture<DecorationCircleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DecorationCircleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DecorationCircleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
