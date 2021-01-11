import {Component, OnInit} from '@angular/core';
import {ProductService} from '../../services/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  constructor(
    private productService: ProductService
  ) {
  }

  ngOnInit(): void {
    this.list();
  }

  list() {
    this.productService.list().subscribe((res: any) => {
      console.log(1, res);
    }, (error: any) => {
      console.log(2, error);
    });
  }

}
