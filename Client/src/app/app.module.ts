import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './shared/ui-components/header/header.component';
import { RedisComponent } from './shared/ui-components/redis/redis.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    RedisComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
