using SantaTracker.Models;
using System.Collections.Generic;

namespace SantaTracker.DAL
{
    public interface ISantaRepository
    {
        IEnumerable<Santa> SelectAll();
        Santa SelectByID(string id);
        void Insert(Santa obj);
        void Update(Santa obj);
        void Delete(string id);
        void Save();
    }
}
