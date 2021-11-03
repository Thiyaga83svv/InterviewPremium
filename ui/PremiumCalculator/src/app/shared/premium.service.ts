import { Injectable } from '@angular/core';
import { Premium } from './premium.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Occupation } from './occupation.model';
//import { Employee, State,City } from './employee';
//import { Country } from './employee';

@Injectable({
  providedIn: 'root'
})
export class PremiumService {
   constructor(private http: HttpClient) { }
   formData: Premium = new Premium();
   url = 'http://localhost:63807/api';
   
   getOccupations(): Observable<Occupation[]> {
    return this.http.get<Occupation[]>(this.url + '/occupation');
  } 

  CalculatePremium(premium: Premium): Promise<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.url + '/premium',
                                premium, httpOptions).toPromise()
                                .then(this.extractData)
                                .catch(this.handleErrorPromise);
  }

  private extractData(res: any) {
    let body = res;
    return body;
}
private handleErrorPromise(error: Response | any) {
	console.error(error.message || error);
	return Promise.reject(error.message || error);
} 

}
