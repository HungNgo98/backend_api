import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {ProductComponent} from './product/product.component';
import {AdminRoutingModule} from './admin-routing.module';
import { CategoryComponent } from './category/category.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { UserComponent } from './user/user.component';
import {NgxPaginationModule} from 'ngx-pagination';



@NgModule({
  declarations: [ProductComponent, CategoryComponent, UserComponent],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    NgxPaginationModule
  ]
})
export class AdminModule {
}
