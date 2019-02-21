using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database;
using RealEstateManager.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateManager.DataAccess.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private RealEstateContext _dbContext;

        public OwnerRepository(RealEstateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Owner Add(Owner owner)
        {
            _dbContext.Owners.Add(owner);
            _dbContext.SaveChanges();
            return owner;
        }

        public IEnumerable<Owner> GetAll()
        {
            return _dbContext.Owners;
        }

        public Owner GetById(OwnerKey key)
        {
            return _dbContext.Owners.SingleOrDefault(x => x.Type == key.Type && x.Name.Equals(key.Name));
        }

        public bool Remove(int id)
        {
            //var owner = _dbContext.Owners.SingleOrDefault(x => x.Id == id);
            //_dbContext.Remove(owner);
            //_dbContext.SaveChanges();
            return true;
        }
    }
}
