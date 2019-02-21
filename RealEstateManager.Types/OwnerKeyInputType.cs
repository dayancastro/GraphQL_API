using GraphQL.Types;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Types
{
    public class OwnerKeyInputType : InputObjectGraphType<OwnerKey>
    {
        public OwnerKeyInputType()
        {
            Field<NonNullGraphType<IntGraphType>>("type");
            Field<NonNullGraphType<StringGraphType>>("name");
        }
    }
}
