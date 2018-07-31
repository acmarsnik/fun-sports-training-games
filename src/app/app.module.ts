import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { TargetAddComponent } from './baseball/pitching/target-add/target-add.component';
import { TargetsViewComponent } from './baseball/pitching/targets-view/targets-view.component';

@NgModule({
  declarations: [
    AppComponent,
    TargetAddComponent,
    TargetsViewComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
