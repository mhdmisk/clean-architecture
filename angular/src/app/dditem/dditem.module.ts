import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';

import { DditemRoutingModule } from './dditem-routing.module';
import { DditemComponent } from './dditem.component';


@NgModule({
  declarations: [
    DditemComponent
  ],
  imports: [
    SharedModule,
    DditemRoutingModule
  ]
})
export class DditemModule { }
