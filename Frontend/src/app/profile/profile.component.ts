import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  username: string;
  name: string;
  constructor() { }

  ngOnInit() {
    this.username = localStorage.getItem('user_username');
    this.name = localStorage.getItem('user_name');
  }
}
