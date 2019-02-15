import { Action } from '@ngrx/store';

import { UPDATE_REGISTRATION } from '../action-types';
import { Registration } from 'src/app/core/models';

export class UpdateRegistration implements Action {
  readonly type = UPDATE_REGISTRATION;
  constructor(public payload: Registration) {}
}

export type Actions = UpdateRegistration;
