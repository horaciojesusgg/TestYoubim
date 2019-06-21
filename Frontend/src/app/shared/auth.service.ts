import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Router } from '@angular/router';
 
@Injectable({
  providedIn: 'root'
})
 
export class AuthService {
 
  uri = 'http://localhost:5000/api/auth';
  token;
 
  constructor(private http: HttpClient,private router: Router) { }
  login(username: string, password: string) {
    this.http.post(this.uri + '/authenticate', {UserName: username,PlainPassword: password})
    .subscribe((resp: any) => {
     
       this.router.navigate(['profile']);
       localStorage.setItem('auth_token', resp.token);
       localStorage.setItem('user_username', resp.username);
       localStorage.setItem('user_name', resp.name);
       localStorage.setItem('user_id', resp.id);
      });
    } 
}