using System.Collections.Generic;
using MyApiň.DatabaseModel;

namespace MyApiň.Repository
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAllTransactions();
        Transaction? GetTransactionById(int id);
    }
}
