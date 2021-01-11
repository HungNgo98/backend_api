import {Component, OnInit} from '@angular/core';
import {ProductService} from "../../services/product.service";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  products: any;

  constructor(
    private productService: ProductService
  ) {
  }

  ngOnInit(): void {
    this.list();
  }

  list() {
    this.productService.list().subscribe((res: any) => {
      this.products = res;
    }, (error: any) => {
      console.log(2, error);
    });
  }
}
