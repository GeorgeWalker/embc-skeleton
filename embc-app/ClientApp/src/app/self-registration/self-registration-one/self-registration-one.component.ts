import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup, FormControl, FormArray } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';

import { AppState } from 'src/app/store/app-state';
import { UpdateRegistration } from "src/app/store/actions/registration.action";
import { Registration } from 'src/app/core/models';

@Component({
  selector: 'app-self-registration-one',
  templateUrl: './self-registration-one.component.html',
  styleUrls: ['./self-registration-one.component.scss']
})
export class SelfRegistrationOneComponent implements OnInit {
  form: FormGroup;
  private registration: Registration;

  constructor(
    private store: Store<AppState>,
    private fb: FormBuilder,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  // Shortcuts for this.form.get(...)
  get isRegisteringFamilyMembers() { return this.form.get('isRegisteringFamilyMembers'); }
  get familyMembers() { return this.form.get('familyMembers') as FormArray; }
  get primaryResidence() { return this.form.get('primaryResidence') as FormGroup; }
  get mailingAddress() { return this.form.get('mailingAddress') as FormGroup; }
  get showMailingAddress() { return this.form.get('hasMailingAddress').value === true; }

  // Form UI logic; i.e. show additional form fields when a checkbox is checked
  get ui() {
    return {
      showMailingAddress: () => { return this.form.get('hasMailingAddress').value === true; },
      showFamilyMembers: () => { return this.familyMembers.length > 0; },
    };
  }

  ngOnInit() {
    this.getInitialState()
      .subscribe(registration => {
        this.initForm(registration);
        this.handleFormChanges();
      });
  }

  getInitialState() {
    return this.store.select(state => state.registration);
  }

  onSave() {
    const form = this.form.value;
    const state = this.registration;

    const newState: Registration = {
      ...state,
      ...{
        isRestricted: form.isRestricted,
        familyRepresentative: {
          ...state.familyRepresentative,
          ...{
            lastName: form.familyRepresentative.lastName,
            firstName: form.familyRepresentative.firstName,
            initial: form.familyRepresentative.initial,
            nickname: form.familyRepresentative.nickname,
            gender: form.familyRepresentative.gender,
            phoneNumber: form.contactDetails.phoneNumber,
            phoneNumberAlt: form.contactDetails.phoneNumberAlt,
            email: form.contactDetails.email,
            primaryResidence: {
              addressLine1: form.primaryResidence.addressLine1,
              community: form.primaryResidence.community,
              province: form.primaryResidence.province,
              postalCode: form.primaryResidence.postalCode,
              country: form.primaryResidence.country,
            },
            mailingAddress: {
              addressLine1: form.mailingAddress.addressLine1,
              community: form.mailingAddress.community,
              province: form.mailingAddress.province,
              postalCode: form.mailingAddress.postalCode,
              country: form.mailingAddress.country,
            },
          }
        },
        isRegisteringFamilyMembers: form.isRegisteringFamilyMembers,
        familyMembers: form.familyMembers,

      }
    };

    this.store.dispatch(new UpdateRegistration(newState));
  }

  initForm(state: Registration) {
    this.registration = state;

    this.form = this.fb.group({
      isRestricted: this.fb.control(state.isRestricted),

      familyRepresentative: this.fb.group({
        firstName: [state.familyRepresentative.firstName, Validators.required],
        lastName: [state.familyRepresentative.lastName, Validators.required],
        gender: [state.familyRepresentative.gender],
        initials: [state.familyRepresentative.initials],
        nickname: [state.familyRepresentative.nickname],
        dob: [state.familyRepresentative.dob],
      }),

      isRegisteringFamilyMembers: this.fb.control(state.isRegisteringFamilyMembers),
      familyMembers: this.fb.array(state.familyMembers),
      contactDetails: this.fb.group({
        phoneNumber: [''],
        phoneNumberAlt: [''],
        email: [''],
      }),

      primaryResidence: this.fb.group({
        addressLine1: [state.familyRepresentative.profile.primaryResidence.addressLine1],
        community: [state.familyRepresentative.profile.primaryResidence.community],
        postalCode: [state.familyRepresentative.profile.primaryResidence.postalCode],
        province: [state.familyRepresentative.profile.primaryResidence.province],
        country: [state.familyRepresentative.profile.primaryResidence.country],
      }),

      hasMailingAddress: this.fb.control(''),
      mailingAddress: this.fb.group({
        addressLine1: [''],
        community: [''],
        postalCode: [''],
        province: [''],
        country: [''],
      }),
    });
  }

  handleFormChanges() {
    // TODO: Register any value change listeners here...
    // this.form.get('someField').valueChanges.subscribe(...)
    this.isRegisteringFamilyMembers.valueChanges.subscribe((value: number) => {
      if (value === 1) {
        this.addFamilyMember();
      } else {
        this.clearFamilyMembers();
      }
    });
  }

  addFamilyMember() {
    this.familyMembers.push(this.fb.group({
      relationshipToEvacuee: [''],
      sameLastNameAsEvacuee: [true],
      firstName: [''],
      lastName: [''],
      initial: [''],
      gender: [undefined],
      age: [undefined],
    }));
  }

  clearFamilyMembers() {
    this.clear(this.familyMembers);
  }

  // TODO: Refactor into utils method
  private clear(formArray: FormArray) {
    while (formArray.length !== 0) {
      formArray.removeAt(0);
    }
  }

  next() {
    this.onSave();
    this.router.navigate(['../step-2'], { relativeTo: this.route });
  }
}
