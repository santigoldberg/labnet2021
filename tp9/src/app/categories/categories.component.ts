import { Component, OnInit } from '@angular/core';
import { NavigationStart, Router } from '@angular/router';
import { Category } from './models/category';
import { CategoriesService } from './sevices/categories.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  categories : Category[];

  mensaje : string;

  constructor(private service : CategoriesService , private router: Router) { }

  ngOnInit(): void {
    this.listCategories();     
    this.mensaje = history.state.mensaje; 
    console.log(this.mensaje);    

  }

  public listCategories () {
    this.service.listCategories().subscribe(listCategories=>this.categories = listCategories);    
  }

  public delCategory (id : number){
    if(confirm('Estás seguro de borrar la categoría')){
      this.service.deleteCategory(id).subscribe(res => {        
        this.listCategories();
        this.mensaje = "Se borró correctamente"     
      });
    }
  }

}
