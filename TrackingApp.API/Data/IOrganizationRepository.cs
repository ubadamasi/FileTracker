using System.Collections.Generic;
using System.Threading.Tasks;
using TrackingApp.API.models;

namespace TrackingApp.API.Data
{
    public interface IOrganizationRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<Organization>> GetOrganizations();
        Task<Organization> GetOrganization(int id);
    }
}