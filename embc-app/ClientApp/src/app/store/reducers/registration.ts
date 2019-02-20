import { Registration } from 'src/app/core/models';
import { UPDATE_REGISTRATION } from '../action-types';
import { Actions } from '../actions/registration';

const initialState: Registration = {
  id: undefined,
  isRestricted: undefined,
  familyRepresentative: {
    id: undefined,
    lastName: 'Doe',
    firstName: 'John',
    initial: 'JD',
    nickname: '',
    gender: 'male',
    age: 35,
    phoneNumber: '',
    phoneNumberAlt: '',
    email: '',
    primaryResidence: {
      addressLine1: undefined,
      addressLine2: undefined,
      addressLine3: undefined,
      community: undefined,
      province: 'British Columbia',
      postalCode: undefined,
      country: 'Canada',
    },
    mailingAddress: undefined,
  },
  isRegisteringFamilyMembers: undefined,
  familyMembers: [],
  interviewer: undefined,
  interviewerFirstName: undefined,
  interviewerLastNameInitial: undefined,
  startDate: undefined,
  endDate: undefined,
  specialNeeds: undefined,
  isSupportRequired: false,
  supportServicesRequested: {}
};

export const registrationReducer = (state = initialState, action: Actions) => {
  switch (action.type) {
    case UPDATE_REGISTRATION:
      return { ...state, ...action.payload };
    default:
      return state;
  }
};
