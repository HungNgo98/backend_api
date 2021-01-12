import {Component, OnInit} from '@angular/core';
import {UserService} from '../../services/user.service';
import {FormControl, FormGroup} from '@angular/forms';
import {Router} from '@angular/router';
import { ToastrService } from 'ngx-toastr';


@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
  user: any;
  userForm = new FormGroup({
    id: new FormControl(''),
    name: new FormControl(''),
    sex: new FormControl(''),
    email: new FormControl(''),
    password: new FormControl(''),
    password_confirmation: new FormControl('')
  });



  constructor(
    private userService: UserService,
    private router: Router,
    private toastr: ToastrService
  ) {
  }

  ngOnInit(): void {
    this.list();
  }
  editPatch(s: any): void {
    this.userForm.reset(s);
  }


  list() {
    this.userService.list().subscribe((res: any) => {
      this.user = res;
    }, (error: any) => {
      console.log(3233, error);
    });
  }



  submit(){
    if (this.userForm.get('id')?.value)
    {
      this.userService.update(this.userForm.value).subscribe(res => {
        this.list();
        this.toastr.success('Sửa', 'Thành công');
      }, error => {
        this.toastr.error(error, 'Loi');
      });
    }
    else{
      console.log(this.userForm.value);
      this.userService.create(this.userForm.value).subscribe(res => {
        this.list();
      });
    }
    console.log(this.userForm.get('id')?.value);
    }
}
