import { Contact, User } from '.';

interface FamilyMember {
  relationshipToEvacuee: string;
  details: Contact;
}

export class Registration {
  id: string;
  isRestricted: boolean;
  familyRepresentative: Contact;
  isRegisteringFamilyMembers: number;
  familyMembers: FamilyMember[];
  // TODO: Should we link to the full User record for an interviewer or just capture basic info (name + last name initial)?
  interviewer: User;
  interviewerFirstName: string;
  interviewerLastNameInitial: string;
  startDate: any; // datetime
  endDate?: any; // datetime
  specialNeeds;
  isSupportRequired: boolean;
  supportServicesRequested: {};
}
