using InternetBanking.DataAccess.Models;


namespace InternetBanking.core.Interfaces
{
    public  interface IAccountsService
    {
        Task<List<Accounts>> GetAccountsAsync();
        Task<Accounts> GetAccountsByIdAsync(int id);
        Task<bool> AddAccountsAsync(Accounts accounts);
        Task<bool> UpdateAccountsAsync(Accounts accounts);
        Task<bool> DeleteAccountsAsync(int id);
    }
}
