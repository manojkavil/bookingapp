"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var home_component_1 = require("./home/home.component");
var counter_component_1 = require("./counter/counter.component");
var fetch_data_component_1 = require("./fetch-data/fetch-data.component");
var callback_component_1 = require("./callback/callback.component");
exports.ROUTES = [
    { path: '', component: home_component_1.HomeComponent, pathMatch: 'full' },
    { path: 'counter', component: counter_component_1.CounterComponent },
    { path: 'fetch-data', component: fetch_data_component_1.FetchDataComponent },
    { path: 'callback', component: callback_component_1.CallbackComponent },
    { path: 'home', component: home_component_1.HomeComponent }
];
//# sourceMappingURL=app.routes.js.map