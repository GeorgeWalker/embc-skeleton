import { Injectable } from '@angular/core';

import { HttpHeaders, HttpClient } from '@angular/common/http';

import { DynamicsContact } from '../models/dynamics-contact.model';
import { Observable } from 'rxjs';

@Injectable()
export class ContactDataService {

  apiPath = 'api/contact/';
  headers: HttpHeaders = new HttpHeaders({
    'Content-Type': 'application/json'
  });

  constructor(private http: HttpClient) { }

  public getContact(contactId: string) {
    return this.http.get<DynamicsContact>(this.apiPath + contactId, { headers: this.headers });
  }
  public getContactsByAccountId(accountId: string): Observable<DynamicsContact[]> {
    return this.http.get<DynamicsContact[]>(`${this.apiPath}account/${accountId}`, { headers: this.headers });
  }

  public createContact(contact: DynamicsContact) {
    return this.http.post<DynamicsContact>(this.apiPath, contact, { headers: this.headers });
  }

  public createWorkerContact(contact: DynamicsContact) {
    return this.http.post<DynamicsContact>(this.apiPath + 'worker', contact, { headers: this.headers });
  }
  public updateContact(contact: DynamicsContact) {
    return this.http.put<DynamicsContact>(this.apiPath + contact.id, contact, { headers: this.headers });
  }

}
