import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Frontend';
  

  logout() {
    localStorage.removeItem('auth_token');
    localStorage.removeItem('user_username');
    localStorage.removeItem('user_name');
    localStorage.removeItem('user_id');
  }
 
  public get logIn(): boolean {
    return (localStorage.getItem('auth_token') !== null);
  }
}
