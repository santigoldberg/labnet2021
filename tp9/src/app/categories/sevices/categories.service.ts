import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from '../models/category';
import { CategoriesModule } from '../categories.module';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  
  constructor(private http : HttpClient) { }

  public listCategories() : Observable<Category[]> {
    return this.http.get<Category[]>(environment.baseUrl);  
  }
  public insertCategory(categoryRequest : Category) : Observable<any>{
    return this.http.post(environment.baseUrl, categoryRequest);
  }
}


