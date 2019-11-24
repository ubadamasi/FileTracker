using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackingApp.API.models;

namespace TrackingApp.API.Data
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _db;
        public DepartmentRepository(DataContext db)
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

        public async Task<Department> GetDepartment(int id)
        {
            var dep = await _db.Departments.FirstOrDefaultAsync(x => x.Id == id);
            return dep;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            var dep = await _db.Departments.ToListAsync();
            return dep;
        }

        public async Task<bool> SaveAll()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}