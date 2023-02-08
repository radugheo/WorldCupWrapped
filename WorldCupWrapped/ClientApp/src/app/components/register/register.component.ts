import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit{
  // registerForm: FormGroup;
  // file: File;
  constructor() { 
    
  }
  ngOnInit(): void {
    
  }
  onSubmit() {
    // if (this.registerForm.valid) {
    //   const formData = new FormData();
    //   formData.append('username', this.registerForm.get('username').value);
    //   formData.append('password', this.registerForm.get('password').value);
    //   formData.append('email', this.registerForm.get('email').value);
    //   formData.append('firstName', this.registerForm.get('firstName').value);
    //   formData.append('lastName', this.registerForm.get('lastName').value);
    //   formData.append('picture', this.file);

    //   // this.http.post('/api/register', formData).subscribe((response) => {
    //   //   console.log(response);
    //   //   // handle the response
    //   // }, (error) => {
    //   //   console.log(error);
    //   //   // handle the error
    //   // });
    // }
  }

  // uploadFile(event) {
  //   this.file = event.target.files[0];
  // }
}
