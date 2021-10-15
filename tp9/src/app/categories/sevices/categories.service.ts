import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Category } from '../models/category';
import { CategoriesModule } from '../categories.module';
import { environment } from 'src/environments/environment';
import { Router } from '@angular/router';
import { CategoriesComponent } from '../categories.component';

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

  public deleteCategory(id : number){    
    let url: string = environment.baseUrl +'/'+ id;
    return this.http.delete(url);       
        
  }
  public getCategory(id : number) : Observable<Category>{
    let url: string = environment.baseUrl +'/'+ id;
    return this.http.get<Category>(url);
  }

  public updateCategory(category: Category){
    let url: string = environment.baseUrl +'/'+ category.Id;
    return this.http.put(url, category);
  }
}


