import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from 'src/app/services/login.service';
import UserRequestLogin from 'src/models/UserRequestLogin';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup = new FormGroup({});
  submitted = false;

  constructor(private formBuilder: FormBuilder, private loginService: LoginService) { }

  ngOnInit() {
    this.loginForm = this.formBuilder.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]]
    });
  }

  get f() { return this.loginForm.controls; }

  async onSubmit() {
    this.submitted = true;

    if (this.loginForm.invalid) {
      return;
    }

    const dto: UserRequestLogin ={
      username: this.f.username.value,
      password: this.f.password.value,
      email: this.f.email.value
    };
    try {
      const response = await this.loginService.loginUser(dto);
      alert(`User has been logged in successfully: ${JSON.stringify(response)}`);
    } catch (error) {
      console.error(error);
      alert("Error logging in the user. Please try again");
    }
  }
}