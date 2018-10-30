import { Component, OnInit } from '@angular/core';
import { forgotPasswordModel } from '../models/forgot-password.model';
import { ForgotPasswordService } from './forgot-password.service';

@Component({
  selector: 'app-forgot-password',
  templateUrl: './forgot-password.component.html',
  styleUrls: ['./forgot-password.component.css']
})
export class ForgotPasswordComponent implements OnInit {

  constructor(private _forgotPasswordService: ForgotPasswordService) { }

  ngOnInit() {

  }
  forgotPasswrdModel: forgotPasswordModel = new forgotPasswordModel();
  onSubmit() {
    this._forgotPasswordService.submitEmail(this.forgotPasswrdModel).subscribe(
      x => {
        alert(x.result);
      }
    );

  }
}
