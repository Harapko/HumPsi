import { Component } from '@angular/core';
import {NgForOf} from "@angular/common";
import {Section} from "../../models/navMenu/section";
import {SectionService} from "../../services/navMenu/section.service";
import {NavMenuHeadlinesComponent} from "../nav-menu-headlines/nav-menu-headlines.component";

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    NavMenuHeadlinesComponent
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  sections: Section[] = [];

  constructor(private sectionService: SectionService) {
  }

  ngOnInit(){
    this.sectionService.getSection()
      .subscribe({
        next: (response: Section[]) => {
          this.sections = response;
        },
        error: (error: any) => {
          console.log(error)
        },
        complete: () => {
        },
      });
  }

}
