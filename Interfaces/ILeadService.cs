using crm_Ilmhub.Models;

namespace crm_Ilmhub.Interfaces;

public interface ILeadService
{
    ValueTask<IEnumerable<Lead>> GetLeadsAsync(CancellationToken cancellationToken = default);
    ValueTask<Lead?> GetLeadByIdAsync(int id, CancellationToken cancellationToken = default);
    ValueTask<Lead> CreateLeadAsync(Lead lead, CancellationToken cancellationToken = default);
    ValueTask<Lead> UpdateLeadAsync(Lead lead, CancellationToken cancellationToken = default);
    ValueTask<bool> DeleteLeadAsync(int id, CancellationToken cancellationToken = default);
    Task<List<Lead>> GetHiddenLeadsAsync();
    Task UpdateLeadVisibilityAsync(Lead lead, bool isHidden);
}