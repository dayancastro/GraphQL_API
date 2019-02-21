using GraphQL.Types;
using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Types
{
    public class OwnerInputType : InputObjectGraphType<Owner>
    {
        public OwnerInputType(IOwnerRepository ownerRepository)
        {
            Field<NonNullGraphType<IntGraphType>>("type");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("address");

        }
    }
}
