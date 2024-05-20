import {Component, Input} from '@angular/core';
import {Headlines, Section} from "../../../types";
import {HeadlinesService} from "../../services/navMenu/headlines.service";

@Component({
  selector: 'app-nav-menu-headlines',
  standalone: true,
  imports: [],
  templateUrl: './nav-menu-headlines.component.html',
  styleUrl: './nav-menu-headlines.component.scss'
})
export class NavMenuHeadlinesComponent {
  @Input() section! : Section;




  constructor(private headlineService: HeadlinesService) {
  }

  headline: Headlines[] = [];
  ngOnInit(){
   this.headlineService.getHeadlines("http://localhost:5198/getAllHeadlines").subscribe((headline: Headlines[]) => {
     this.headline = headline;
   });
  }
}



