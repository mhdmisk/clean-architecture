import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SaleItemComponent } from './sale-item.component';

const routes: Routes = [{ path: '', component: SaleItemComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SaleItemRoutingModule { }
