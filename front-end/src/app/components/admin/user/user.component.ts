import {Component, OnInit} from '@angular/core';
import {UserService} from '../../services/user.service';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import {Router} from '@angular/router';
import {ToastrService} from 'ngx-toastr';
import validate = WebAssembly.validate;


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {

  p = 1;
  page = 1;
  user: any;
  isShowModal = false;
  isAddOrEdit = false;
  userForm = new FormGroup({});


  constructor(
    private userService: UserService,
    private router: Router,
    private toastr: ToastrService
  ) {
  }

  ngOnInit(): void {
    this.list();
    this.buildForm();
  }

  buildForm(user?: any): void {
    this.userForm = new FormGroup({
      id: new FormControl(user ? user.id : null,),
      name: new FormControl(user ? user.name : null, [Validators.required]),
      sex: new FormControl(user ? user.sex : null),
      email: new FormControl(user ? user.email : null),
      password: new FormControl(user ? user.password : null),
      password_confirmation: new FormControl(user ? user.password_confirmation : null)
    });
  }

  addOrEdit(s?: any): void {
    this.isShowModal = true;
    if (s) {
      this.isAddOrEdit = true;
      this.buildForm(s);
    } else {
      this.isAddOrEdit = false;
      this.buildForm();
    }
  }

  closeModal(): void {
    this.isShowModal = false;
  }

  list(): void {
    this.userService.list().subscribe((res: any) => {
      this.user = res.data;
    }, (error: any) => {
      // console.log(3233, error);
    });
  }

  delete(id: number): void {
    this.userService.delete(id).subscribe(res => {
      this.toastr.success('Xoa', 'Thành công');
      this.list();
    }, error => {
      this.toastr.error(error, 'Loi');
    });
  }


  submit(): void {
    if (this.userForm.get('id')?.value) {
      this.userService.update(this.userForm.value).subscribe(res => {
        this.list();
        this.isShowModal = false;
        this.toastr.success('Sửa', 'Thành công');
      }, error => {
        this.toastr.error(error, 'Loi');
      });
    } else {
      console.log(this.userForm.value);
      this.userService.create(this.userForm.value).subscribe(res => {
        this.list();
        this.isShowModal = false;
        this.toastr.success('Them', 'Thành công');
      });
    }
  }
}
