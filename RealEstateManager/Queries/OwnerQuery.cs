using GraphQL.Types;
using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Types;

namespace RealEstateManager.Queries
{
    public class OwnerQuery : ObjectGraphType
    {
        public OwnerQuery(IOwnerRepository ownerRepository)
        {
            
        }
    }
}
