interface Address {
  addressLine1: string;
  addressLine2: string;
  addressLine3: string;
  community: string;
  province: string;
  postalCode: string;
  country: string;
}

export class Contact {
  id: string;
  firstName: string;
  lastName: string;
  gender: string;
  initial: string;
  nickname: string;
  age: number;
  phoneNumber: string;
  phoneNumberAlt: string;
  email: string;
  primaryResidence: Address;
  mailingAddress?: Address;
}
