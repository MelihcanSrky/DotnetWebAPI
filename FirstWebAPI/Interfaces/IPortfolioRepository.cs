using FirstWebAPI.Models;

namespace FirstWebAPI.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<List<Stock>> GetUserPortfolio(AppUser user);
        Task<Portfolio> CreatePortfolioAsync(Portfolio portfolio);
        Task<Portfolio?> DeletePortfolioAsync(AppUser appUser, string symbol);
    }
}
