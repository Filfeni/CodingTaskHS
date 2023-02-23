import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EntrycardlistComponent } from './components/entrycardlist/entrycardlist.component';
import { EntrydetailsComponent } from './components/entrydetails/entrydetails.component';
import { NewentryComponent } from './components/newentry/newentry.component';


const routes: Routes = [
  { path: '', component: EntrycardlistComponent },
  { path: 'new', component: NewentryComponent },
  { path: 'update/:id', component: NewentryComponent },
  { path: 'detail/:id', component: EntrydetailsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
