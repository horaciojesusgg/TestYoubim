import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { ProfileComponent } from './profile/profile.component';
import { FormsModule } from '@angular/forms';
import {AuthService} from './shared/auth.service';
import { RouterModule } from '@angular/router';
import { Router } from '@angular/router';
import { HttpClientModule, HTTP_INTERCEPTORS  } from '@angular/common/http';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { NodesComponent } from './nodes/nodes.component';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { RegisterComponent } from './register/register.component';
import { RegisterSuccessComponent } from './register-success/register-success.component';
import { HomeComponent } from './home/home.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ProfileComponent,
    NodesComponent,
    RegisterComponent,
    RegisterSuccessComponent,
    HomeComponent
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },BrowserModule, AuthService],
  imports: [
    BrowserModule,
    RouterModule,
    FormsModule,
    HttpClientModule,
    NgbModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'login', component: LoginComponent },
      { path: 'profile', component: ProfileComponent },
      {path: 'nodes', component: NodesComponent},
      {path: 'register', component:RegisterComponent},
      {path: 'register-success', component: RegisterSuccessComponent},
      {path: 'home', component: HomeComponent}
  ]),
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
