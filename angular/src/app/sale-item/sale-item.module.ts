import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { SaleItemRoutingModule } from './sale-item-routing.module';
import { SaleItemComponent } from './sale-item.component';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [SaleItemComponent],
  imports: [
    SharedModule,
    SaleItemRoutingModule,
    NgbDatepickerModule
  ]
})
export class SaleItemModule { }
