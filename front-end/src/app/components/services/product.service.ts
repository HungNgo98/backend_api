import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  urlApi = environment.urlApi;

  constructor(
    private http: HttpClient
  ) {
  }
  // tslint:disable-next-line:typedef
  list(param?: any) {
    return this.http.get(this.urlApi + 'product/list');
  }
  // tslint:disable-next-line:typedef
  create(body: any) {
    return this.http.post(this.urlApi + 'product/create', body);
  }
  update(body: any) {
    return this.http.post(this.urlApi + 'product/update/'+ body.id, body);
  }
  // tslint:disable-next-line:typedef
  delete(id: number) {
    return this.http.delete(this.urlApi + 'product/delete/' + id);
  }
}
