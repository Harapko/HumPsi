
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {NavMenuHeadlinesComponent} from "./components/nav-menu-headlines/nav-menu-headlines.component";
import {HeaderComponent} from "./components/header/header.component";
import {FooterComponent} from "./components/footer/footer.component";
import {HomePageComponent} from "./components/home-page/home-page.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, HeaderComponent, FooterComponent, NavMenuHeadlinesComponent, HomePageComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'AngularApp';
}




