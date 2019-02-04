import { Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
import { AdoxioLegalEntity } from '../models/adoxio-legalentities.model';
import { Observable } from 'rxjs';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { debounce, catchError } from 'rxjs/operators';

@Injectable()
export class AdoxioLegalEntityDataService {

  headers: HttpHeaders = new HttpHeaders({
    'Content-Type': 'application/json'
  });

  constructor(private http: HttpClient) { }

  /**
   * Get legal entities from Dynamics filtered by position
   * @param positionType
   */
  getLegalEntitiesbyPosition(parentLegalEntityId, positionType: string) {
    const apiPath = `api/adoxiolegalentity/position/${parentLegalEntityId}/${positionType}`;
    return this.http.get<AdoxioLegalEntity[]>(apiPath, { headers: this.headers });
  }

  getBusinessProfileSummary() {
    const apiPath = 'api/adoxiolegalentity/business-profile-summary/';
    return this.http.get<AdoxioLegalEntity[]>(apiPath, { headers: this.headers })
      .pipe(catchError(this.handleError));

  }

  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createLegalEntity(data: any) {
    return this.http.post<AdoxioLegalEntity>('api/adoxiolegalentity/', data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * update a  legal entity in Dynamics
   * @param data - legal entity data
   */
  updateLegalEntity(data: any, id: string) {
    return this.http.put<AdoxioLegalEntity>(`api/adoxiolegalentity/${id}`, data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * delete a  legal entity in Dynamics
   * @param data - legal entity data
   */
  deleteLegalEntity(id: string) {
    return this.http.post<AdoxioLegalEntity>(`api/adoxiolegalentity/${id}/delete`, {}, { headers: this.headers });
  }


  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createChildLegalEntity(data: any) {
    return this.http.post<AdoxioLegalEntity>('api/adoxiolegalentity/child-legal-entity', data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * Send a consent request to the emails received as parameter
   * @param data - array of emails
   */
  sendConsentRequestEmail(data: string[]) {
    const legalEntityId: string = data[0];
    const apiPath = 'api/adoxiolegalentity/' + legalEntityId + '/sendconsentrequests';
    return this.http.post(apiPath, data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * Handle error
   * @param error
   */
  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error.json() || '';
      const err = body.error || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
    return Promise.reject(errMsg);
  }
}
