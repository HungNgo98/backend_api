import {Component, OnInit} from '@angular/core';
import {ProductService} from '../../services/product.service';
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {Router} from "@angular/router";
import {environment} from "../../../../environments/environment";
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {

  urlImage = environment.urlImage;
  products: any;
  productForm = new FormGroup({});
  isShowModal= false;
  isCreate= false;
   name = '';


  constructor(
    private productService: ProductService,
    private router: Router,
    private toastr: ToastrService
  ) {
  }

  ngOnInit(): void {
    this.list();
    this.buildForm();
  }

  list() {
    this.productService.list(this.name).subscribe((res: any) => {
      this.products = res.data;
    }, (error: any) => {
      this.toastr.success('Xóa Lỗi');
    });
  }

  editPatch(product? : any): void {
    this.isShowModal=true;
    if (product){
      this.isCreate= true;
      this.buildForm(product);
    }else{
      this.isCreate= false;
      this.buildForm();
    }
  }

  buildForm(product? : any){
    this.productForm = new FormGroup({
      id: new FormControl(product ? product.id : null),
      name_product: new FormControl(product ? product.name_product : null, [Validators.required]),
      img: new FormControl(product ? product.img : null, [Validators.required]),
      price: new FormControl(product ? product.price : null, [Validators.required]),
      contents: new FormControl(product ? product.contents : null)
    });
  }

  closeModal(){
    this.isShowModal = false;
  }

  delete(id: number) {
    this.productService.delete(id).subscribe(res => {
      this.toastr.success('Xóa Thành Công', 'Thành Công');
      this.list();
    }, error => {
      this.toastr.success('Xóa Lỗi')
    })
  }

  get f() {
    return this.productForm.controls;
  }

  submit() {
    if(this.productForm.get('id')?.value) {
      this.productService.create(this.productForm.value).subscribe(res => {
        this.toastr.success('Thêm thành công', 'Thành công');
        this.isShowModal = false;
        this.list();
      },error => {
        this.toastr.success('Thêm Lỗi !!!');
      });
    } else {
      this.productService.update(this.productForm.value).subscribe(res => {
        this.toastr.success('Sửa thành công', 'Thành công');
        this.isShowModal = false;
        this.list();
      }, error => {
        this.toastr.error(error, 'Sửa Lỗi !!!');
      });
    }
  }

  fileEvent(event : any){
    const file = event.dataTransfer ? event.dataTransfer.files[0] : event.target.files[0];
    if (file || file != undefined) {
      this.productService.upload({img: file}).subscribe((res: any) => {
        this.toastr.success('Thêm ảnh thành công', 'Thành công');
        this.productForm.get('img')?.setValue(res.img)
      }, error => {
        this.toastr.error(error, 'Upload Ảnh Lỗi!!!');
      });
    }
  }

  setValue() {
    this.list();
  }
}
