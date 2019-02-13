using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database;
using RealEstateManager.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateManager.DataAccess.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private RealEstateContext _dbContext;

        public PaymentRepository(RealEstateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Payment> GetAll()
        {
            return _dbContext.Payments;
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId)
        {
            return _dbContext.Payments.Where(x => x.PropertyId == propertyId);
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount)
        {
            return _dbContext.Payments.Where(x => x.PropertyId == propertyId)
                .OrderByDescending(x => x.DateCreated)
                .Take(lastAmount);
        }
    }
}
