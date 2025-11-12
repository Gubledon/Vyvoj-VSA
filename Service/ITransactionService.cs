using System.Collections.Generic;
using MyApiň.Models;

namespace MyApiň.Service
{
    public interface ITransactionService
    {
        List<Transaction> GetAllTransactions();
        Transaction? GetTransactionById(int id);
    }
}
