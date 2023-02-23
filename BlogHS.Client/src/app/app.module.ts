import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EntrycardlistComponent } from './components/entrycardlist/entrycardlist.component';
import { EntrycardComponent } from './components/entrycard/entrycard.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { NewentryComponent } from './components/newentry/newentry.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ApiService } from './services/api.service';
import { ImageService } from './services/image.service';
import { EntrydetailsComponent } from './components/entrydetails/entrydetails.component';

@NgModule({
  declarations: [
    AppComponent,
    EntrycardlistComponent,
    EntrycardComponent,
    HeaderComponent,
    FooterComponent,
    NewentryComponent,
    EntrydetailsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [ ApiService, ImageService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
