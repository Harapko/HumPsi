import { Component } from '@angular/core';
import {AsyncPipe, NgForOf} from "@angular/common";
import {SectionService, SectionsModel} from "../../services/navMenu/section.service";
import {NavMenuHeadlinesComponent} from "../nav-menu-headlines/nav-menu-headlines.component";
import {Observable} from "rxjs";

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    NavMenuHeadlinesComponent,
    AsyncPipe
  ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {

public sections$?: Observable<SectionsModel[]>

  constructor(private sectionService: SectionService) { }

  ngOnInit(){
    this.sections$ = this.sectionService.getSection();
  }

}
