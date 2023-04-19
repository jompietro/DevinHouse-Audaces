import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExercicioS08Component } from './exercicio-s08.component';

describe('ExercicioS08Component', () => {
  let component: ExercicioS08Component;
  let fixture: ComponentFixture<ExercicioS08Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExercicioS08Component ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExercicioS08Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
