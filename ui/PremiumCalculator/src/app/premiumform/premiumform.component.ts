import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { OccupationService } from '../service/occupation.service'
import { Occupation } from '../interface/occupation';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-premiumform',
  templateUrl: './premiumform.component.html',
  styleUrls: ['./premiumform.component.css']
})
export class PremiumformComponent implements OnInit {

  occupation$!: Observable<Occupation[]>;
  Occupations!: Occupation[];
  premiumform!:FormGroup;
  errorList!: FormControl;
  modalMessage!:FormControl;
  modalTitle!:FormControl;
  name!:FormControl;
  dob!:FormControl;
  age!:FormControl;
  sumAssured!:FormControl
  occupation!:FormControl

  constructor(private occupationservice: OccupationService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.loadOccupation();
    $(() => {
      $('#datepicker').datepicker({
          changeMonth: true,
          changeYear: true,
          yearRange: '1920:2099',
          onSelect: (dateText) => {
              this.dob.setValue(dateText);
          }
      });
  });
    this.premiumform = this.fb.group([]);
  }
  loadOccupation()
  {
    this.name = new FormControl('', Validators.required)
    this.dob = new FormControl('', Validators.required)
    this.sumAssured = new FormControl('', [
      Validators.required,
      Validators.pattern(
          '^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$'
      )]);
    this.occupation = new FormControl('', Validators.required)
    this.age = new FormControl('', Validators.required)

    this.occupation$ = this.occupationservice.getOccupation();
        this.occupation$.subscribe((occupationlist) => {
            this.Occupations = occupationlist;
            console.log(this.Occupations);
        });

  }

}
