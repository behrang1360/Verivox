import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { MatSliderModule } from "@angular/material/slider";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { TariffComparisonComponent } from "./tariff-comparison/tariff-comparison.component";
import { HttpClientModule } from "@angular/common/http";
import { MatTableModule } from "@angular/material/table";
import { MatCardModule } from "@angular/material/card";
import { MatInputModule } from "@angular/material/input"
import {MatButtonModule} from "@angular/material/button"
import { FormsModule } from '@angular/forms';
import { ErrorInterceptorProvider } from './services/error.interceptor';

@NgModule({
  declarations: [AppComponent, TariffComparisonComponent],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    MatSliderModule,
    MatTableModule,
    MatCardModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatInputModule,
    MatButtonModule
  ],
  providers: [ErrorInterceptorProvider],
  bootstrap: [AppComponent]
})
export class AppModule {}
