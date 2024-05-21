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

  displayEditHeadline: boolean = false;
  displayAddHeadline: boolean = false;

  toggleEditHeadline(headline: Headlines){
    this.selectedHeadline = headline;
    this.displayEditHeadline = true;
  }

  toggleAddHeadline(){
    this.displayAddHeadline = true;
  }

  selectedHeadline: Headlines = {
    id: '',
    title: '',
    sectionId: '',
    photo: '',
}

  onConfirmEdit(headline: Headlines){
    if(this.selectedHeadline.id != null){
      return
    }
    this.editHeadlines(headline, this.selectedHeadline.id);
    this.displayEditHeadline = false;
  }

  onConfirmAdd(headline: Headlines){
    this.createHeadlines(headline);
    this.displayEditHeadline = false;
  }

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

  editHeadlines(headlines: Headlines, id: string){
    this.headlineService.editHeadline(`http://localhost:5198/editHeadlines/${id}`, headlines).subscribe({
      next: (data) => {
        console.log(data)
        this.getHeadlines();
      },
      error: (error) =>{
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

  createHeadlines(headlines: Headlines){
    this.headlineService.createHeadlines(`http://localhost:5198/createHeadlines`, headlines).subscribe({
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



