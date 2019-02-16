import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
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

  fetch(): any {
    return this.store.select(state => state.registration);
  }

  updateRegistration(registration: Registration) {
    // this.store.dispatch( { type: UPDATE_REGISTRATION, payload: { ...state } });
    this.store.dispatch(new UpdateRegistration(registration));
  }

  initForm(registration: Registration) {
    const {
      familyRepresentative,
      familyInformation,
      contactDetails,
      mailingAddress,
    } = registration;

    this.form = this.fb.group({
      familyRepresentative: this.fb.group({
        firstName: [familyRepresentative.firstName, Validators.required],
        lastName: [familyRepresentative.lastName, Validators.required],
        gender: [familyRepresentative.gender],
        initial: [familyRepresentative.initial],
        nickname: [familyRepresentative.nickname],
        age: [familyRepresentative.age],
      }),
      familyInformation: this.fb.group({}),
      contactDetails: this.fb.group({}),
      primaryResidence: this.fb.group({}),
      mailingAddress: this.fb.group({}),
    });
  }

  handleFormChanges() {
    // TODO: Register any value change listeners here...
    // this.form.get('someField').valueChanges.subscribe(...)
  }

  next() {
    this.updateRegistration({ ...this.registration, ...this.form.value });
    this.router.navigate(['../step-2'], { relativeTo: this.route });
  }
}
