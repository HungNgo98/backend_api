import { Component, OnInit } from '@angular/core';
import {CategoryService} from '../../services/category.service';


@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {
   category: any;

  constructor(
    private categoryService: CategoryService
  ) { }

  ngOnInit(): void {
    this.all();
  }
  all(){
  this.categoryService.all().subscribe((res: any) => {
    this.category = res;
  }, (error: any) => {
    console.log(2, error);
  });
}
}
