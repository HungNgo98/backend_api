import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ProductComponent} from "./product/product.component";
import {AdminRoutingModule} from "./admin-routing.module";


@NgModule({
  declarations: [ProductComponent],
  imports: [
    CommonModule,
    AdminRoutingModule
  ]
})
export class AdminModule {
}
