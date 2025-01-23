import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatCardModule } from '@angular/material/card';
import { LoginComponent } from './login/login.component';
import { CartComponent } from './cart/cart.component';
import { ProductComponent } from './product/product.component';
import { SaleComponent } from './sale/sale.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    CartComponent,
    ProductComponent,
    SaleComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule, MatSlideToggleModule,
    MatToolbarModule, MatButtonModule, MatIconModule, MatCardModule
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
