import { Component, OnInit } from '@angular/core';
import { Category } from './models/category';
import { CategoriesService } from './sevices/categories.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  categories : Category[];

  constructor(private service : CategoriesService) { }

  ngOnInit(): void {
    this.service.listCategories().subscribe(listCategories=>this.categories = listCategories);
  }

}
