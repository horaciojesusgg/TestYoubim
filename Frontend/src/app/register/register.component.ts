import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  newUser = {
    name: '',
    username: '',
    email: '',
    PlainPassword: ''
  };
  uri = 'http://localhost:5000/api/auth';
  errorMessage: string;

  constructor(private http: HttpClient, private router: Router) { }

  register() {
    this.http.post(this.uri + '/register', this.newUser).subscribe( result => {
 
      this.router.navigateByUrl("register-success");
     
    }, error => {
      this.errorMessage = "Error while registering. Reason: " + error.error.message;
    });
  }

  ngOnInit() {
  }

}
