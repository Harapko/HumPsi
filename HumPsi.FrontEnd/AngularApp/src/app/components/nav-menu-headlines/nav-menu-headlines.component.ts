import {Component, Input} from '@angular/core';
import {SectionsModel} from "../../services/navMenu/section.service";

@Component({
  selector: 'app-nav-menu-headlines',
  standalone: true,
  imports: [],
  templateUrl: './nav-menu-headlines.component.html',
  styleUrl: './nav-menu-headlines.component.scss'
})
export class NavMenuHeadlinesComponent {
  @Input() section! : SectionsModel;
}
