import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl="http://localhost:63807/api";

  constructor(private http:HttpClient) { }

  getAge(val:any){
    return this.http.post(this.APIUrl+'/age', val)
  }

  getPremium(val:any){
    return this.http.post(this.APIUrl+'/premium', val)
  }

  getOccupation(val:any){
    return this.http.get(this.APIUrl+'/occupation', val)
  }
}
