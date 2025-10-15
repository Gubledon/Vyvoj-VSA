import { Routes } from '@angular/router';
import { BasicAccountsDetailComponent } from './basic-accounts/basic-accounts-detail/basic-accounts-detail.component'

import { BasicDetailComponent } from './basic-accounts/basic-accounts-detail/basic-detail/basic-detail.component'
import { WithdrawalDetailComponent } from './basic-accounts/basic-accounts-detail/withdrawal-detail/withdrawal-detail.component'

import { BasicAccountsListComponent } from './basic-accounts/basic-accounts-list/basic-accounts-list.component'
import { DashboardComponent } from './dashboard/dashboard.component'


export const routes: Routes = [
  {
    path: 'basic-accounts/basic-accounts-detail',
    component: BasicAccountsDetailComponent
  },

  {
    path: 'basic-accounts/basic-accounts-detail/basic-detail',
    component: BasicDetailComponent
  },

  {
    path: 'basic-accounts/basic-accounts-detail/withdrawal-detail',
    component: WithdrawalDetailComponent
  },

  {
    path: 'basic-accounts/basic-accounts-list',
    component: BasicAccountsListComponent
  },

  {
    path: 'dashboard',
    component: DashboardComponent
  },

  { path: '**', component: DashboardComponent }
];
