import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { MaterialModule } from './material.module';
import { WarningBannerComponent } from './components/warning-banner/warning-banner.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { SideBoxComponent, SideBoxActions } from './components/side-box/side-box.component';

@NgModule({
  declarations: [
    WarningBannerComponent,
    HeaderComponent,
    FooterComponent,
    SideBoxComponent,
    SideBoxActions
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
  ],
  exports: [
    // modules
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,

    // components, pipes, etc
    WarningBannerComponent,
    HeaderComponent,
    FooterComponent,
    SideBoxComponent,
    SideBoxActions,
  ]
})
export class SharedModule { }
