using System.Collections.Generic;
using MyApiň.Models;

namespace MyApiň.Repository
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAllTransactions();
        Transaction? GetTransaction(int id); // podľa slidu
    }
}
