import {Component, OnInit} from '@angular/core';
import {CategoryService} from '../../services/category.service';
import {FormControl, FormGroup} from '@angular/forms';
import {Router} from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {
   // category: any;
  categories: any;
  categoryForm = new FormGroup({
    id: new FormControl(),
    name: new FormControl(),
    description: new FormControl()
  });

  constructor(
    private categoryService: CategoryService,
    private router: Router,
    private toastr: ToastrService
  ) {
  }

  ngOnInit(): void {
    this.all();
  }

  // tslint:disable-next-line:typedef
  all() {
    this.categoryService.all().subscribe((res: any) => {
      this.categories = res;
    }, (error: any) => {
      console.log(2, error);
    });
  }

// tslint:disable-next-line:typedef
  get () {
    return this.categoryForm.controls;
  }
  editCategory(category: any): void{
    this.categoryForm.reset(category);
  }
// tslint:disable-next-line:typedef
  submit() {
    if (this.categoryForm.get('id')?.value)
    {
      this.categoryService.update(this.categoryForm.value).subscribe(res => {
        this.all();
        this.toastr.success('Sửa', 'Thành công');
      }, error => {
        this.toastr.error(error, 'Lỗi');
      });
      }
    else {
        this.categoryService.create(this.categoryForm.value).subscribe(res => {
          this.all();
          this.toastr.success('Thêm', 'Thành công');
        }, error => {
          this.toastr.error(error, 'Thất bại');
        });
    }
  }
  // tslint:disable-next-line:typedef
  deleteCategory(id: number){
    this.categoryService.delete(id).subscribe(res => {
      this.all();
      this.toastr.success('Xóa', 'Thành công');
    }, error => {
      this.toastr.error(error, 'Thất bại');
    });
  }
}
