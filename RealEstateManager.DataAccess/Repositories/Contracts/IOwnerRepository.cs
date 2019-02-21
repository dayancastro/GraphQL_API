using RealEstateManager.Database.Models;
using System.Collections.Generic;

namespace RealEstateManager.DataAccess.Repositories.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
        Owner GetById(OwnerKey key);
        Owner Add(Owner owner);
        bool Remove(int id);
    }
}
