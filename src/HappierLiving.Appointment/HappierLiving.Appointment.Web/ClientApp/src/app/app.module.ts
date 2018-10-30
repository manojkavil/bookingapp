import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AuthService } from './auth/auth.service';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { CallbackComponent } from './callback/callback.component';
import { ROUTES } from './app.routes';
import { ForgotPasswordComponent } from './forgot-password/forgot-password.component';
import { ApiService } from './shared/services/api.service';
import { ForgotPasswordService } from './forgot-password/forgot-password.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    CallbackComponent,
    ForgotPasswordComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
  
    RouterModule.forRoot(ROUTES)
  ],
  providers: [AuthService, ApiService, ForgotPasswordService],
  bootstrap: [AppComponent]
})
export class AppModule { }
