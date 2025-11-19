
using MyApiň.ViewModel;

namespace MyApiň.Service
{
    public interface ITransactionService
    {
        List<TransactionViewModel> GetAllTransactions();
        TransactionViewModel? GetTransactionById(int id);
    }
}
