import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { CategoriesComponent } from '../categories/categories.component';
import { CategoriesModule } from '../categories/categories.module';
import { Category } from '../categories/models/category';
import { CategoriesService } from '../categories/sevices/categories.service';



@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  form : FormGroup;
  id : number;
  
  constructor(
    private readonly fb : FormBuilder,
    private categoriesService : CategoriesService,
    private router : Router,
    private ruta: ActivatedRoute ) { }



  ngOnInit(): void {
    this.id = Number(this.ruta.snapshot.paramMap.get("id"));
    if (this.id){
      this.categoriesService.getCategory(this.id).subscribe(category => {
        this.form = this.fb.group({
          CategoryName: [category.CategoryName],
          Description: [category.Description]
        });
      });   
    }
    else {
      this.form = this.fb.group({
        CategoryName: [''],
        Description: ['']
      });
    }    
  }
  onSubmit() : void{

    if (this.id){
      this.updateCategory();
    }
    else{
      this.saveCategory();
    }

  }

  saveCategory(){

    var category = new Category();
    category.CategoryName = this.form.get('CategoryName').value;
    category.Description = this.form.get('Description').value;

    this.categoriesService.insertCategory(category).subscribe(res => {
      this.form.reset();        
      this.router.navigate(["/categories"], {
        state: {
          mensaje: "Se agregó correctamente"
        }
      });     
    });    
    
  }

  updateCategory(){
    var category = new Category();
    category.Id = this.id;
    category.CategoryName = this.form.get('CategoryName').value;
    category.Description = this.form.get('Description').value;

    this.categoriesService.updateCategory(category).subscribe(res => {
      this.form.reset();  
      
      this.router.navigate(["/categories"], {
        state: {
          mensaje: "Se actualizó correctamente"
        }
      });     
    });  

  }

}
