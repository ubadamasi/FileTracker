using System.Collections.Generic;
using System.Threading.Tasks;
using TrackingApp.API.models;

namespace TrackingApp.API.Data
{
    public interface IDepartmentRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}