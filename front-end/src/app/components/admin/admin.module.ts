import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ProductComponent} from './product/product.component';
import {AdminRoutingModule} from './admin-routing.module';
import { CategoryComponent } from './category/category.component';
import {FormsModule} from '@angular/forms';


@NgModule({
  declarations: [ProductComponent, CategoryComponent],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule
  ]
})
export class AdminModule {
}
