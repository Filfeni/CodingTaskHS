import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EntrycardlistComponent } from './components/entrycardlist/entrycardlist.component';


const routes: Routes = [{ path: '', component: EntrycardlistComponent },];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
