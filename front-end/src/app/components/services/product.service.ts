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

  list(param?: any) {
    return this.http.get(this.urlApi + 'product/list', {params: {name: param}});
  }

  create(body: any) {
    return this.http.post(this.urlApi + 'product/create', body);
  }

  update(body: any) {
    return this.http.post(this.urlApi + 'product/update/' + body.id, body);
  }

  delete(id: number) {
    return this.http.delete(this.urlApi + 'product/delete/' + id);
  }

  upload(body: any) {
    let formData = new FormData();
    formData = this.convertModelToFormData(body);
    return this.http.post(this.urlApi + 'product/upload', formData);
  }

  search(name: any) {
    return this.http.get(this.urlApi + 'product/search/' + name);
  }

  // @ts-ignore
  convertModelToFormData(val, formData = new FormData(), namespace = '') {
    if ((typeof val !== 'undefined') && (val !== null)) {
      if (val instanceof Date) {
        formData.append(namespace, val.toISOString());
      } else if (val instanceof Array) {
        for (let i = 0; i < val.length; i++) {
          this.convertModelToFormData(val[i], formData, namespace + '[' + i + ']');
        }
      } else if (typeof val === 'object' && !(val instanceof File)) {
        if (val instanceof FileList) {
          for (let i = 0; i < val.length; i++) {
            formData.append(namespace + '[]', val[i]);
          }
        } else {
          for (const propertyName in val) {
            if (val.hasOwnProperty(propertyName)) {
              this.convertModelToFormData(val[propertyName], formData, namespace ? namespace + '[' + propertyName + ']' : propertyName);
            }
          }
        }
      } else if (val instanceof File) {
        formData.append(namespace, val);
      } else {
        formData.append(namespace, val.toString());
      }
    }
    return formData;
  }

}
