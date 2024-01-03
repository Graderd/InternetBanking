using InternetBanking.core.Dtos.Accounts;
using InternetBanking.DataAccess.Models;


namespace InternetBanking.core.Interfaces
{
    public  interface IAccountsService
    {
        Task<List<Accounts>> GetAccountsAsync();
        Task<Accounts> GetAccountsByIdAsync(int id);
        Task<bool> AddAccountsAsync(AccountsInsertDto accounts);
        Task<bool> DeleteAccountsAsync(int id);
    }
}
