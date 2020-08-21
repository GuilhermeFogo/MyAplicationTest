import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GerenciaClienteComponent } from './gerencia-cliente.component';

describe('GerenciaClienteComponent', () => {
  let component: GerenciaClienteComponent;
  let fixture: ComponentFixture<GerenciaClienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GerenciaClienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GerenciaClienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
