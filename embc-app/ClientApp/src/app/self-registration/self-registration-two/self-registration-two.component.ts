import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { AppState } from 'src/app/store/app-state';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { Registration } from 'src/app/core/models';

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

  ngOnInit() {
    this.fetch()
      .subscribe(state => {
        this.registration = state;
        this.initForm(state);
        this.handleFormChanges();
      });
  }

  initForm(state: Registration): any {
    // throw new Error('Method not implemented.');
  }

  handleFormChanges(): any {
    // throw new Error('Method not implemented.');
  }

  fetch() {
    return this.store.select(state => state.registration);
  }

  next() {
    this.router.navigate(['../step-3'], { relativeTo: this.route });
  }
}
