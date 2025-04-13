import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DditemComponent } from './dditem.component';

describe('DditemComponent', () => {
  let component: DditemComponent;
  let fixture: ComponentFixture<DditemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DditemComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DditemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
