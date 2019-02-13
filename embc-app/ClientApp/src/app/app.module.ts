import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoreModule } from './core/core.module';
import { SharedModule } from './shared/shared.module';
import { HomeComponent } from './home/home.component';
import { SelfRegistrationComponent } from './self-registration/self-registration.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SelfRegistrationComponent,
  ],
  imports: [
    // angular
    BrowserModule,
    BrowserAnimationsModule,

    // 3rd party

    // core & shared
    CoreModule,
    SharedModule,

    // app
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
