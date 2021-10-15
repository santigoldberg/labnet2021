import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  form : FormGroup;
  
  constructor(private readonly fb : FormBuilder) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      CategoryName: [''],
      Description: ['']
    });
  }
  onSubmit() : void{

  }

}
