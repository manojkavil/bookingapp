import { Injectable } from '@angular/core';
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { ApiService } from '../shared/services/api.service';
import { forgotPasswordModel } from '../models/forgot-password.model';

@Injectable()
export class ForgotPasswordService {
   

  constructor(private _apiService: ApiService) { }

  submitEmail(forgotPasswordModel: forgotPasswordModel) {

    return this._apiService.post("https://localhost:44394/api/ResetPassword", forgotPasswordModel)
  }
  
}
