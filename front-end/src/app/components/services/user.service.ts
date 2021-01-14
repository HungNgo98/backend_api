import {Injectable} from '@angular/core';
import {environment} from '../../../environments/environment';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  urlApi = environment.urlApi;

  constructor(
    private  http: HttpClient
  ) {
  }

  // tslint:disable-next-line:typedef
  private httpOptions: any;
  list(param?: any) {
    return this.http.get(this.urlApi + 'user/getlist');
  }

  create(body: any) {
    return this.http.post(this.urlApi + 'user/create', body);
  }

  delete(id: number) {
    return this.http.delete(this.urlApi + 'user/delete/' + id);
  }
  update(body: any){
    return this.http.post(this.urlApi + 'user/update/' + body.id, body);
  }
}
