import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { AuthService } from '../shared/auth.service';
 
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  userName = '';
  plainPassword = '';
  
  constructor(private authService: AuthService) {};

  Login() {
  this.authService.login(this.userName, this.plainPassword)
  }
 
  ngOnInit() { }
}