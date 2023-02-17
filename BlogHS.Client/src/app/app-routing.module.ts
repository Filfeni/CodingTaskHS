import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EntrycardlistComponent } from './components/entrycardlist/entrycardlist.component';
import { NewentryComponent } from './components/newentry/newentry.component';


const routes: Routes = [
  { path: '', component: EntrycardlistComponent },
  { path: 'new', component: NewentryComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
