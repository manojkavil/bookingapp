interface AuthConfig {
  clientID: string;
  domain: string;
  callbackURL: string;
  apiUrl: string;
}


export const AUTH_CONFIG: AuthConfig = {
  clientID: '4s1TvgQGh98zDhbG5kxcSWR7i7GTFIK6',
  domain: 'manojkavil.auth0.com',
  callbackURL: 'https://localhost:44328/callback',
  apiUrl: 'https://localhost:44394/api'
};
