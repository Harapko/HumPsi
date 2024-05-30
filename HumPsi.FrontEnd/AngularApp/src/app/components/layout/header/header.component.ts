import { Component } from '@angular/core';
import {AsyncPipe, NgForOf} from "@angular/common";
import {Observable} from "rxjs";
import {SectionService} from "../../../services/navMenu/section.service";
import {Section} from "../../../../types";
import {NavMenuHeadlinesComponent} from "../../Headlines/nav-menu-headlines/nav-menu-headlines.component";
import {EditHeadlinesComponent} from "../../Headlines/edit-headlines/edit-headlines.component";
import {RouterLink} from "@angular/router";

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    NavMenuHeadlinesComponent,
    AsyncPipe,
    EditHeadlinesComponent,
    RouterLink
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {
  constructor(private sectionService: SectionService) { }

  sections: Section[] = [];
  ngOnInit(){
    this.sectionService.getSection("http://localhost:5198/getSection").subscribe((section: Section[])=> {
      this.sections = section;
    });
  }

}
