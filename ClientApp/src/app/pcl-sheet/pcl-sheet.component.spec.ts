import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PclSheetComponent } from './pcl-sheet.component';

describe('PclSheetComponent', () => {
  let component: PclSheetComponent;
  let fixture: ComponentFixture<PclSheetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PclSheetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PclSheetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
