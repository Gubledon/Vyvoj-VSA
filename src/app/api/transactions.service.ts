import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface ITransaction {
  transactionId: number;
  amount: number;
  bankCode: string;
  issueDate: string;
  transactionType?: number;
  fullName?: string;
  accountNumber?: string;
}

@Injectable({ providedIn: 'root' })
export class TransactionsService {
  private http = inject(HttpClient);

  getTransactions$(): Observable<{ data: ITransaction[] }> {
    return this.http.get<{ data: ITransaction[] }>('/api/transactions');
  }

  getTransactionDetail$(id: number | string): Observable<{ data: ITransaction }> {
    return this.http.get<{ data: ITransaction }>(`/api/transactions/${id}`);
  }
}
