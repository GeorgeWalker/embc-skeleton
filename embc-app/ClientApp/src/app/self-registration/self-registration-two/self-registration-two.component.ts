import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';
import { first } from "rxjs/operators";

import { AppState } from 'src/app/store/app-state';
import { Registration } from 'src/app/core/models';
import { UpdateRegistration } from 'src/app/store/actions/registration.action';

@Component({
  selector: 'app-self-registration-two',
  templateUrl: './self-registration-two.component.html',
  styleUrls: ['./self-registration-two.component.scss']
})
export class SelfRegistrationTwoComponent implements OnInit {
  form: FormGroup;
  registration: Registration;

  constructor(
    private store: Store<AppState>,
    private fb: FormBuilder,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  // Shortcuts for this.form.get(...)
  // get mailingAddress() { return this.form.get('mailingAddress') as FormGroup; }

  // TODO: Form UI logic; i.e. show additional form fields when a checkbox is checked
  get ui() {
    return {};
  }

  ngOnInit() {
    const sub = this.getInitialState()
      .subscribe(registration => {
        this.initForm(registration);
        this.handleFormChanges();
      });
    sub.unsubscribe();
  }

  getInitialState() {
    return this.store.select(state => state.registration);
  }

  initForm(state: Registration) {
    this.registration = state;

    this.form = this.fb.group({
      dietaryRequirements: [],

    });
  }

  handleFormChanges() {
    // TODO: Register any value change listeners here...
    // this.form.get('someField').valueChanges.subscribe(...)
  }

  onSave() {
    const form = this.form.value;
    const state = this.registration;

    const newState: Registration = {
      ...state,
      ...{}
    };

    this.store.dispatch(new UpdateRegistration(newState));
  }

  next() {
    this.onSave();
    this.router.navigate(['../step-3'], { relativeTo: this.route });
  }
}
