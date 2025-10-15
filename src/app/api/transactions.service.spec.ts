/// <reference types="jasmine" />

import { TestBed } from '@angular/core/testing';
import { provideHttpClient } from '@angular/common/http';
import { provideHttpClientTesting, HttpTestingController } from '@angular/common/http/testing';
import { TransactionsService, ITransaction } from './transactions.service';

describe('TransactionsService', () => {
  let service: TransactionsService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [provideHttpClient(), provideHttpClientTesting()]
    });
    service = TestBed.inject(TransactionsService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => httpMock.verify());

  it('getTransactions$ calls /api/transactions and returns data', () => {
    const mock: { data: ITransaction[] } = {
      data: [{ transactionId: 1, amount: 10, bankCode: '1234', issueDate: '2025-01-01', transactionType: 0 }]
    };

    // ⬇️ DÔLEŽITÉ: presne typuj res, nech je data = ITransaction[]
    service.getTransactions$().subscribe((res: { data: ITransaction[] }) => {
      expect(Array.isArray(res.data)).toBeTrue();   // poistka pre TS
      expect(res.data.length).toBe(1);
      expect(res.data[0].transactionId).toBe(1);
    });

    const req = httpMock.expectOne('/api/transactions');
    expect(req.request.method).toBe('GET');
    req.flush(mock);
  });

  it('getTransactionDetail$ calls /api/transactions/:id', () => {
    const mock: { data: ITransaction } = {
      data: { transactionId: 7, amount: 100, bankCode: '4321', issueDate: '2025-02-02', transactionType: 1 }
    };

    service.getTransactionDetail$(7).subscribe((res: { data: ITransaction }) => {
      expect(res.data.transactionId).toBe(7);
    });

    const req = httpMock.expectOne('/api/transactions/7');
    expect(req.request.method).toBe('GET');
    req.flush(mock);
  });
});
