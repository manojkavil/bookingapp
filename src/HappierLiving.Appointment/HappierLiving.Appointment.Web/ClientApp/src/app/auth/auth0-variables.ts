interface AuthConfig {
  clientID: string;
  domain: string;
  callbackURL: string;
  apiUrl: string;
}


export const AUTH_CONFIG: AuthConfig = {
  clientID: '',
  domain: '',
  callbackURL: 'https://localhost:44328/callback',
  apiUrl: 'https://localhost:44394/api'
};
