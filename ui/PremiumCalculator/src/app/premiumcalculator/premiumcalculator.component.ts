import { Component, OnInit } from '@angular/core';
import { PremiumService } from '../shared/premium.service';
import { Premium } from '../shared/premium.model';
import { FormBuilder, FormControl, FormGroup, Validators, FormArray } from '@angular/forms';
import { Observable } from 'rxjs';
import { Occupation } from '../shared/occupation.model';

interface Occupations {
  OccuptionName: string;
  Rating: string;
}

@Component({
  selector: 'app-premiumcalculator',
  templateUrl: './premiumcalculator.component.html',
  styleUrls: ['./premiumcalculator.component.css']
})
export class PremiumcalculatorComponent implements OnInit {
  
  premiumForm!:FormGroup;
  allOccupation!: Observable<Occupation[]>;
  monthlyPremiumAmount!: Promise<number>;
  OccupationRating = null
  CustomerName: any;
   constructor(private formbuilder:FormBuilder, public premiumservice:PremiumService) { 
    this.premiumForm = new FormGroup({
      CustomerName: new FormControl({value: this.CustomerName})
   });
   }

   //public birthdate!: Date;
   //public age!: number;
   //public CalculateAge(): void {
   //  if (this.birthdate) {
   //    var timeDiff = Math.abs(Date.now() - new Date(this.birthdate).getTime());
   //    this.age = Math.floor(timeDiff / (1000 * 3600 * 24) / 365.25);
    //     }
    //   }

  ngOnInit(): void {
    this.FillOccupationDDL();
    this.premiumForm = this.formbuilder.group({
      CustomerName: ["", [Validators.required]],
      Age: ["", [Validators.required]],
      DateOfBirth: ["", [Validators.required]],
      Occupation: ["", [Validators.required]],
      SumAssured: ['', Validators.compose([Validators.required, Validators.pattern('[0-9]*$')])],
      
    })
  }

  FillOccupationDDL() {
    this.allOccupation = this.premiumservice.getOccupations();
  }

  
  onFormSubmit() {
    const premium = this.premiumForm.value;
    this.PremiumCalculation(premium);
    this.premiumForm.reset();
  }

  PremiumCalculation(premium: Premium){
    console.log(premium);

    this.premiumservice.CalculatePremium(premium)
    .then(data => {
      this.monthlyPremiumAmount = data;
    })
  }
}

