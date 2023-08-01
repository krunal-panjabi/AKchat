import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {
  userForm : FormGroup = new FormGroup({});
  submitted = false;
  constructor(private formBuilder : FormBuilder) { }

  ngOnInit(): void {
    this.initializeForm();
  }
  initializeForm(){
    this.userForm = this.formBuilder.group({
      name : ['' ,[Validators.required,Validators.minLength(3),Validators.maxLength(15)]],
      password : ['' ,[Validators.required]],
    })
  }

  submitForm(){
    this.submitted = true ;

    if(this.userForm.valid){
      console.log(this.userForm.value)
    }
  
  }

}
