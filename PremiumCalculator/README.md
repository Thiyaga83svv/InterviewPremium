# InterviewPremiumCalculator
This app will calculate the monthly premium.
Given inputs are Name, Date of birth, Age, and occupation

#Assumptions:
Age is calcluated based on date of birth entered.
Have not connected to any database. All data are Mocked repository class.

#Tech stack
.Net core
C#
xunit
Angular 12.2.10

#Request and response

End point : /api/premuim
Request object
{
  "name": "Thiyaga",
  "age": 38,
  "dateOfBirth": "1983-10-28T00:19:49.074Z",
  "occupationName": "Doctor",
  "sumAssured": 1000000
}
Response : 3166.67

End point : /api/age
Request - 01-02-1983
Response - 38

End point : ​/api​/occupation
Get:

[
  {
    "OccupationId": 1,
    "OccupationName": "Cleaner",
    "OccupationRating": "Light Manual",
    "Ratings": {
      "RatingId": 3,
      "RatingName": "Light Manual",
      "Factor": 1.5
    }
  },
  {
    "OccupationId": 2,
    "OccupationName": "Doctor",
    "OccupationRating": "Professional",
    "Ratings": {
      "RatingId": 1,
      "RatingName": "Professional",
      "Factor": 1
    }
  },
  {
    "OccupationId": 3,
    "OccupationName": "Author",
    "OccupationRating": "White Collar",
    "Ratings": {
      "RatingId": 2,
      "RatingName": "White Collar",
      "Factor": 1.25
    }
  },
  {
    "OccupationId": 4,
    "OccupationName": "Farmer",
    "OccupationRating": "Heavy Manual",
    "Ratings": {
      "RatingId": 3,
      "RatingName": "Light Manual",
      "Factor": 1.5
    }
  },
  {
    "OccupationId": 5,
    "OccupationName": "Mechanic",
    "OccupationRating": "Heavy Manual",
    "Ratings": {
      "RatingId": 1,
      "RatingName": "Professional",
      "Factor": 1
    }
  },
  {
    "OccupationId": 6,
    "OccupationName": "Florist",
    "OccupationRating": "Light Manual",
    "Ratings": {
      "RatingId": 1,
      "RatingName": "Professional",
      "Factor": 1
    }
  }
]