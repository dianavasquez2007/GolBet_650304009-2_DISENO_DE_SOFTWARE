using GolBet.Entities.Enums;
using GolBet.Services.DTOs;


namespace GolBet.Services.Interfaces
{
    public interface IMatchService
    {
        /// Se modifica
        Task<IEnumerable<MatchDto>> GetAllMatchesAsync(MatchStatus? status = null, string? search = null);
        Task<MatchDetailDto?> GetDetailAsync(int id);
        Task<MatchFormDto?> GetForEditAsync(int id);
        Task CreateAsync(MatchFormDto dto);
        Task UpdateAsync(MatchFormDto dto);
        Task DeactivateAsync(int id);
    }

}