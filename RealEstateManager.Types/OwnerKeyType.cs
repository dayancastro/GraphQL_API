using GraphQL.Types;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Types
{
    public class OwnerKeyType : ObjectGraphType<OwnerKey>
    {
        public OwnerKeyType()
        {
            Field(x=>x.Type);
            Field(x=>x.Name);
        }
    }
}
