import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';

import { HttpClientModule } from '@angular/common/http';
import { ItemDetailsComponent } from './item-details/item-details.component';
@NgModule({
  declarations: [
    AppComponent,
    ValueComponent,
    ItemDetailsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
