import { Component } from '@angular/core';
import { TransactionsService, ITransaction } from '../api/transactions.service';
import { MatTableModule } from '@angular/material/table';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';


@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,      
    MatTableModule,
    MatIconModule,    
    MatButtonModule    
  ],
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  transactionList: ITransaction[] = [];

  constructor(private tx: TransactionsService) {
    this.tx.getTransactions$().subscribe(res => this.transactionList = res.data);
  }
}


