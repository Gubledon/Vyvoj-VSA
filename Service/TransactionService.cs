using MyApiň.Models;
using MyApiň.Repository;

namespace MyApiň.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public List<Transaction> GetAllTransactions()
        {
            var transactions = transactionRepository.GetAllTransactions();
            return transactions;
        }

        public Transaction? GetTransactionById(int id)
        {
            var transaction = transactionRepository.GetTransaction(id);
            return transaction;
        }
    }
}
