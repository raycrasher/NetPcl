import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PclItemComponent } from './pcl-item.component';

describe('PclItemComponent', () => {
  let component: PclItemComponent;
  let fixture: ComponentFixture<PclItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PclItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PclItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
