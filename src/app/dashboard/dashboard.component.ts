import { Component } from '@angular/core';
import { TransactionsService, ITransaction } from '../api/transactions.service';


@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {
  transactionList: ITransaction[] = [];
  constructor(private tx: TransactionsService) {
    this.tx.getTransactions$().subscribe(res => this.transactionList = res.data);
  }
}
