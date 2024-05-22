import {Component, Input} from '@angular/core';
import {Headlines, Section} from "../../../../types";
import {HeadlinesService} from "../../../services/navMenu/headlines.service";
import {RouterLink} from "@angular/router";
import {EditHeadlinesComponent} from "../edit-headlines/edit-headlines.component";
import {ButtonModule} from "primeng/button";

@Component({
  selector: 'app-nav-menu-headlines',
  standalone: true,
  imports: [
    RouterLink,
    EditHeadlinesComponent,
    ButtonModule
  ],
  templateUrl: './nav-menu-headlines.component.html',
  styleUrl: './nav-menu-headlines.component.scss'
})
export class NavMenuHeadlinesComponent {
  @Input() section! : Section;




  constructor(private headlineService: HeadlinesService) {
  }

  headline: Headlines[] = [];


  getHeadlines(){
    this.headlineService.getHeadlines("http://localhost:5198/getAllHeadlines").subscribe({
      next: (headlines: Headlines[]) => {
        this.headline = headlines;
      },
      error: (error) => {
        console.log(error)
      }
    })
  }



  deleteHeadlines(id: number){
    this.headlineService.deleteHeadline(`http://localhost:5198/deleteHeadlines/${id}`).subscribe({
      next: (data) => {
        console.log(data)
        this.getHeadlines();
      },
      error: (error) => {
        console.log(error)
      }
    })
  }





  ngOnInit(){
    this.getHeadlines();
  }
}



