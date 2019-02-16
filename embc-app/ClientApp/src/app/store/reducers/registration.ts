import { Registration } from 'src/app/core/models';
import { UPDATE_REGISTRATION } from '../action-types';
import { Actions } from '../actions/registration';

const initialState: Registration = {
  id: undefined,
  familyRepresentative: {
    lastName: 'Doe',
    firstName: 'John',
    initial: 'JD',
    nickname: '',
    gender: 'male',
    age: 35,
  },
  familyInformation: {},
  contactDetails: {},
  primaryResidence: {},
  mailingAddress: {},
  additionalInformation: {},
  requireSupports: false,
  supportList: []
};

export const registrationReducer = (state = initialState, action: Actions) => {
  switch (action.type) {
    case UPDATE_REGISTRATION:
      return { ...state, ...action.payload };
    default:
      return state;
  }
};
