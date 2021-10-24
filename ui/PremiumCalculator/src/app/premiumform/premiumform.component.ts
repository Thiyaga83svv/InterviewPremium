import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { OccupationService } from '../service/occupation.service'
import { Occupation } from '../interface/occupation';

@Component({
  selector: 'app-premiumform',
  templateUrl: './premiumform.component.html',
  styleUrls: ['./premiumform.component.css']
})
export class PremiumformComponent implements OnInit {

  occupation$!: Observable<Occupation[]>;
  Occupation!: Occupation[];

  constructor(private occupationservice: OccupationService) { }

  ngOnInit(): void {
    this.loadOccupation();
  }
  loadOccupation()
  {
    this.occupation$ = this.occupationservice.getOccupation();
        this.occupation$.subscribe((occupationlist) => {
            this.Occupation = occupationlist;
        });

  }

}
