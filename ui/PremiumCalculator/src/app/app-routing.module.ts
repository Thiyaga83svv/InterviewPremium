import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PremiumformComponent } from './premiumform/premiumform.component';
const routes: Routes = [
  {path: 'premiumform', component:PremiumformComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
