import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditHeadlinesComponent } from './edit-headlines.component';

describe('EditHeadlinesComponent', () => {
  let component: EditHeadlinesComponent;
  let fixture: ComponentFixture<EditHeadlinesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditHeadlinesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditHeadlinesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
