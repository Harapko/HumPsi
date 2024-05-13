import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateHeadlinesComponent } from './create-headlines.component';

describe('CreateHeadlinesComponent', () => {
  let component: CreateHeadlinesComponent;
  let fixture: ComponentFixture<CreateHeadlinesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CreateHeadlinesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateHeadlinesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
