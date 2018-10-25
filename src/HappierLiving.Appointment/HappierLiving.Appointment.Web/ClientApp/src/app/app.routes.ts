import { HomeComponent } from "./home/home.component";
import { CounterComponent } from "./counter/counter.component";
import { FetchDataComponent } from "./fetch-data/fetch-data.component";
import { CallbackComponent } from "./callback/callback.component";
import { Routes } from "@angular/router";

export const ROUTES: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'counter', component: CounterComponent },
  { path: 'fetch-data', component: FetchDataComponent },
  { path: 'callback', component: CallbackComponent },
  { path: 'home', component: HomeComponent }
];
