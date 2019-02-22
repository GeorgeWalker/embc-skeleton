import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup, FormControl, FormArray } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';

import { AppState } from 'src/app/store/app-state';
import { UPDATE_REGISTRATION } from './../../store/action-types';
import { UpdateRegistration } from "src/app/store/actions/registration";
import { Registration } from 'src/app/core/models';

@Component({
  selector: 'app-self-registration-one',
  templateUrl: './self-registration-one.component.html',
  styleUrls: ['./self-registration-one.component.scss']
})
export class SelfRegistrationOneComponent implements OnInit {
  form: FormGroup;
  registration: Registration;

  constructor(
    private store: Store<AppState>,
    private fb: FormBuilder,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.fetch()
      .subscribe(state => {
        this.registration = state;
        this.initForm(state);
        this.handleFormChanges();
      });
  }

  fetch() {
    return this.store.select(state => state.registration);
  }

  updateRegistration(registration: Registration) {
    // this.store.dispatch( { type: UPDATE_REGISTRATION, payload: { ...state } });
    this.store.dispatch(new UpdateRegistration(registration));
  }

  initForm(registration: Registration) {
    const {
      familyRepresentative,
      familyMembers,
    } = registration;

    this.form = this.fb.group({
      isRestricted: this.fb.control(''),
      familyRepresentative: this.fb.group({
        firstName: [familyRepresentative.firstName, Validators.required],
        lastName: [familyRepresentative.lastName, Validators.required],
        gender: [familyRepresentative.gender],
        initial: [familyRepresentative.initial],
        nickname: [familyRepresentative.nickname],
        age: [familyRepresentative.age],
      }),
      isRegisteringFamilyMembers: this.fb.control(undefined),
      familyMembers: this.fb.array([]),
      contactDetails: this.fb.group({
        phoneNumber: [''],
        phoneNumberAlt: [''],
        email: [''],
      }),
      primaryResidence: this.fb.group({
        addressLine1: [''],
        community: [''],
        postalCode: [''],
        province: [familyRepresentative.primaryResidence.province],
        country: [familyRepresentative.primaryResidence.country],
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

  get isRegisteringFamilyMembers() {
    return this.form.get('isRegisteringFamilyMembers');
  }

  get familyMembers() {
    return this.form.get('familyMembers') as FormArray;
  }

  get showFamilyMembers() {
    // return this.form.get('isRegisteringFamilyMembers').value === 1;
    return this.familyMembers.length > 0;
  }

  addFamilyMember() {
    this.familyMembers.push(this.fb.group({
      relationshipToEvacuee: [''],
      sameLastNameAsEvacuee: [true],
      firstName: [''],
      lastName: [''],
      initial: [''],
      gender: [''],
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

  get primaryResidence() {
    return this.form.get('primaryResidence') as FormGroup;
  }

  get mailingAddress() {
    return this.form.get('mailingAddress') as FormGroup;
  }

  // show/hide toggles
  get showMailingAddress() {
    return this.form.get('hasMailingAddress').value === true;
  }

  next() {
    this.updateRegistration({ ...this.registration, ...this.form.value });
    this.router.navigate(['../step-2'], { relativeTo: this.route });
  }
}
