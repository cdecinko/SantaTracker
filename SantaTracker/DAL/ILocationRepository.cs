using SantaTracker.Models;
using System.Collections.Generic;

namespace SantaTracker.DAL
{
    public interface ILocationRepository
    {
        IEnumerable<Location> SelectAll();
        Location SelectByID(string id);
        void Insert(Location obj);
        void Update(Location obj);
        void Delete(string id);
        void Save();
    }
}
