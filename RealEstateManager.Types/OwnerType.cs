using GraphQL.Types;
using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database.Models;

namespace RealEstateManager.Types
{
    public class OwnerType : ObjectGraphType<Owner>
    {
        public OwnerType(IOwnerRepository ownerRepository)
        {
            Field(x => x.Type);
            Field(x => x.Name);
            Field(x => x.Address);


            //Field(x => x.PurchaseDate);
            //Field(x => x.PurchaseValue);
            //Field(x => x.SellDate);
            //Field(x => x.SellValue);
            //Field<ListGraphType<PropertyOwnerType>>("porpertyOwner",
            //    resolve: context => propertyOwnerRepository.GetAllForOwner(context.Source.Id));

        }
    }
}
