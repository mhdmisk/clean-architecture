import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DditemComponent } from './dditem.component';

const routes: Routes = [{ path: '', component: DditemComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DditemRoutingModule { }
