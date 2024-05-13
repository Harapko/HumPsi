import { Routes } from '@angular/router';
import {HeaderComponent} from "./components/header/header.component";
import {FooterComponent} from "./components/footer/footer.component";
import {HomePageComponent} from "./components/home-page/home-page.component";
import {CreateHeadlinesComponent} from "./components/create-headlines/create-headlines.component";

export const routes: Routes = [
  {path: '', redirectTo: "home", pathMatch: "full"},
  {path: "home", component: HomePageComponent},
  {path: "create", component: CreateHeadlinesComponent}
];
