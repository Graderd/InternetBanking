using InternetBanking.DataAccess.Models;


namespace InternetBanking.core.Interfaces
{
    public  interface IAcountsService
    {
        Task<List<Acounts>> GetAcountsAsync();
        Task<Acounts> GetAcountsByIdAsync(int id);
        Task<bool> AddAcountsAsync(Acounts acounts);
        Task<bool> UpdateAcountsAsync(Acounts acounts);
        Task<bool> DeleteAcountsAsync(int id);
    }
}
