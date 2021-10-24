import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { shareReplay, map } from 'rxjs/operators';
import { Occupation } from '../interface/occupation';

@Injectable({
    providedIn: 'root'
})
export class OccupationService {
    private occupationListUrl: string = 'api/occupation';

    private occupation$!: Observable<Occupation[]>;

    constructor(private http: HttpClient) {}

    getOccupation() {
        if (!this.occupation$) {
            this.occupation$ = this.http.get<any>(this.occupationListUrl).pipe(
                shareReplay(),
                map((result) => {
                    return result;
                })
            );
        }

        // if occupation cache exists return it
        return this.occupation$;
    }
}
