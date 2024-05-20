import { Routes } from '@angular/router';
import {HomePageComponent} from "./components/home-page/home-page.component";
import {CreateHeadlinesComponent} from "./components/create-headlines/create-headlines.component";
import {
  NavMenuHeadlinesComponent
} from "./components/nav-menu-headlines/nav-menu-headlines.component";

export const routes: Routes = [
  {path: "", component: HomePageComponent},
  {path: "", component: NavMenuHeadlinesComponent},
  {path: "create", component: CreateHeadlinesComponent}
];
