using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackingApp.API.models;

namespace TrackingApp.API.Data
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly DataContext _db;
        public OrganizationRepository(DataContext db)
        {
            _db = db;

        }
        public void Add<T>(T entity) where T : class
        {
            _db.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _db.Remove(entity);
        }

        public async Task<Organization> GetOrganization(int id)
        {
            var organization = await _db.Organizations.FirstOrDefaultAsync(x => x.Id == id);
            return organization;
        }

        public async Task<IEnumerable<Organization>> GetOrganizations()
        {
            var organizations = await _db.Organizations.ToListAsync();
            return organizations;
        }

        public async Task<bool> SaveAll()
        {
            return await _db.SaveChangesAsync() > 0;
        }

    }
}