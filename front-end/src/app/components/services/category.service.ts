import { Injectable } from '@angular/core';
import {environment} from '../../../environments/environment';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  urlApi = environment.urlApi;
  constructor(
    private http: HttpClient
  ) { }
// tslint:disable-next-line:typedef
  all(param?: any){
    return this.http.get(this.urlApi + 'categories/all');
  }

  // tslint:disable-next-line:typedef
  create(body: any){
    return this.http.post(this.urlApi + 'categories/create', body);
  }

  // tslint:disable-next-line:typedef
  delete(id: number){
    return this.http.delete(this.urlApi + 'categories/delete/' + id);
  }
}
