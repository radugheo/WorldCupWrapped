import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { RegisterService } from 'src/app/services/register.service';
import UserRequestRegister from 'src/models/UserRequestRegister';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm: FormGroup = new FormGroup({});
  submitted = false;
  picture: File | null = null;

  constructor(private formBuilder: FormBuilder, private registerService: RegisterService) { }

  ngOnInit() {
    this.registerForm = this.formBuilder.group({
      username: ['', [Validators.required]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      email: ['', [Validators.required, Validators.email]],
      firstName: ['', [Validators.required]],
      lastName: ['', [Validators.required]],
    });
  }

  get f() { return this.registerForm.controls; }

  onFileChange(event: any) {
    this.picture = event.target.files[0];
  }

  async onSubmit() {
    this.submitted = true;

    if (this.registerForm.invalid) {
      return;
    }

    if (!this.picture) {
      return alert("Please select a profile picture");
    }

    const reader = new FileReader();
    reader.readAsDataURL(this.picture);
    reader.onload = async () => {
      let pictureBase64 = reader.result as string;
      pictureBase64.slice(pictureBase64.toString().indexOf(',') + 1);
      const dto: UserRequestRegister ={
        username: this.f.username.value,
        password: this.f.password.value,
        email: this.f.email.value,
        firstName: this.f.firstName.value,
        lastName: this.f.lastName.value,
        picture: pictureBase64
      };
      const response = await this.registerService.registerUser(dto);
      if (response.status === 200)
        alert(`User has been registered successfully!`);
      else if (response.status === 400)
        alert(`User already exists!`);
      else
        alert(`Error registering user: ${JSON.stringify(response)}`);
    };
    reader.onerror = (error) => {
      console.error(error);
      alert("Error reading the picture. Please try again");
    };
  }
}