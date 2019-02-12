import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WarningBannerComponent } from './components/warning-banner/warning-banner.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';

@NgModule({
  declarations: [
    WarningBannerComponent,
    HeaderComponent,
    FooterComponent,
  ],
  imports: [
    CommonModule
  ],
  exports: [
    WarningBannerComponent,
    HeaderComponent,
    FooterComponent,
  ]
})
export class SharedModule { }
