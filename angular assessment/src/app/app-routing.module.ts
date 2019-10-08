import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NavcomponentComponent } from './navcomponent/navcomponent.component';
import { EmpcreatComponent } from './empcreat/empcreat.component';
import { EmpreadComponent } from './empread/empread.component';
import {AppComponent} from './app.component';
import { EditComponent } from './edit/edit.component';
const routes: Routes = [
  {path:'',component:AppComponent},
  {path:'READ',component:EmpreadComponent},
  {path:'CREATE',component:EmpcreatComponent},
  {path:'Edit/:id',component:EditComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
