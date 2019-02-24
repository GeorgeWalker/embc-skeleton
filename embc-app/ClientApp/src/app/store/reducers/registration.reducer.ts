import { Registration, Address } from 'src/app/core/models';
import { RegistrationAction, UPDATE_REGISTRATION } from '../actions/registration.action';

const initialAddress: Address = {
  addressLine1: undefined,
  addressLine2: undefined,
  addressLine3: undefined,
  community: undefined,
  province: undefined,
  postalCode: undefined,
  country: undefined,
};

const initialState: Registration = {
  id: undefined,
  isRestricted: undefined,
  familyRepresentative: {
    id: undefined,
    lastName: undefined,
    firstName: undefined,
    initials: undefined,
    nickname: undefined,
    gender: undefined,
    dob: undefined,
    profile: {
      phoneNumber: undefined,
      phoneNumberAlt: undefined,
      email: undefined,
      primaryResidence: { ...initialAddress },
      mailingAddress: { ...initialAddress },
    },
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

export function registrationReducer(state = initialState, action: RegistrationAction) {
  switch (action.type) {
    case UPDATE_REGISTRATION:
      return { ...state, ...action.payload };
    default:
      return state;
  }
}
