import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ValueComponent } from './value/value.component';
import { ItemDetailsComponent } from './item-details/item-details.component';

const routes: Routes = [
  { path: 'items', component: ValueComponent },
  { path: 'item', component: ItemDetailsComponent },
  { path: 'item/:id', component: ItemDetailsComponent },
  { path: '', redirectTo: '/items', pathMatch: 'full' }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
  ],
  exports: [
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }
