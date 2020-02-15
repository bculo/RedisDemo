import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './shared/ui-components/header/header.component';
import { RedisComponent } from './shared/ui-components/redis/redis.component';
import { AddComponent } from './components/add/add.component';
import { GetComponent } from './components/get/get.component';
import { RemoveComponent } from './components/remove/remove.component';
import { SimpleButtonComponent } from './shared/ui-components/simple-button/simple-button.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RedisComponent,
    AddComponent,
    GetComponent,
    RemoveComponent,
    SimpleButtonComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
