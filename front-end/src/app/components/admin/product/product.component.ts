import {Component, OnInit} from '@angular/core';
import {ProductService} from '../../services/product.service';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {Router} from "@angular/router";

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  products: any;
  productForm: FormGroup = new FormGroup({
    id: new FormControl(''),
    name_product: new FormControl('', [Validators.required]),
    img: new FormControl(''),
    price: new FormControl('', [Validators.required]),
    contents: new FormControl('', [Validators.required])
  });


  constructor(
    private productService: ProductService,
    private router: Router
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

  editPatch(product: any): void {
    this.productForm.reset(product);
    // this.productForm.patchValue(product);
    // this.productForm.setValue(product)
  }

  delete(id: number) {
    this.productService.delete(id).subscribe();
  }

  get f() {
    return this.productForm.controls;
  }

  submit() {
    if(this.productForm.get('id')?.value) {
      this.productService.update(this.productForm.value).subscribe(res => {
        alert('Sửa Thành Công!');
        this.list();
      })
    } else {
      this.productService.create(this.productForm.value).subscribe(res => {
        alert('Thêm Thành Công!');
        this.list();
      });
    }
  }

  // create(data?: any) {
  //     this.productForm = new FormGroup({
  //       name_product: new FormControl(data ? data.name_product : '', [Validators.required]),
  //       img: new FormControl('', [Validators.required]),
  //       price: new FormControl('', [Validators.required]),
  //       content: new FormControl('', [Validators.required])
  //     });
  // }
}
