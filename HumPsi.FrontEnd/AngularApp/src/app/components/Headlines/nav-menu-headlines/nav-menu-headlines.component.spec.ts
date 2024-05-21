import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavMenuHeadlinesComponent } from './nav-menu-headlines.component';

describe('NavMenuHeadlinesComponent', () => {
  let component: NavMenuHeadlinesComponent;
  let fixture: ComponentFixture<NavMenuHeadlinesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NavMenuHeadlinesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NavMenuHeadlinesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
