import { BrowserModule, Title } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { HttpClientModule } from '@angular/common/http';
import { CookieService } from 'ngx-cookie-service';
import { AppRoutingModule } from './app-routing.module';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatAutocompleteModule,
  MatButtonModule,
  MatButtonToggleModule,
  MatCardModule,
  MatCheckboxModule,
  MatChipsModule,
  MatDatepickerModule,
  MatDialogModule,
  MatDividerModule,
  MatExpansionModule,
  MatGridListModule,
  MatIconModule,
  MatInputModule,
  MatListModule,
  MatMenuModule,
  MatNativeDateModule,
  MatPaginatorModule,
  MatProgressBarModule,
  MatProgressSpinnerModule,
  MatRadioModule,
  MatRippleModule,
  MatSelectModule,
  MatSidenavModule,
  MatSliderModule,
  MatSlideToggleModule,
  MatSnackBarModule,
  MatSortModule,
  MatStepperModule,
  MatTableModule,
  MatTabsModule,
  MatToolbarModule,
  MatTooltipModule
} from '@angular/material';
import { CdkTableModule } from '@angular/cdk/table';

import { AccountDataService } from './services/account-data.service';
import { ContactDataService } from './services/contact-data.service';
import { ApplicationDataService } from './services/adoxio-application-data.service';
import { AdoxioLegalEntityDataService } from './services/adoxio-legal-entity-data.service';
import { AdoxioLicenseDataService } from './services/adoxio-license-data.service';
import { PaymentDataService } from './services/payment-data.service';
import { AppComponent } from './app.component';
import { BceidConfirmationComponent } from './bceid-confirmation/bceid-confirmation.component';
import { SearchBoxDirective } from './search-box/search-box.directive';
import { GeneralDataService } from './general-data.service';
import { BreadcrumbComponent } from './breadcrumb/breadcrumb.component';
import { DynamicsDataService } from './services/dynamics-data.service';
import { StaticComponent } from './static/static.component';
import { HomeComponent } from './home/home.component';
import { PolicyDocumentDataService } from './services/policy-document-data.service';
import { StatusBadgeComponent } from './status-badge/status-badge.component';
import { SurveyDataService } from './services/survey-data.service';
import { UserDataService } from './services/user-data.service';
import { VersionInfoDataService } from './services/version-info-data.service';
import { NotFoundComponent } from './not-found/not-found.component';
import { BusinessProfileComponent } from './business-information/business-profile/business-profile.component';
import { FileDropModule } from 'ngx-file-drop';
import { FileUploaderComponent } from './shared/file-uploader/file-uploader.component';
import { BusinessProfileSummaryComponent } from './business-profile-summary/business-profile-summary.component';
import { NgBusyModule } from 'ng-busy';
import { BsDatepickerModule, AlertModule } from 'ngx-bootstrap';
import { CanDeactivateGuard } from './services/can-deactivate-guard.service';
import { BCeidAuthGuard } from './services/bceid-auth-guard.service';
import { ServiceCardAuthGuard } from './services/service-card-auth-guard.service';
import { metaReducers, reducers } from './app-state/reducers/reducers';
import { StoreModule } from '@ngrx/store';
import { DashboardComponent } from './dashboard/dashboard.component';
import { TermsAndConditionsComponent } from './lite/terms-and-conditions/terms-and-conditions.component';
import { AliasDataService } from './services/alias-data.service';
import { PreviousAddressDataService } from './services/previous-address-data.service';
import { WorkerDataService } from './services/worker-data.service.';
import { FieldComponent } from './shared/field/field.component';
import { ProfileSummaryComponent } from './business-information/profile-summary/profile-summary.component';
import { VersionInfoDialog } from './version-info/version-info.component';

@NgModule({
  declarations: [
    AppComponent,
    BceidConfirmationComponent,
    BusinessProfileComponent,
    BreadcrumbComponent,
    HomeComponent,
    NotFoundComponent,
    SearchBoxDirective,
    StaticComponent,
    StatusBadgeComponent,
    FileUploaderComponent,
    BusinessProfileSummaryComponent,
    DashboardComponent,
    FieldComponent,
    ProfileSummaryComponent,
    TermsAndConditionsComponent,
    VersionInfoDialog,    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgBusyModule,
    CdkTableModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    MatTooltipModule,
    FileDropModule,
    BsDatepickerModule.forRoot(),
    StoreModule.forRoot(reducers, { metaReducers }),
    AlertModule.forRoot()
  ],
  exports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CdkTableModule,
    MatAutocompleteModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatCardModule,
    MatCheckboxModule,
    MatChipsModule,
    MatDatepickerModule,
    MatDialogModule,
    MatDividerModule,
    MatExpansionModule,
    MatGridListModule,
    MatIconModule,
    MatInputModule,
    MatListModule,
    MatMenuModule,
    MatNativeDateModule,
    MatPaginatorModule,
    MatProgressBarModule,
    MatProgressSpinnerModule,
    MatRadioModule,
    MatRippleModule,
    MatSelectModule,
    MatSidenavModule,
    MatSliderModule,
    MatSlideToggleModule,
    MatSnackBarModule,
    MatSortModule,
    MatStepperModule,
    MatTableModule,
    MatTabsModule,
    MatToolbarModule,
    FileDropModule,
    MatTooltipModule
  ],
  providers: [
    CookieService,
    DynamicsDataService,
    GeneralDataService,
    PolicyDocumentDataService,
    SurveyDataService,
    UserDataService,
    AliasDataService,
    ApplicationDataService,
    AdoxioLegalEntityDataService,
    AdoxioLicenseDataService,
    AccountDataService,
    ContactDataService,
    PaymentDataService,
    PreviousAddressDataService,
    WorkerDataService,
    Title,
    VersionInfoDataService,
    CanDeactivateGuard,
    BCeidAuthGuard,
    ServiceCardAuthGuard,
  ],
  entryComponents: [
    VersionInfoDialog
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
