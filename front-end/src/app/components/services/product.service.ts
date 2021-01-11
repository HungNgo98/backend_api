import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {environment} from "../../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  urlApi = environment.urlApi;

  constructor(
    private http: HttpClient
  ) {
  }

  list(param?: any) {
    return this.http.get(this.urlApi + 'product/list')
  }

  create(body: any) {
    return this.http.post(this.urlApi + 'product/create', body)
  }

  delete(id: number) {
    return this.http.delete(this.urlApi + 'product/delete/' + id)
  }
}
