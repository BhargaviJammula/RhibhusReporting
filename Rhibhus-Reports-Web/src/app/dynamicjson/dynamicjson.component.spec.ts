import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicjsonComponent } from './dynamicjson.component';

describe('DynamicjsonComponent', () => {
  let component: DynamicjsonComponent;
  let fixture: ComponentFixture<DynamicjsonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DynamicjsonComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DynamicjsonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
