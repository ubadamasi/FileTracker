using System.Collections.Generic;
using System.Threading.Tasks;
using TrackingApp.API.models;

namespace TrackingApp.API.Data
{
    public interface IMailRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<Mail>> GetMails();
        Task<IEnumerable<Mail>> GetIncomingMailsByDepartment();
        Task<IEnumerable<Mail>> GetOutgoingMailsByDepartment();
        Task<Mail> GetMail();
    }
}