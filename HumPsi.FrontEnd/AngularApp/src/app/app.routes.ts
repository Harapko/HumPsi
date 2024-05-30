import {RouterModule, Routes} from '@angular/router';
import {HomePageComponent} from "./components/home-page/home-page.component";
import {HeaderComponent} from "./components/layout/header/header.component";
import {EditHeadlinesComponent} from "./components/Headlines/edit-headlines/edit-headlines.component";
import {NgModule} from "@angular/core";

export const routes: Routes = [
  {path: "", component: HomePageComponent},
  {path: "", component: HeaderComponent},
  {path: "create/:sectionId", component: EditHeadlinesComponent}
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
