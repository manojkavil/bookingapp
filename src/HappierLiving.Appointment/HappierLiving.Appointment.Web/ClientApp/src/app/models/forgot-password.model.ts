export interface IforgotPasswordModel {

  clientId: string;
  email: string;
  connection: string;

}


export class forgotPasswordModel implements IforgotPasswordModel {

  clientId: string;
  email: string;
  connection: string;
}
