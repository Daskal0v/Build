import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {MatButtonModule} from '@angular/material/button';
import {MatMenuModule} from '@angular/material/menu';
import {MatIconModule} from '@angular/material/icon'

import { FooterComponent } from './Components/footer/footer.component';
import { NavigationComponent } from './Components/navigation/navigation.component';
import { HomePageComponent } from './Components/home-page/home-page.component';
import { LogoComponent } from './Components/Shared/logo/logo.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MenuComponent } from './Components/menu/menu.component';
import { PageNotFoundComponent } from './Components/page-not-found/page-not-found.component';
import { CardComponent } from './Components/Shared/card/card.component';
import { RatingComponent } from './Components/Shared/rating/rating.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    NavigationComponent,
    HomePageComponent,
    LogoComponent,
    MenuComponent,
    PageNotFoundComponent,
    CardComponent,
    RatingComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatMenuModule,
    MatIconModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
