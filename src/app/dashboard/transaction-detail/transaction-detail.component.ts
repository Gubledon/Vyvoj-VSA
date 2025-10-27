import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { TransactionsService, ITransaction } from '../../api/transactions.service';

@Component({
  selector: 'app-transaction-detail',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './transaction-detail.component.html',
  styleUrls: ['./transaction-detail.component.css']
})
export class TransactionDetailComponent {
  transaction?: ITransaction;

  constructor(private route: ActivatedRoute, private tx: TransactionsService) {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.tx.getTransactionDetail$(id).subscribe(res => this.transaction = res.data);
    }
  }
}
