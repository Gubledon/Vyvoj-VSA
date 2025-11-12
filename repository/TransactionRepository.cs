using System.Collections.Generic;
using System.Linq;
using MyApiň.Models;

namespace MyApiň.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly List<Transaction> transactions;

        public TransactionRepository()
        {
            transactions = new List<Transaction>
            {
                new Transaction
                {
                    TransactionId = 1,
                },
                new Transaction
                {
                    TransactionId = 2,
                }
            };
        }

        public List<Transaction> GetAllTransactions()
        {
            return transactions;
        }

        public Transaction? GetTransaction(int id)
        {
            // TransactionId je decimal; int sa porovnáva OK (prevedie sa na decimal)
            return transactions.FirstOrDefault(p => p.TransactionId == id);
        }
    }
}
