using System.Collections.Generic;
using MyApiň.Repository;
using MyApiň.ViewModel;

namespace MyApiň.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository repository;

        public TransactionService(ITransactionRepository repository)
        {
            this.repository = repository;
        }

        public List<TransactionViewModel> GetAllTransactions()
        {
            var transactionsViewModel = new List<TransactionViewModel>();

            var transactions = this.repository .GetAllTransactions();

            foreach (var transaction in transactions)
            {
                var transactionViewModel = new TransactionViewModel
                {
                    TransactionId   = transaction.Id,
                    FullName        = transaction.User?.Name ?? string.Empty,
                    TransactionType = transaction.TransactionType?.Name ?? string.Empty,
                    AccountNumber   = transaction.AccountNumber,
                    BankCode        = transaction.BankCode,
                    IssueDate       = transaction.IssueDate,
                    Amount          = transaction.Amount
                };

                transactionsViewModel.Add(transactionViewModel);
            }

            return transactionsViewModel;
        }

        // GET BY ID
        public TransactionViewModel? GetTransactionById(int id)
        {
            var transaction = this.repository .GetTransactionById(id);

            if (transaction == null)
                return null;

            var transactionViewModel = new TransactionViewModel
            {
                TransactionId   = transaction.Id,
                FullName        = transaction.User?.Name ?? string.Empty,
                TransactionType = transaction.TransactionType?.Name ?? string.Empty,
                AccountNumber   = transaction.AccountNumber,
                BankCode        = transaction.BankCode,
                IssueDate       = transaction.IssueDate,
                Amount          = transaction.Amount
            };

            return transactionViewModel;
        }
    }
}

